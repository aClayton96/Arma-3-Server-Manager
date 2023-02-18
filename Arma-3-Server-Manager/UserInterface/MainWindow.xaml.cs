using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Diagnostics;
using Arma_3_Server_Manager.Logging;
using Arma_3_Server_Manager.Handlers;
using Arma_3_Server_Manager.Classes;
using Arma_3_Server_Manager.Controllers;
using System.Collections.ObjectModel;

namespace Arma_3_Server_Manager.UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Process> serverList
        {
            get { return (ObservableCollection<Process>)GetValue(serverListProperty); }
            set { SetValue(serverListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty serverListProperty =
            DependencyProperty.Register(nameof(serverList), typeof(ObservableCollection<Process>), typeof(MainWindow), new PropertyMetadata(null));


        public ObservableCollection<Mod> modList
        {
            get { return (ObservableCollection<Mod>)GetValue(modListProperty); }
            set { SetValue(modListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty modListProperty =
            DependencyProperty.Register(nameof(modList), typeof(ObservableCollection<Mod>), typeof(MainWindow), new PropertyMetadata(null));

        public ObservableCollection<Mod> activeModList
        {
            get { return (ObservableCollection<Mod>)GetValue(activeModListProperty); }
            set { SetValue(activeModListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for activeModList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty activeModListProperty =
            DependencyProperty.Register(nameof(activeModList), typeof(ObservableCollection<Mod>), typeof(MainWindow), new PropertyMetadata(new ObservableCollection<Mod>()));


        public MainWindow()
        {
            InitializeComponent();

            serverList = new ObservableCollection<Process>();

            var list = ModController.GetAvailableMods();

            modList = new ObservableCollection<Mod>(list);
        }

        private void BtnImportModList_Click(object sender, RoutedEventArgs e)
        {
            //Open a prompt to select a file.

            //Load the HTML / XML file.

            //Get the URLS
        }

        private void BtnStartServer_Click(object sender, RoutedEventArgs e)
        {
            var process = ProcessController.StartServer();

            if (process != null)
            {
                serverList.Add(process);
                ServerStatus.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void BtnStopServer_Click(object sender, RoutedEventArgs e)
        {
            var process = ProcessController.StopServer(serverList[0]);
            if (process.HasExited)
            {
                ServerStatus.Fill = new SolidColorBrush(Colors.Red);
                serverList.Remove(process);
            }
        }

        private void BtnInstallServer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnServerConfig_Click(object sender, RoutedEventArgs e)
        {
            ServerConfigurationWindow configurationWindow = new ServerConfigurationWindow();
            configurationWindow.Show();
        }

        private void btnEnableSelectedMods_Click(object sender, RoutedEventArgs e)
        {
            var enabledMods = modList.Where(m => m.IsActive);

            enabledMods.ToList().ForEach(activeModList.Add);

            enabledMods.ToList().ForEach(f => modList.Remove(f));
        }
    }
}
