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
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Win32;
namespace FELVETELI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<IFelvetelizo> felveteli = new ObservableCollection<IFelvetelizo>();
        public MainWindow()
        {
            InitializeComponent();
            dtgFelveteli.ItemsSource = felveteli;


        }




 



        private void btnFelvetel_Click(object sender, RoutedEventArgs e) 
        {

            Diak ujdiak = new Diak();
            Felvétel ujablak = new Felvétel(ujdiak);
            ujablak.ShowDialog();
            if (ujdiak.Neve != null)
            {
                felveteli.Add(ujdiak);
            }
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {

          

            IEditableCollectionView items = dtgFelveteli.Items; 
            List<Diak> Torolni = new List<Diak>();
            foreach (var item in dtgFelveteli.SelectedItems) 
                {
                Torolni.Add((Diak)item);
                }

            foreach (Diak item in Torolni)
            {
                if (items.CanRemove)
                {
                    items.Remove(dtgFelveteli.SelectedItem);
                }
            }
            dtgFelveteli.ItemsSource = felveteli;


            
            
        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            if (dtgFelveteli.Items.Count > 0)
            {
                if (MessageBox.Show("Diákok felülírása?", "Megerősítés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    felveteli.Clear();

                }
              
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv fajl (*.csv)|*.csv";
            if (ofd.ShowDialog() == true)
            {
                foreach (String fajl in File.ReadAllLines(ofd.FileName).Skip(1))
                {
                    felveteli.Add(new Diak(fajl));
                }
            }

        }




        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("DiakUj.csv",false);
            foreach (Diak item in dtgFelveteli.Items)
            {
                sw.WriteLine(item.CSVSortAdVissza());
            }
            sw.Close();
        }
    }
}
