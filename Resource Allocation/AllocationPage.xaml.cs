using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Resource_Allocation
{
    /// <summary>
    /// Interaction logic for AllocationPage.xaml
    /// </summary>
    public partial class AllocationPage : Page
    {
        public AllocationPage()
        {
            InitializeComponent();
            string FilePath = @"..\..\..\clientDB.txt";
            // if DB doesn't created, create the file
            if (!System.IO.File.Exists(FilePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(FilePath)) ;
            }
            string[] Lines = System.IO.File.ReadAllLines(FilePath);
            List<DropList> list = new List<DropList>();
            int count = 0;
            foreach (string line in Lines)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split('*');
                if (words.Length == 6)
                {
                    list.Add(new DropList(words[0], count));
                }
                count++;
            }
            client_list.ItemsSource = list;
            Load();
        }

        private void Load()
        {
            string FilePath = @"..\..\..\resourceDB.txt";
            // if DB doesn't created, create the file
            if (!System.IO.File.Exists(FilePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(FilePath)) ;
            }
            string[] Lines = System.IO.File.ReadAllLines(FilePath);
            List<string> list1 = new List<string>();
            foreach (string line in Lines)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split('*');
                if (words.Length == 4)
                {
                    list1.Add(words[0] + " " + words[1]);
                }
            }

            FilePath = @"..\..\..\allocationDB.txt";
            // if DB doesn't created, create the file
            if (!System.IO.File.Exists(FilePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(FilePath)) ;
            }
            Lines = System.IO.File.ReadAllLines(FilePath);
            foreach (string line in Lines)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split('*');
                if (words.Length == 3)
                {
                    list1.Remove(words[1] + " " + words[2]);
                }
            }
            List<Resource> resourceList = new List<Resource>();
            foreach (string line in list1)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split(' ');
                resourceList.Add(new Resource(words[0], words[1]));
            }

            // send data to dataGrid
            unsignedResourceGrid.ItemsSource = resourceList;
        }

        private void client_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DropList dataItem = client_list.SelectedItem as DropList;
            string name = "";
            if (dataItem == null)
            {
                name = client_list.Text;
            }
            else
            {
                name = dataItem.Name;
            }
            Flash(name);
        }

        public static DataGridRow GetSelectedRow(DataGrid grid)
        {
            return (DataGridRow)grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem);
        }

        private void Flash(string name)
        {
            string FilePath = @"..\..\..\allocationDB.txt";
            // if DB doesn't created, create the file
            if (!System.IO.File.Exists(FilePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(FilePath)) ;
            }
            string[] Lines = System.IO.File.ReadAllLines(FilePath);
            List<Resource> list = new List<Resource>();
            int count = 0;
            foreach (string line in Lines)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split('*');
                if (words[0] == name)
                {
                    list.Add(new Resource(words[1], words[2]));
                }
                count++;
            }
            signedResourceGrid.ItemsSource = list;
        }
        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            string client = client_list.Text;
            if (client == "")
            {
                MessageBox.Show("Please select an client first");
                return;
            }
            DataGridRow dataGridRow = GetSelectedRow(unsignedResourceGrid);
            Resource resourceItem = dataGridRow.Item as Resource;
            string resource = resourceItem.First + "*" + resourceItem.Last;
            string message = client + "*" + resource;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"..\..\..\allocationDB.txt", true))
            {
                file.WriteLine(message);
            }
            MessageBox.Show("Signed successfuly!");
            Flash(client_list.Text);
            Load();
        }

        private void Unsign_Click(object sender, RoutedEventArgs e)
        {
            string client = client_list.Text;
            DataGridRow dataGridRow = GetSelectedRow(signedResourceGrid);
            Resource resourceItem = dataGridRow.Item as Resource;
            string resource = resourceItem.First + "*" + resourceItem.Last;
            string message = client + "*" + resource;
            List<string> quotelist = System.IO.File.ReadAllLines(@"..\..\..\allocationDB.txt").ToList();
            quotelist.Remove(message);
            System.IO.File.WriteAllLines(@"..\..\..\allocationDB.txt", quotelist.ToArray());
            MessageBox.Show("Unsigned successfuly!");
            Flash(client_list.Text);
            Load();
        }
    }
}
