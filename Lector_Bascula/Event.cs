using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace Lector_Bascula
{
    public class Event
    {
        public String name { get; set; }

        public Event()
        {
        }

        public void GET()
        {
            try
            {
                RestClient client = new RestClient("http://rfid_feng");
                RestRequest Request = new RestRequest("bulks/getEvent", Method.GET);
                IRestResponse response = client.Execute(Request);
                name = response.Content;
            }
            catch (Exception exc) { }
        }
    }
}
