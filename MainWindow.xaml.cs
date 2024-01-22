using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.IO;
using System.Collections.ObjectModel;
namespace FELVETELI
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




        private static readonly Regex _regex = new Regex("[^0-9.-]+"); 

        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnFelvetel_Click(object sender, RoutedEventArgs e) 
        { 


            var windowB = new Felvétel();
            windowB.ShowDialog();
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dtgFelveteli.SelectedItem as Diak; if (selectedItem != null) { (dtgFelveteli.ItemsSource as ObservableCollection<Diak>).Remove(selectedItem); }
        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            List<Diak> Diak = new List<Diak>();
            File.ReadAllLines("diakNincs.csv").Skip(1).ToList().ForEach(x => Diak.Add(new Diak(x)));
            if (dtgFelveteli.Items.Count>0)
            {
                if (MessageBox.Show("Diákok felülírása?",
                "Megerősítés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {

                    dtgFelveteli.ItemsSource = Diak;
                    MessageBox.Show("Sikeres importálás");
                }
                else
                {
                   
    
                 }
            }
            else
            {
                dtgFelveteli.ItemsSource = Diak;
            }



        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("DiakUj.csv");
        }
    }
}
