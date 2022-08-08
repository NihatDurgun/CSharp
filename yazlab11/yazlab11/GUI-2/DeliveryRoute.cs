using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using GeoCoordinatePortable;
using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace yazlab11.GUI_2
{
    public partial class DeliveryRoute : Form
    {
        string startAddress = "";
        double startlatitude = 0.0;
        double startlongitude = 0.0;
        GMapOverlay markers;
        GMapOverlay polygons = new GMapOverlay("polygons");
        List<Locations> deliveryPoints;
        bool stopThread;

        IFirebaseClient client = new FirebaseClient(credential.config);
        public DeliveryRoute(string startAddress, double startlatitude,double startlongitude)
        {
            this.startAddress = startAddress;
            this.startlatitude = startlatitude;
            this.startlongitude = startlongitude;
            InitializeComponent();
        }

        private void AddToDeliveryPoints(yazlab11.CargoDatas item)
        {
            Locations temp = new Locations();
            temp.IDCargo = item.IDCargo;
            temp.NameCargo = item.NameCargo;
            temp.TypeCargo = item.TypeCargo;
            temp.StatusCargo = item.StatusCargo;
            temp.AddressCargo = item.AddressCargo;
            temp.LatitudeCargo = Double.Parse(item.LatitudeCargo);
            temp.LongitudeCargo = Double.Parse(item.LongitudeCargo);
            PointLatLng first = new PointLatLng(temp.LatitudeCargo, temp.LongitudeCargo);
            PointLatLng second = new PointLatLng(temp.LatitudeCargo, temp.LongitudeCargo);
            temp.BeeDistance = ShortWay_WithAStar.getDistance(first: first, second: second);

            deliveryPoints.Add(temp);
        }

        public void setRoute()
        {
            ShortWay_WithAStar aStar = new ShortWay_WithAStar();

            List<Locations> tempLocations = new List<Locations>();
            Locations tempLocation = new Locations();
            tempLocation.LatitudeCargo = startlatitude;
            tempLocation.LongitudeCargo = startlongitude;
            tempLocations.Add(tempLocation);
            for (int i = 0; i < deliveryPoints.Count; i++)
            {
                tempLocations.Add(deliveryPoints[i]);
            }

            this.BeginInvoke(new MethodInvoker(delegate {

                string foundedRoute = aStar.Find(deliveryPoints: tempLocations).ToString();

                string[] tempStrArray = foundedRoute.ToString().Split(' ');
                int[] resultArray = new int[tempStrArray.Length];
                for (int i = 0; i < tempStrArray.Length; i++)
                {
                    resultArray[i] = Convert.ToInt32(tempStrArray[i].ToString());
                }

                string sonuc = "";
                for (var x = 0; x < resultArray.Length; x++)
                {
                    if (resultArray[x] == 0)
                    {
                        sonuc += "Başlangıç-";
                    }
                    else
                    {
                        if (x != resultArray.Length - 1)
                        {
                            sonuc += tempLocations[resultArray[x]].NameCargo + "-";
                        }
                        else
                        {
                            sonuc += tempLocations[resultArray[x]].NameCargo;
                        }
                    }
                }

                polygons.Clear();
                for (var x = 0; x < resultArray.Length - 1; x++)
                {
                    PointLatLng firstPoint = new PointLatLng(tempLocations[resultArray[x]].LatitudeCargo, tempLocations[resultArray[x]].LongitudeCargo);
                    PointLatLng secondPoint = new PointLatLng(tempLocations[resultArray[x + 1]].LatitudeCargo, tempLocations[resultArray[x + 1]].LongitudeCargo);
                    drawLine(firstPoint: firstPoint, secondPoint: secondPoint, Color.Red);
                }
                label_result.Text = sonuc;
            }));
        }

        public async void getLocations()
        {
            while (true) {
                if (stopThread != true)
                {
                    deliveryPoints = new List<Locations>();
                    FirebaseResponse firebaseResponse = await client.GetTaskAsync("Cargos");
                    List<CargoDatas> listCargoDatas = firebaseResponse.ResultAs<List<CargoDatas>>();

                    var last = listCargoDatas.Last();
                    foreach (var item in listCargoDatas)
                    {
                        if (item != null && item.StatusCargo.Equals("Teslim Edilmedi"))
                        {
                            AddToDeliveryPoints(item);
                        }

                        if (item == last)
                        {
                            addMarkers();
                            setRoute();
                            Thread.Sleep(7500);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void addMarkers()
        {
            if(stopThread != true) { 
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    markers.Clear();

                    GMapMarker startPointMarker =new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(startlatitude, startlongitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
                    startPointMarker.ToolTipText = "\nBaşlangıç Konumu\n\n" + "Adres:" + startAddress + "\nEnlem:" + startlatitude.ToString() + "\nBoylam:" + startlongitude.ToString();
                    markers.Markers.Add(startPointMarker);
                    gmapView.Overlays.Add(markers);

                    foreach (var item in deliveryPoints)
                    {
                        GMap.NET.WindowsForms.GMapMarker marker =new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(item.LatitudeCargo, item.LongitudeCargo),GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
                        marker.ToolTipText = "\nTeslimat Noktası\n\n" + "Kargo ID:" + item.IDCargo + "\nKargo Adı:" + item.NameCargo + "\nKargo Türü:" + item.TypeCargo + "\nKargo Durumu:" + item.StatusCargo + "\nKargo Adresi:" + item.AddressCargo + "\nEnlem:" + startlatitude.ToString() + "\nBoylam:" + startlongitude.ToString() + "\nB.N'ye olan Uzaklık:" + item.BeeDistance + " KM";
                        markers.Markers.Add(marker);
                        gmapView.Overlays.Add(markers);
                    }
                }));
            }
        }

        private void button_changeStartPoint_Click(object sender, EventArgs e)
        {
            stopThread = true;
            if (MessageBox.Show("Please Select Start Point!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                AddressSelection startPoint = new AddressSelection();
                startPoint.Show();
            }
            this.Close();
        }

        private void DeliveryRoute_Load(object sender, EventArgs e)
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

            markers = new GMapOverlay("markers");

            Thread thread = new Thread(new ThreadStart(getLocations));
            thread.Start();
        }

        public void drawLine(PointLatLng firstPoint, PointLatLng secondPoint, Color lineColor)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(firstPoint);
            points.Add(secondPoint);
            GMapPolygon polygon = new GMapPolygon(points, "polygon");
            polygon.Stroke = new Pen(lineColor, 3);
            polygons.Polygons.Add(polygon);
            gmapView.Overlays.Add(polygons);
        }

        private void button_centerToMarkers_Click(object sender, EventArgs e)
        {
            gmapView.ZoomAndCenterMarkers("markers");
        }
    }
}
