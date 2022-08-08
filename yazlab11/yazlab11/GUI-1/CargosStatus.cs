using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace yazlab11
{

    public partial class CargosStatus : Form
    {
        AddressSelection addressSelection;
        bool addressSelection_Status = false;
        IFirebaseClient client = new FireSharp.FirebaseClient(credential.config);

        public CargosStatus()
        {
            InitializeComponent();
        }


        public void UpdateAddress(string address,string latitude, string longitude)
        {
            addressSelection_Status = false;
            textbox_longitude.Text = longitude;
            textbox_latitude.Text = latitude;
            textBox_deliveryAddress.Text = address;   
        }

        public async void getDatas()
        {
            try
            {
                FirebaseResponse result = await client.GetTaskAsync("Cargos");
                if (result.Body != "null")
                {
                    List<CargoDatas> listCargoData = result.ResultAs<List<CargoDatas>>();

                    foreach (var item in listCargoData)
                    {
                        if (item != null)
                        {
                            dgv.Rows.Add(item.IDCargo, item.NameCargo, item.TypeCargo, item.StatusCargo, item.AddressCargo, item.LatitudeCargo, item.LongitudeCargo);
                        }
                    }
                }
            }catch(Exception ex) { }
        }

        private async void CargoInformation(object sender, EventArgs e)
        {
            getDatas();
        }

        private void button_makeRoute_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please Select Start Point!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                AddressSelection startPoint = new AddressSelection();
                startPoint.Show();
            }
        }

        private async void button_deleteCargo_Click(object sender, EventArgs e)
        {
            var cargoDatas = new CargoDatas()
            {
                IDCargo = textBox_cargoID.Text,
                NameCargo = textBox_CargoName.Text,
                TypeCargo = textBox_cargoType.Text,
                StatusCargo = comboBox_cargoStatus.Text,
                AddressCargo = textBox_deliveryAddress.Text,
                LatitudeCargo = textbox_latitude.Text,
                LongitudeCargo = textbox_longitude.Text
            };
            var data = await client.DeleteTaskAsync("Cargos/" + textBox_cargoID.Text);
            reload();
        }

        private async void reload()
        {
            dgv.Rows.Clear();
            getDatas();
        }

        private async void button_updateCargo_Click(object sender, EventArgs e)
        {
            var getCargoID = new CargoDatas()
            {
                IDCargo = textBox_cargoID.Text
            };

            FirebaseResponse result = await client.GetTaskAsync("Cargos/" + textBox_cargoID.Text);
            CargoDatas cargoDatas_Object = result.ResultAs<CargoDatas>();

            var cargoDatas = new CargoDatas()
            {
                IDCargo = cargoDatas_Object.IDCargo,
                NameCargo = textBox_CargoName.Text,
                TypeCargo = textBox_cargoType.Text,
                StatusCargo = comboBox_cargoStatus.Text,
                AddressCargo = textBox_deliveryAddress.Text,
                LatitudeCargo = textbox_latitude.Text,
                LongitudeCargo = textbox_longitude.Text
            };
            FirebaseResponse response = await client.UpdateTaskAsync("Kargolar/" + getCargoID.IDCargo, cargoDatas);
            CargoDatas updateResult = response.ResultAs<CargoDatas>();
            reload();
        }

        private async void button_addCargo_Click(object sender, EventArgs e)
        {
            var data = new CargoDatas
            {
                IDCargo = textBox_cargoID.Text,
                NameCargo = textBox_CargoName.Text,
                TypeCargo = textBox_cargoType.Text,
                StatusCargo = comboBox_cargoStatus.Text,
                AddressCargo = textBox_deliveryAddress.Text,
                LatitudeCargo = textbox_latitude.Text,
                LongitudeCargo = textbox_longitude.Text
            };

            SetResponse response = await client.SetTaskAsync("Cargos/" + textBox_cargoID.Text, data);
            CargoDatas.result = response.ResultAs<CargoDatas>();
            dgv.Rows.Clear();
            getDatas();
        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            int secilen = dgv.SelectedCells[0].RowIndex;

            if (dgv.Rows[secilen].Cells[0].Value != null)
            {
                textBox_cargoID.Text = dgv.Rows[secilen].Cells[0].Value.ToString();
                textBox_CargoName.Text = dgv.Rows[secilen].Cells[1].Value.ToString();
                textBox_cargoType.Text = dgv.Rows[secilen].Cells[2].Value.ToString();
                comboBox_cargoStatus.Text = dgv.Rows[secilen].Cells[3].Value.ToString();
                textBox_deliveryAddress.Text = dgv.Rows[secilen].Cells[4].Value.ToString();
                textbox_latitude.Text = dgv.Rows[secilen].Cells[5].Value.ToString();
                textbox_longitude.Text = dgv.Rows[secilen].Cells[6].Value.ToString();
            }
        }

        private void button_updateAddress_Click(object sender, EventArgs e)
        {
            if (addressSelection_Status == false)
            {
                addressSelection = new AddressSelection(cargoStatus: this);
                addressSelection_Status = true;
                addressSelection.Show();
            }
        }
    }
}
