using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Resource_Allocation
{
    /// <summary>
    /// Resource_Add.xaml 的交互逻辑
    /// </summary>
    public partial class Resource_Add : Page
    {
        Resource resource = new Resource("", "", "", "");
        public Resource_Add()
        {
            InitializeComponent();
            this.DataContext = resource;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // if first two property is empty, return
            if (resource.First.Trim() == "" || resource.Last.Trim() == "" ||
                resource.Position.Trim() == "" || Regex.IsMatch(resource.YearOfExperience.Trim(), @"^[+]?\d*$") == false)
            {
                MessageBox.Show("Please filled up all the information correctly:)");
                return;
            }

            string message = resource.First.Trim() + "*" + resource.Last.Trim() + "*" + resource.Position.Trim() + "*" + resource.YearOfExperience;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"..\..\..\resourceDB.txt", true))
            {
                file.WriteLine(message);
            }
            MessageBox.Show("Saved successfuly!");

            ResourcePage ResourcePage = new ResourcePage();
            this.NavigationService.Navigate(ResourcePage);
        }
    }
}
