using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using yazlab11.GUI_2;

namespace yazlab11
{
    public partial class AddressSelection : Form
    {
        CargosStatus cargoStatus;
        DeliveryRoute deliveryRoute;
        GMapOverlay markersOverlay;
        public AddressSelection(CargosStatus cargoStatus= null)
        {
            if (cargoStatus != null)
            {
                this.cargoStatus = cargoStatus;
            }
            InitializeComponent();
        }

        private void hkn_btn_Click(object sender, EventArgs e)
        {
            textbox_latitude.Text = gmapView.Position.Lat.ToString();
            textbox_longitude.Text = gmapView.Position.Lng.ToString();
        }

        private void AddressSelection_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            gmapView.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;                  

            gmapView.ShowCenter = true;
            gmapView.MinZoom = 0;                                                                            
            gmapView.MaxZoom = 20;
            gmapView.Zoom = 1;
            gmapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;               
            gmapView.CanDragMap = true;                                                                         
            gmapView.DragButton = MouseButtons.Left;                                                       
            gmapView.IgnoreMarkerOnMouseWheel = true;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            markersOverlay = new GMapOverlay("markers");
            gmapView.SetPositionByKeywords((address_textbox.Text).ToLower().ToString());
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(gmapView.Position.Lat, gmapView.Position.Lng), GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmapView.Overlays.Add(markersOverlay);
            gmapView.ZoomAndCenterMarkers("markers");
            textbox_latitude.Text = gmapView.Position.Lat.ToString();
            textbox_longitude.Text = gmapView.Position.Lng.ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            address_textbox.Text = "";
            textbox_latitude.Text = "";
            textbox_longitude.Text = "";
            markersOverlay.Clear();
        }

        private void button_setAddress_Click(object sender, EventArgs e)
        {
            if (cargoStatus != null)
            {
                this.cargoStatus.UpdateAddress(address: address_textbox.Text.ToString(), latitude: textbox_latitude.Text.ToString(), longitude: textbox_longitude.Text.ToString());
            }
            else
            {
                deliveryRoute = new DeliveryRoute(startAddress: address_textbox.Text.ToString(), startlatitude: Double.Parse(textbox_latitude.Text.ToString()), startlongitude: Double.Parse(textbox_longitude.Text.ToString()));
                deliveryRoute.Show();
            }
            this.Close();
        }
    }
}
