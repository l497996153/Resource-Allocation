using System;
using System.Windows;
using System.Windows.Controls;

namespace Resource_Allocation
{
    /// <summary>
    /// Interaction logic for ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            DataBase db = new DataBase(@"..\..\..\clientDB.txt");
            // send data to dataGrid
            ClientGrid.ItemsSource = db.GetClient();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Client_Add Client_Add = new Client_Add();
            this.NavigationService.Navigate(Client_Add);
        }

        public static DataGridRow GetSelectedRow(DataGrid grid)
        {
            return (DataGridRow)grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            // get the location
            DataGridRow dataGridRow = GetSelectedRow(ClientGrid);
            string data = "";
            if (dataGridRow.Item is Client)
            {
                Client dataItem = dataGridRow.Item as Client;
                data = dataItem.CompanyName.Trim() + "*" + dataItem.First.Trim() + "*" + dataItem.Last.Trim() + "*" + dataItem.City.Trim() + "*" + dataItem.State.Trim() + "*" + dataItem.Zip.Trim();
            }
            int loc = dataGridRow.GetIndex();
            // get the database
            DataBase db = new DataBase(@"..\..\..\clientDB.txt");
            var rst = db.UpdatedData(loc, data);
            // re-print the file
            System.IO.File.WriteAllLines(db.FilePath, (String[])rst.ToArray(typeof(string)));
            // refresh the database
            db.LoadDB();
            ClientGrid.ItemsSource = db.GetClient();
            string message = "row " + (loc + 1) + " updated!!";
            MessageBox.Show(message);

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // get the location
            int loc = GetSelectedRow(ClientGrid).GetIndex();
            // get the database
            DataBase db = new DataBase(@"..\..\..\clientDB.txt");
            var rst = db.DeleteData(loc);
            // re-print the file
            System.IO.File.WriteAllLines(db.FilePath, (String[])rst.ToArray(typeof(string)));
            // refresh the database
            db.LoadDB();
            ClientGrid.ItemsSource = db.GetClient();

            string message = "Delete successfully!!";
            MessageBox.Show(message);
        }
    }
}
