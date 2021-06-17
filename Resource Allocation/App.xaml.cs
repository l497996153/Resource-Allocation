using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace Resource_Allocation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }

    public class Client
    {
        public string CompanyName { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Client(string CompanyName, string First, string Last, string City, string State, string Zip)
        {
            this.CompanyName = CompanyName;
            this.First = First;
            this.Last = Last;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
        }
    }
    public class Resource
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Position { get; set; }
        public string YearOfExperience { get; set; }

        public Resource(string First, string Last)
        {
            this.First = First;
            this.Last = Last;
            this.Position = "";
            this.YearOfExperience = "";
        }

        public Resource(string First, string Last, string Position, string YearOfExperience)
        {
            this.First = First;
            this.Last = Last;
            this.Position = Position;
            this.YearOfExperience = YearOfExperience;
        }
    }

    public class DropList
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public DropList(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
    }

    public class DataBase
    {
        public string FilePath { get; set; }
        public string[] Lines { get; set; }

        public DataBase(string FilePath)
        {
            this.FilePath = FilePath;
            // if DB doesn't created, create the file
            if (!System.IO.File.Exists(this.FilePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(this.FilePath)) ;
            }
            this.Lines = System.IO.File.ReadAllLines(this.FilePath);
        }

        public void LoadDB()
        {
            this.Lines = System.IO.File.ReadAllLines(this.FilePath);
        }
        public List<Client> GetClient()
        {
            var items = new List<Client>();

            foreach (string line in this.Lines)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split('*');
                if (words.Length == 6)
                {
                    items.Add(new Client(words[0], words[1], words[2], words[3], words[4], words[5]));
                }
            }
            return items;
        }



        public List<Resource> GetResource()
        {
            var items = new List<Resource>();

            foreach (string line in this.Lines)
            {
                string trimedLine = line.Trim();
                string[] words = trimedLine.Split('*');
                if (words.Length == 4)
                {
                    items.Add(new Resource(words[0], words[1], words[2], words[3]));
                }
            }
            return items;
        }

        public ArrayList UpdatedData(int index, string data)
        {
            ArrayList rst = new ArrayList();

            int count = 0;
            // only take Lines wtihout target line
            foreach (string line in this.Lines)
            {
                if (count != index)
                {
                    rst.Add(line);
                }
                else
                {
                    rst.Add(data);
                }
                count++;
            }
            return rst;
        }

        public ArrayList DeleteData(int index)
        {
            ArrayList rst = new ArrayList();

            int count = 0;
            // only take Lines wtihout target line
            foreach (string line in this.Lines)
            {
                if (count != index)
                {
                    rst.Add(line);
                }
                count++;
            }
            return rst;
        }
    }
}