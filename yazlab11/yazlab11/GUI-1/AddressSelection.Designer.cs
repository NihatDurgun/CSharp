
namespace yazlab11
{
    partial class AddressSelection
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
            this.gmapView = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_setAddress = new System.Windows.Forms.Button();
            this.button_getLocFromMap = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_longitude = new System.Windows.Forms.TextBox();
            this.textbox_latitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmapView
            // 
            this.gmapView.Bearing = 0F;
            this.gmapView.CanDragMap = true;
            this.gmapView.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapView.GrayScaleMode = false;
            this.gmapView.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapView.LevelsKeepInMemory = 5;
            this.gmapView.Location = new System.Drawing.Point(12, 70);
            this.gmapView.MarkersEnabled = true;
            this.gmapView.MaxZoom = 2;
            this.gmapView.MinZoom = 2;
            this.gmapView.MouseWheelZoomEnabled = true;
            this.gmapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapView.Name = "gmapView";
            this.gmapView.NegativeMode = false;
            this.gmapView.PolygonsEnabled = true;
            this.gmapView.RetryLoadTile = 0;
            this.gmapView.RoutesEnabled = true;
            this.gmapView.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapView.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapView.ShowTileGridLines = false;
            this.gmapView.Size = new System.Drawing.Size(685, 338);
            this.gmapView.TabIndex = 15;
            this.gmapView.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_setAddress);
            this.groupBox1.Controls.Add(this.button_getLocFromMap);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Location = new System.Drawing.Point(12, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 55);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // button_setAddress
            // 
            this.button_setAddress.Location = new System.Drawing.Point(6, 17);
            this.button_setAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_setAddress.Name = "button_setAddress";
            this.button_setAddress.Size = new System.Drawing.Size(219, 31);
            this.button_setAddress.TabIndex = 21;
            this.button_setAddress.Text = "Set Address";
            this.button_setAddress.UseVisualStyleBackColor = true;
            this.button_setAddress.Click += new System.EventHandler(this.button_setAddress_Click);
            // 
            // button_getLocFromMap
            // 
            this.button_getLocFromMap.Location = new System.Drawing.Point(231, 17);
            this.button_getLocFromMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_getLocFromMap.Name = "button_getLocFromMap";
            this.button_getLocFromMap.Size = new System.Drawing.Size(226, 31);
            this.button_getLocFromMap.TabIndex = 20;
            this.button_getLocFromMap.Text = "Get Location From Map";
            this.button_getLocFromMap.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(463, 18);
            this.button_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(219, 30);
            this.button_reset.TabIndex = 19;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_search);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.address_textbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 54);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search With Location:";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(258, 19);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(90, 25);
            this.button_search.TabIndex = 12;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 16;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(6, 20);
            this.address_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(246, 23);
            this.address_textbox.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textbox_longitude);
            this.groupBox3.Controls.Add(this.textbox_latitude);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(372, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 55);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude:";
            // 
            // textbox_longitude
            // 
            this.textbox_longitude.Location = new System.Drawing.Point(221, 19);
            this.textbox_longitude.Name = "textbox_longitude";
            this.textbox_longitude.ReadOnly = true;
            this.textbox_longitude.Size = new System.Drawing.Size(100, 23);
            this.textbox_longitude.TabIndex = 2;
            // 
            // textbox_latitude
            // 
            this.textbox_latitude.Location = new System.Drawing.Point(56, 20);
            this.textbox_latitude.Name = "textbox_latitude";
            this.textbox_latitude.ReadOnly = true;
            this.textbox_latitude.Size = new System.Drawing.Size(100, 23);
            this.textbox_latitude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude:";
            // 
            // AddressSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gmapView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddressSelection";
            this.Text = "Address Selection";
            this.Load += new System.EventHandler(this.AddressSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmapView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button button_setAddress;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_getLocFromMap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_longitude;
        private System.Windows.Forms.TextBox textbox_latitude;
        private System.Windows.Forms.Label label1;
    }
}