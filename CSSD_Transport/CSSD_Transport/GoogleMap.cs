using CSSD_Transport.Journeys;
using CSSD_Transport.UI.Travel_UI;
using CSSD_Transport.Util;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD_Transport
{
    public class GoogleMap
    {
        private frmRailTravelSim form;

        private PointLatLng currentLocation;
        private PointLatLng destinationLocation;

        private GMapMarker endMarker;
        private GMapMarker startMarker;

        private GMapOverlay markerOverlay = new GMapOverlay("markers");
        private GMapOverlay routeOverlay = new GMapOverlay("routes");

        private GMapRoute r;

        public PointLatLng getCurrentLocation() => currentLocation;
        public PointLatLng getDestinationLocation() => destinationLocation;

        public GoogleMap(string currentStation, frmRailTravelSim form)
        {
            currentLocation = findLocation(currentStation);
            this.form = form;
            setUpMapProperties();  
        }
        
        public void updateLocation(string updatedLocation)
        {
            r.Clear();
            markerOverlay.Clear();
            routeOverlay.Clear();
            form.map.Overlays.Clear();
            form.lblDistance.Text = "";
            currentLocation = findLocation(updatedLocation);
            draw();
        }

        private void draw()
        {
            setUpMapProperties();
            form.map.Overlays.Add(markerOverlay);
            markerOverlay.Markers.Add(startMarker);
        }

        public void updateDestination(string updatedDestination)
        {
            if (r != null) { r.Clear(); }
            destinationLocation = findLocation(updatedDestination);
            endMarker.Position = destinationLocation;

            MapRoute route = GoogleMapProvider.Instance.GetRoute(currentLocation, destinationLocation, false, false, 15);
            r = new GMapRoute(route.Points, "Your journey");
            
            r.Stroke.Width = 2;
            r.Stroke.Color = Color.Red;

            form.lblDistance.Text = "Distance: " + r.Distance.ToString() + "km";
            
            routeOverlay.Routes.Add(r);
            markerOverlay.Markers.Add(endMarker);

            form.map.Overlays.Add(markerOverlay);
            form.map.Overlays.Add(routeOverlay);
            form.map.ZoomAndCenterRoute(r);
        }

        private PointLatLng findLocation(string station)
        {
            Location loc = RailMap.Instance.getLocation(station);
            double longitude = loc.getLongitude();
            double latitude = loc.getLatitude();

            return new PointLatLng(latitude, longitude);
        }

        private void setUpMapProperties()
        {
            // Appearance
            form.map.MinZoom = 1;
            form.map.MaxZoom = 100;
            form.map.Zoom = 15;
            form.map.DragButton = MouseButtons.Left;
            form.map.ShowCenter = false;
            form.map.Position = currentLocation;
            form.map.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            startMarker = new GMarkerGoogle(currentLocation, GMarkerGoogleType.green_pushpin);
            startMarker.ToolTip = new GMapToolTip(startMarker);
            startMarker.ToolTip.Fill = Brushes.SkyBlue;
            startMarker.ToolTip.Foreground = Brushes.SlateGray;
            startMarker.ToolTip.TextPadding = new Size(20, 20);
            startMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            startMarker.ToolTipText = "You are here!";

            endMarker = new GMarkerGoogle(new PointLatLng(0.0, 0.0), GMarkerGoogleType.purple_pushpin);
            endMarker.ToolTip = new GMapToolTip(endMarker);
            endMarker.ToolTip.Fill = Brushes.SkyBlue;
            endMarker.ToolTip.Foreground = Brushes.SlateGray;
            endMarker.ToolTip.TextPadding = new Size(20, 20);
            endMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            endMarker.ToolTipText = "You will arrive here!";

            markerOverlay.Markers.Add(startMarker);
            form.map.Overlays.Add(markerOverlay);
        }
    }
}
