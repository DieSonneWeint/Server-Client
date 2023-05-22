using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Controls;

namespace Server_Client
{
    internal class Model
    {
        TcpClient client ;
        TcpListener listener;
        public string ClientConnect(string id , int port)
        { 
           client = new TcpClient(id, port); 
           string Devise = ReceiveData(client);

           return Devise;
        }
        public void ClientDisconnect()
        {
            SendData(client, "disconnect");
            client.Close();
        }      
         public void ServerSend(string path)
        {
            SendData(client, path);
        }
         public string ClientGet()
        {
            byte[] data = new byte[256]; // Буфер для принимаемых данных.
            StringBuilder builder = new StringBuilder(); // Буфер для сбора принятых данных в строку.

            int bytes = 0;
            NetworkStream stream = client.GetStream(); // Получение потока данных из клиента.
            do
            {
                bytes = stream.Read(data, 0, data.Length); // Чтение данных из потока.
                builder.Append(Encoding.UTF8.GetString(data, 0, bytes)); // Добавление считанных данных к строке.
            }
            while (stream.DataAvailable); // Проверка наличия данных в потоке.

            return builder.ToString();
        }
    
    static void SendData(TcpClient clientSocket, string data)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(data + "\n");
        NetworkStream stream = clientSocket.GetStream();
        stream.Write(buffer, 0, buffer.Length);
        stream.Flush();
    }

    static string ReceiveData(TcpClient clientSocket)
    {
        byte[] buffer = new byte[1024];
        NetworkStream stream = clientSocket.GetStream();
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        return Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
    }
    }
}
