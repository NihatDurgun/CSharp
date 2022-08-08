using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLearningApp.Common;
using QLearningApp.MachineLearning;

namespace QLearningApp
{
    public partial class Start : Form
    {
        public static int[] EngelUret()
        {
            Random rastgele = new Random();
            int k = 0;
            int m;
            int[] engel = new int[4];
            for (int l = 0; l < 4; l++)
            {
                engel[l] = -99;
            }
            while (k < 4)
            {
                int sayi = rastgele.Next(0, 15);
                for (m = 0; m < 4; m++)
                {
                    if (sayi == engel[m])
                    {
                        continue;
                    }
                }
                engel[k] = sayi;
                k++;
            }
            return engel;
        }

        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ÖNEMLİ::Baslangıç,bitiş üzerinde engel koyuyor
            int[] block = EngelUret();
            var qLearning = new QLearning(0.8, new RoomsProblem(block, Convert.ToInt32(endPointTB.Text.ToString())));
            qLearning.TrainAgent(2000, Convert.ToInt32(endPointTB.Text.ToString()));
            int initialState = 0;

            QLearningStats qLearningStats = qLearning.Run(Convert.ToInt32(startPointTB.Text.ToString()),Convert.ToInt32(endPointTB.Text.ToString()));
            var normalizedMatrix = qLearning.QTable.NormalizeMatrix();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(block[i]);
            }
            Main main = new Main(qLearningStats.InitialState, qLearningStats.EndState, qLearningStats.Actions, block);
            main.Visible = true;
            this.Visible = false;
        }
    }
}
