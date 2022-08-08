using GeoCoordinatePortable;
using GMap.NET;
using System.Collections.Generic;

namespace yazlab11
{
    class ShortWay_WithAStar
    {
        public string Find(List<Locations> deliveryPoints)
        {
            int[,] beeline_matrix = new int[deliveryPoints.Count, deliveryPoints.Count];
            int[,] temp_beeline_temp = new int[deliveryPoints.Count, deliveryPoints.Count];
            for (int x = 0; x < deliveryPoints.Count; x++)
            {
                for (int y = 0; y < deliveryPoints.Count; y++)
                {
                    if (x == y)
                    {
                        beeline_matrix[x, y] = 0;
                    }
                    else
                    {

                        PointLatLng first = new PointLatLng(deliveryPoints[x].LatitudeCargo, deliveryPoints[x].LongitudeCargo);
                        PointLatLng second = new PointLatLng(deliveryPoints[y].LatitudeCargo, deliveryPoints[y].LongitudeCargo);
                        beeline_matrix[x, y] = getDistance(first, second);
                    }
                }
            }

            temp_beeline_temp = beeline_matrix;

            string shortest_distance = "";
            int shortest_path = 999999999;
            int most_far_node = 0;
            int longest_distance = 0;
            int count = 1;
            int temp2 = 0;

            for (int temp_most_far_node = 1; temp_most_far_node < deliveryPoints.Count - 1; temp_most_far_node++)
            {
                beeline_matrix = temp_beeline_temp;
                count = 1;
                int sum = 0;
                int temp = -1;

                string temp_shortest_distance = "";

                while (count != deliveryPoints.Count)
                {
                    int first_node = 0;
                    int first_togo_node = -1;
                    int first_node_distance = 999999999;

                    for (int i = 0; i < deliveryPoints.Count; i++)
                    {
                        if (beeline_matrix[first_node, i] + beeline_matrix[i, temp_most_far_node] < first_node_distance
                           && i != first_node && i != temp_most_far_node)
                        {
                            first_togo_node = i;
                            first_node_distance = beeline_matrix[first_node, i] + beeline_matrix[i, temp_most_far_node];
                            temp2 = beeline_matrix[first_node, i];
                        }
                    }
                    temp_shortest_distance += " " + first_togo_node;
                    sum += temp2;
                    beeline_matrix[first_node, first_togo_node] = 99999999;
                    beeline_matrix[first_togo_node, temp_most_far_node] = 99999999;
                    count++;
                    temp = first_togo_node;
                    if (count == deliveryPoints.Count - 1)
                    {
                        if (sum < shortest_path)
                        {
                            shortest_path = sum;
                            shortest_distance = temp_shortest_distance;
                            most_far_node = temp_most_far_node;
                        }
                    }
                }

            }

            return "0" + shortest_distance + " " + most_far_node.ToString();
        }

        public static int getDistance(PointLatLng first, PointLatLng second)
        {
            GeoCoordinate startedNode = new GeoCoordinate(first.Lat, first.Lng);

            GeoCoordinate deliveryPoints = new GeoCoordinate(second.Lat, second.Lng);

            return (int)(startedNode.GetDistanceTo(deliveryPoints));
        }
    }
}