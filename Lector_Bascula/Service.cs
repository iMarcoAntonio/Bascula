using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace Lector_Bascula
{
    public class Service
    {
        public string[] epcs { get; set; }
        public string a { get; set; }

        public Service()
        {
        }

        public Service(string[] epcs)
        {
            // TODO: Complete member initialization
            this.epcs = epcs;
        }

        internal string realizePost()
        {
            try
            {
                RestClient cliente = new RestClient("http://rfid_feng");
                RestRequest request = new RestRequest("notification", Method.POST);

                String json = JsonConvert.SerializeObject(this);
                request.AddJsonBody(this);
                IRestResponse response = cliente.Execute(request);
                return response.Content;
            }
            catch (Exception exc)
            {
                return "Imposible hacer inventario";
            }
        }
    }
}
