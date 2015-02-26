using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Lector_Bascula
{
    public class Weight_Bottle
    {
        public string upc { get; set; }
        public string epc { get; set; }
        public Double kg { get; set; }

        internal String POST()
        {
            try
            {
                RestClient cliente = new RestClient("http://rfid_feng");
                RestRequest request = new RestRequest("register_weight", Method.POST);

                String json = JsonConvert.SerializeObject(this);
                request.AddJsonBody(this);
                IRestResponse response = cliente.Execute(request);
                return response.Content;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return "Imposible hacer inventario";
            }
        }
    }
}
