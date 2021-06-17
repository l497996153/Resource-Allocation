using System.Windows;
using System.Windows.Controls;

namespace Resource_Allocation
{
    /// <summary>
    /// Interaction logic for Client_Add.xaml
    /// </summary>
    public partial class Client_Add : Page
    {
        Client client = new Client(" ", " ", " ", " ", " ", " ");
        public Client_Add()
        {
            InitializeComponent();
            this.DataContext = client;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // if first two property is empty, return
            if (client.CompanyName.Trim() == "" || client.First.Trim() == "" ||
                client.Last.Trim() == "" || client.City.Trim() == "" ||
                client.State.Trim() == "" || client.Zip.Trim() == "")
            {
                MessageBox.Show("Please filled up all the information:)");
                return;
            }

            string message = client.CompanyName.Trim() + "*" + client.First.Trim() + "*" + client.Last.Trim() + "*" + client.City.Trim() + "*" + client.State.Trim() + "*" + client.Zip.Trim();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"..\..\..\clientDB.txt", true))
            {
                file.WriteLine(message);
            }
            MessageBox.Show("Saved successfuly!");

            ClientPage ClientPage = new ClientPage();
            this.NavigationService.Navigate(ClientPage);
        }
    }
}
