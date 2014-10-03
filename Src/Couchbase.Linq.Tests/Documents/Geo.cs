﻿using Newtonsoft.Json;

namespace Couchbase.Linq.Tests.Documents
{
    public class Geo
    {
        public string Accuracy { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }

        [JsonProperty("lon")]
        public string Longitude { get; set; }
        /*
         * "geo": {
            "accuracy": "ROOFTOP",
            "lat": 37.7825,
            "lon": -122.393
         * */
    }
}
