using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Server_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelV ModelViewer = new ModelV();

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_ServerStart_Click(object sender, RoutedEventArgs e)
        {
            var response = ModelViewer.StartServer(TextBox_ServerId.Text);
            MessageBox.Show(response);
            if (response == "Сервер запущен")
            {
                TextBox_Server.Text = response;
                var directoryInfo = new DirectoryInfo("C:\\Users\\drago\\Server");

                // очистка списка
                DirList.Items.Clear();

                // добавление записей в список
                foreach (var fileInfo in directoryInfo.GetFiles())
                {
                    DirList.Items.Add(fileInfo.Name);
                }


                Button_Connect.IsEnabled = true;
                Button_Disconnect.IsEnabled = false;
                
            }

        }
        private void Button_Disconnect_Click(object sender, RoutedEventArgs e)
        {
            var response = ModelViewer.ClientDisconnect();
            TextBox_Server.Text = "Клиент отключен";
            TextBox_Client.Text = "Клиент отключен от сервера";
            Button_Connect.IsEnabled = true;
            Button_SendServer.IsEnabled = false;
            Button_Disconnect.IsEnabled = false;
        }

        private void Button_Connect_Click(object sender, RoutedEventArgs e)
        {
            var response = ModelViewer.ClientConnect(TextBox_ServerId.Text, 8888);
            TextBox_Client.Text = response;
            if (response == "C:\\,D:\\")
            {
                string[] str = response.Split(",");
                foreach (string str2 in str)
                    Device_Box.Items.Add(str2);
                TextBox_Client.Text = "Соединение с сервером установлено";
                TextBox_Server.Text = "Клиент подключен";
                Button_Connect.IsEnabled = false;
                Button_Disconnect.IsEnabled= true;          
                Button_SendServer.IsEnabled = true;
            }
        }
        private void Button_SendServer_Click(object sender, RoutedEventArgs e)
        {
           string response;
            if (DirList.SelectedItem == null)
                response = ModelViewer.ClientGet($"{Device_Box.SelectedItem}{DirList.SelectedItem}");
            else
                response = ModelViewer.ClientGet($"{DirList.SelectedItem}");
           TextBox_Client.Text = response;

            DirList.Items.Clear();  
            string[] directories = response.Split(",");
            foreach (string directories2 in directories)
            {
                DirList.Items.Add(directories2);
            }         
        }
     
    }
}
