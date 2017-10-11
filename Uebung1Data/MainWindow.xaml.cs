using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Uebung1Data
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> PersonData { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //grigri.ItemsSource = "{Binding = PersonData}";
            this.DataContext = this;
            
            //grigri.DataMember = "bClass";
            //grigri.DataBind();

            GenerateDemoData();
        }

        private void GenerateDemoData()
        {

            PersonData = new ObservableCollection<Person>
            {
                new Person("Hubert", "Goisern", 20, new Address("Test", "vienna")),
                new Person("Sepp", "Goisern", 20, new Address("Zwei", "Graz")),
                new Person("Robert", "Goisern", 20, new Address("Strasse", "Innsbruck")),
                new Person("Franz", "Goisern", 20, new Address("StraStra", "vienna")),
                new Person("Max", "Goisern", 20, new Address("TeeTee", "Goisern"))
            };


        }   
    }
}
