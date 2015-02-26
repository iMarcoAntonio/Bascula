using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Lector_Bascula
{
    public class Bulk
    {
        public String name;
        public String created_at;
        public String updated_at;

        public string upc { get; set; }
        public String epc { get; set; }
        public Double kg { get; set; }
        public int inventory { get; set; }

        internal String inventoryPOST()
        {
            try
            {
                RestClient cliente = new RestClient("http://rfid_feng");
                RestRequest request = new RestRequest("bulk", Method.POST);

                this.created_at = DateTime.Now.ToString();
                this.updated_at = DateTime.Now.ToString();

                String json = JsonConvert.SerializeObject(this);
                request.AddJsonBody(this);
                IRestResponse response = cliente.Execute(request);
                return response.Content;
            }
            catch (Exception exc) { 
                MessageBox.Show(exc.Message);
                return "Imposible hacer inventario";
            }
        }

        internal String registerWeightPOST()
        {
            try
            {
                RestClient cliente = new RestClient("http://rfid_feng");
                RestRequest request = new RestRequest("register_weight", Method.POST);

                this.created_at = DateTime.Now.ToString();
                this.updated_at = DateTime.Now.ToString();

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
