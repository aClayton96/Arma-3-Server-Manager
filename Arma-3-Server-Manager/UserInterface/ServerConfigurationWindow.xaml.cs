using Arma_3_Server_Manager.Controllers;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Arma_3_Server_Manager.UserInterface
{
    /// <summary>
    /// Interaction logic for ServerConfigurationWindow.xaml
    /// </summary>
    public partial class ServerConfigurationWindow : Window
    {
        public ServerConfigurationWindow()
        {
            InitializeComponent();

            Dictionary<string, string> configurationValues = ConfigController.LoadConfig();

            TxtBxServerName.Text = configurationValues.FirstOrDefault(t => t.Key == "hostname").Value;

            TxtBxServerPort.Text = configurationValues.FirstOrDefault(t => t.Key == "port").Value;

            TxtBxServerPassword.Text = configurationValues.FirstOrDefault(t => t.Key == "password").Value;

            TxtBxServerAdminPassword.Text = configurationValues.FirstOrDefault(t => t.Key == "adminPass").Value;
        }

        private void BtnSaveConfig_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> configurationValues = new Dictionary<string, string>();

            configurationValues.Add("hostname", TxtBxServerName.Text);
            configurationValues.Add("port", TxtBxServerPort.Text);
            configurationValues.Add("password", TxtBxServerPassword.Text);
            configurationValues.Add("adminPass", TxtBxServerAdminPassword.Text);

            if(ConfigController.SaveConfig(configurationValues))
            {
                this.Close();
            }
        }
    }
}
