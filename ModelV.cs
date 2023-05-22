using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Server_Client
{
  
    internal class ModelV
    {
      Model model = new Model(); 
        public string ClientDisconnect()
        {
            try
            {
                model.ClientDisconnect();
            }
            catch(Exception e)
            {
                return e.Message;
            }
            return "Клиент отключен";
        }

        public string ClientConnect(string host, int port)
        {
            string response;
            try
            {
              response = model.ClientConnect(host, port);
            }
            catch (Exception e) 
            {
                return e.Message;
            }
            return response;
        }
        public string ClientGet(string path)
        {
            string response;
            try
            {
                model.ServerSend(path);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            try
            {
               response = model.ClientGet();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return response;
        }
      
    }
}
