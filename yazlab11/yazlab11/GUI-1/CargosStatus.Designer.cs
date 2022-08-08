
namespace yazlab11
{
    partial class CargosStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cargoType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_CargoName = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.column_cargoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_cargoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column__cargotype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_cargostatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_cargoaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_cargolatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_cargolongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_makeRoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_cargoStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_deliveryAddress = new System.Windows.Forms.TextBox();
            this.button_updateAddress = new System.Windows.Forms.Button();
            this.button_addCargo = new System.Windows.Forms.Button();
            this.button_updateCargo = new System.Windows.Forms.Button();
            this.button_deleteCargo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_longitude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_latitude = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_cargoID = new System.Windows.Forms.TextBox();
            this.KargoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cargo Type:";
            // 
            // textBox_cargoType
            // 
            this.textBox_cargoType.Location = new System.Drawing.Point(188, 36);
            this.textBox_cargoType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cargoType.Name = "textBox_cargoType";
            this.textBox_cargoType.Size = new System.Drawing.Size(176, 23);
            this.textBox_cargoType.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cargo Name:";
            // 
            // textBox_CargoName
            // 
            this.textBox_CargoName.Location = new System.Drawing.Point(6, 78);
            this.textBox_CargoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CargoName.Name = "textBox_CargoName";
            this.textBox_CargoName.Size = new System.Drawing.Size(176, 23);
            this.textBox_CargoName.TabIndex = 27;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_cargoid,
            this.column_cargoname,
            this.column__cargotype,
            this.column_cargostatus,
            this.column_cargoaddress,
            this.column_cargolatitude,
            this.column_cargolongitude});
            this.dgv.Location = new System.Drawing.Point(10, 54);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(759, 411);
            this.dgv.TabIndex = 31;
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // column_cargoid
            // 
            this.column_cargoid.HeaderText = "Cargo ID";
            this.column_cargoid.Name = "column_cargoid";
            // 
            // column_cargoname
            // 
            this.column_cargoname.HeaderText = "Cargo Name";
            this.column_cargoname.Name = "column_cargoname";
            // 
            // column__cargotype
            // 
            this.column__cargotype.HeaderText = "Cargo Type";
            this.column__cargotype.Name = "column__cargotype";
            // 
            // column_cargostatus
            // 
            this.column_cargostatus.HeaderText = "Cargo Status";
            this.column_cargostatus.Name = "column_cargostatus";
            // 
            // column_cargoaddress
            // 
            this.column_cargoaddress.HeaderText = "Cargo Address";
            this.column_cargoaddress.Name = "column_cargoaddress";
            // 
            // column_cargolatitude
            // 
            this.column_cargolatitude.HeaderText = "Cargo Latitude";
            this.column_cargolatitude.Name = "column_cargolatitude";
            // 
            // column_cargolongitude
            // 
            this.column_cargolongitude.HeaderText = "Cargo Longitude";
            this.column_cargolongitude.Name = "column_cargolongitude";
            // 
            // button_makeRoute
            // 
            this.button_makeRoute.Location = new System.Drawing.Point(10, 8);
            this.button_makeRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_makeRoute.Name = "button_makeRoute";
            this.button_makeRoute.Size = new System.Drawing.Size(184, 39);
            this.button_makeRoute.TabIndex = 32;
            this.button_makeRoute.Text = "Make Route";
            this.button_makeRoute.UseVisualStyleBackColor = true;
            this.button_makeRoute.Click += new System.EventHandler(this.button_makeRoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cargo ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cargo Status:";
            // 
            // comboBox_cargoStatus
            // 
            this.comboBox_cargoStatus.FormattingEnabled = true;
            this.comboBox_cargoStatus.Items.AddRange(new object[] {
            "Teslim Edildi",
            "Teslim Edilmedi"});
            this.comboBox_cargoStatus.Location = new System.Drawing.Point(188, 78);
            this.comboBox_cargoStatus.Name = "comboBox_cargoStatus";
            this.comboBox_cargoStatus.Size = new System.Drawing.Size(176, 23);
            this.comboBox_cargoStatus.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Delivery Address:";
            // 
            // textBox_deliveryAddress
            // 
            this.textBox_deliveryAddress.Location = new System.Drawing.Point(6, 36);
            this.textBox_deliveryAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_deliveryAddress.Multiline = true;
            this.textBox_deliveryAddress.Name = "textBox_deliveryAddress";
            this.textBox_deliveryAddress.ReadOnly = true;
            this.textBox_deliveryAddress.Size = new System.Drawing.Size(176, 68);
            this.textBox_deliveryAddress.TabIndex = 39;
            // 
            // button_updateAddress
            // 
            this.button_updateAddress.Location = new System.Drawing.Point(189, 74);
            this.button_updateAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_updateAddress.Name = "button_updateAddress";
            this.button_updateAddress.Size = new System.Drawing.Size(176, 31);
            this.button_updateAddress.TabIndex = 41;
            this.button_updateAddress.Text = "Update Address";
            this.button_updateAddress.UseVisualStyleBackColor = true;
            this.button_updateAddress.Click += new System.EventHandler(this.button_updateAddress_Click);
            // 
            // button_addCargo
            // 
            this.button_addCargo.Location = new System.Drawing.Point(593, 8);
            this.button_addCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_addCargo.Name = "button_addCargo";
            this.button_addCargo.Size = new System.Drawing.Size(176, 39);
            this.button_addCargo.TabIndex = 44;
            this.button_addCargo.Text = "Add Cargo";
            this.button_addCargo.UseVisualStyleBackColor = true;
            this.button_addCargo.Click += new System.EventHandler(this.button_addCargo_Click);
            // 
            // button_updateCargo
            // 
            this.button_updateCargo.Location = new System.Drawing.Point(407, 8);
            this.button_updateCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_updateCargo.Name = "button_updateCargo";
            this.button_updateCargo.Size = new System.Drawing.Size(180, 39);
            this.button_updateCargo.TabIndex = 45;
            this.button_updateCargo.Text = "Update Cargo";
            this.button_updateCargo.UseVisualStyleBackColor = true;
            this.button_updateCargo.Click += new System.EventHandler(this.button_updateCargo_Click);
            // 
            // button_deleteCargo
            // 
            this.button_deleteCargo.Location = new System.Drawing.Point(200, 8);
            this.button_deleteCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_deleteCargo.Name = "button_deleteCargo";
            this.button_deleteCargo.Size = new System.Drawing.Size(201, 39);
            this.button_deleteCargo.TabIndex = 46;
            this.button_deleteCargo.Text = "Delete Cargo";
            this.button_deleteCargo.UseVisualStyleBackColor = true;
            this.button_deleteCargo.Click += new System.EventHandler(this.button_deleteCargo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbox_longitude);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textbox_latitude);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_updateAddress);
            this.groupBox1.Controls.Add(this.textBox_deliveryAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 116);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address İnformation";
            // 
            // textbox_longitude
            // 
            this.textbox_longitude.Location = new System.Drawing.Point(281, 37);
            this.textbox_longitude.Name = "textbox_longitude";
            this.textbox_longitude.ReadOnly = true;
            this.textbox_longitude.Size = new System.Drawing.Size(84, 23);
            this.textbox_longitude.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Longitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Latitude:";
            // 
            // textbox_latitude
            // 
            this.textbox_latitude.Location = new System.Drawing.Point(189, 37);
            this.textbox_latitude.Name = "textbox_latitude";
            this.textbox_latitude.ReadOnly = true;
            this.textbox_latitude.Size = new System.Drawing.Size(84, 23);
            this.textbox_latitude.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_cargoID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_cargoType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_CargoName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox_cargoStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(394, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 116);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargo İnformation:";
            // 
            // textBox_cargoID
            // 
            this.textBox_cargoID.Location = new System.Drawing.Point(6, 36);
            this.textBox_cargoID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cargoID.Name = "textBox_cargoID";
            this.textBox_cargoID.Size = new System.Drawing.Size(176, 23);
            this.textBox_cargoID.TabIndex = 39;
            // 
            // KargoID
            // 
            this.KargoID.HeaderText = "KargoID";
            this.KargoID.MinimumWidth = 6;
            this.KargoID.Name = "KargoID";
            this.KargoID.Width = 125;
            // 
            // KargoAdi
            // 
            this.KargoAdi.HeaderText = "Kargo Adi";
            this.KargoAdi.MinimumWidth = 6;
            this.KargoAdi.Name = "KargoAdi";
            this.KargoAdi.Width = 125;
            // 
            // KargoTuru
            // 
            this.KargoTuru.HeaderText = "Kargo Türü";
            this.KargoTuru.MinimumWidth = 6;
            this.KargoTuru.Name = "KargoTuru";
            this.KargoTuru.Width = 125;
            // 
            // KargoDurum
            // 
            this.KargoDurum.HeaderText = "Kargo Durumu";
            this.KargoDurum.MinimumWidth = 6;
            this.KargoDurum.Name = "KargoDurum";
            this.KargoDurum.Width = 125;
            // 
            // CargosStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_deleteCargo);
            this.Controls.Add(this.button_updateCargo);
            this.Controls.Add(this.button_addCargo);
            this.Controls.Add(this.button_makeRoute);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CargosStatus";
            this.Text = " Cargo Information";
            this.Load += new System.EventHandler(this.CargoInformation);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cargoType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_CargoName;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button_makeRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_cargoStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_deliveryAddress;
        private System.Windows.Forms.Button button_updateAddress;
        private System.Windows.Forms.Button button_addCargo;
        private System.Windows.Forms.Button button_updateCargo;
        private System.Windows.Forms.Button button_deleteCargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_cargoID;
        private System.Windows.Forms.TextBox textbox_longitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cargoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cargoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn column__cargotype;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cargostatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cargoaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cargolatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cargolongitude;
    }
}