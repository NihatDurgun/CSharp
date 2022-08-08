
namespace yazlab11.GUI_2
{
    partial class DeliveryRoute
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
            this.button_changeStartPoint = new System.Windows.Forms.Button();
            this.button_centerToMarkers = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gmapView.Location = new System.Drawing.Point(12, 12);
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
            this.gmapView.Size = new System.Drawing.Size(763, 480);
            this.gmapView.TabIndex = 0;
            this.gmapView.Zoom = 0D;
            // 
            // button_changeStartPoint
            // 
            this.button_changeStartPoint.Location = new System.Drawing.Point(6, 250);
            this.button_changeStartPoint.Name = "button_changeStartPoint";
            this.button_changeStartPoint.Size = new System.Drawing.Size(153, 218);
            this.button_changeStartPoint.TabIndex = 6;
            this.button_changeStartPoint.Text = "Change Start Point";
            this.button_changeStartPoint.UseVisualStyleBackColor = true;
            this.button_changeStartPoint.Click += new System.EventHandler(this.button_changeStartPoint_Click);
            // 
            // button_centerToMarkers
            // 
            this.button_centerToMarkers.Location = new System.Drawing.Point(6, 22);
            this.button_centerToMarkers.Name = "button_centerToMarkers";
            this.button_centerToMarkers.Size = new System.Drawing.Size(153, 208);
            this.button_centerToMarkers.TabIndex = 5;
            this.button_centerToMarkers.Text = "Center To Markers";
            this.button_centerToMarkers.UseVisualStyleBackColor = true;
            this.button_centerToMarkers.Click += new System.EventHandler(this.button_centerToMarkers_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(13, 23);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 15);
            this.label_result.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_centerToMarkers);
            this.groupBox1.Controls.Add(this.button_changeStartPoint);
            this.groupBox1.Location = new System.Drawing.Point(781, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 480);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_result);
            this.groupBox2.Location = new System.Drawing.Point(12, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 55);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Founded Short Way:";
            // 
            // DeliveryRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gmapView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeliveryRoute";
            this.Text = "Delivery Route";
            this.Load += new System.EventHandler(this.DeliveryRoute_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmapView;
        private System.Windows.Forms.Button button_changeStartPoint;
        private System.Windows.Forms.Button button_centerToMarkers;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}