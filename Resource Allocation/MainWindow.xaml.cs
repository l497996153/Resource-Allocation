using System;
using System.Windows;
using System.Windows.Navigation;

namespace Resource_Allocation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Client_Click(object sender, RoutedEventArgs e)
        {
            // go to the client page
            ClientPage ClientPage = new ClientPage();
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("ClientPage.xaml", UriKind.Relative);
            window.Show();
        }

        private void Resource_Click(object sender, RoutedEventArgs e)
        {
            // go to the client page
            ResourcePage ResourcePage = new ResourcePage();
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("ResourcePage.xaml", UriKind.Relative);
            window.Show();
        }

        private void Allocation_Click(object sender, RoutedEventArgs e)
        {
            // go to the client page
            AllocationPage ResourcePage = new AllocationPage();
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("AllocationPage.xaml", UriKind.Relative);
            window.Show();
        }
    }
}
