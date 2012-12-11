using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace FacebookIdGrabber.Models
{
    public class Generator
    {
        public RootObject returnObject;
        public string id { get; set; }


        public Generator(string username)
        {
            var web = new WebClient();
            try
            {
                var json = web.DownloadString(string.Format("https://graph.facebook.com/{0}", username));
                returnObject = JsonConvert.DeserializeObject<RootObject>(json);
                id = returnObject.id;
            }
            catch
            {}
        }
        
    }
    public class Location
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Parking
    {
        public int street { get; set; }
        public int lot { get; set; }
        public int valet { get; set; }
    }

    public class RootObject
    {
        public string about { get; set; }
        public int checkins { get; set; }
        public string description { get; set; }
        public string founded { get; set; }
        public bool is_published { get; set; }
        public Location location { get; set; }
        public Parking parking { get; set; }
        public string phone { get; set; }
        public int talking_about_count { get; set; }
        public string username { get; set; }
        public string website { get; set; }
        public int were_here_count { get; set; }
        public string category { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public int likes { get; set; }
    }
}