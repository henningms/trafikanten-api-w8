using System;
using System.Net;
using System.Windows;

namespace TrafikantenApi.Service.ApiClient
{
    public class Paths
    {
        public static string ApiUrl = "http://api-test.trafikanten.no/";
        
        public class Place
        {
            public static string FindMatches = ApiUrl + "Place/FindMatches/{0}";
            public static string FindMatchesByCounties = ApiUrl + "Place/FindMatchesByCounties/{0}";
            public static string FindPlacesByCounties = ApiUrl + "Place/FindPlacesByCounties/{0}";
            public static string FindMatchesOfType = ApiUrl + "Place/FindMatchesOfType/{0}";
            public static string FindPlaceBasedOnPlaceId = ApiUrl + "Place/FindPlaceBasedOnPlaceId/{0}";
            public static string GetStopsByPlaceId = ApiUrl + "Place/GetStopsByPlaceId/{0}";
            public static string GetClosestStops = ApiUrl + "Place/GetClosestStops/{0}";
            public static string GetClosestStopsByCoordinates = ApiUrl + "Place/GetClosestStopsByCoordinates/{0}";
            public static string GetClosestStopsAdvancedByCoordinates = ApiUrl + "Place/GetClosestStopsAdvancedByCoordinates/{0}";
            public static string GetLines = ApiUrl + "Place/GetLines/{0}";
            public static string Autocomplete = ApiUrl + "Place/Autocomplete/{0}";
        }

        public class Realtime
        {
            public static string FindMatches = ApiUrl + "RealTime/FindMatches/{0}";
            public static string GetRealTimeData = ApiUrl + "RealTime/GetRealTimeData/{0}";
            public static string IsUniquePlace = ApiUrl + "RealTime/IsUniquePlace/{0}";
            public static string IsValidPlace = ApiUrl + "RealTime/IsValidPlace/{0}";
        }

        public class Street
        {
            public static string GetStreets = ApiUrl + "Street/GetStreets/{0}";
        }

        public class Travel
        {
            public static string GetTravelsAfter = ApiUrl + "Travel/GetTravelsAfter?{0}";
            public static string GetTravelsBefore = ApiUrl + "Travel/GetTravelsBefore?{0}";
            public static string GetTravelsAfterByStops = ApiUrl + "Travel/GetTravelsAfterByStops?{0}";
            public static string GetTravelsBeforeByStops = ApiUrl + "Travel/GetTravelsBeforeByStops?{0}";
            public static string GetTravelsAdvanced = ApiUrl + "Travel/GetTravelsAdvanced/?{0}";
            public static string GetTravelsAdvancedByCoordinates = ApiUrl + "Travel/GetTravelsAdvancedByCoordinates/?{0}";
        }

        public class Travelstage
        {
            public static string GetArrivals = ApiUrl + "Travelstage/GetArrivals/{0}";
            public static string GetArrivalsAdvanced = ApiUrl + "Travelstage/GetArrivalsAdvanced/{0}";
            public static string GetDepartures = ApiUrl + "Travelstage/GetDepartures/{0}";
            public static string GetDeparturesAdvanced = ApiUrl + "Travelstage/GetDeparturesAdvanced/{0}";
        }

        public class Trip
        {
            public static string GetTrip = ApiUrl + "Trip/GetTrip/{0}";
        }
    }
}
