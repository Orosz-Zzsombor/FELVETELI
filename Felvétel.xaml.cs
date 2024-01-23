using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FELVETELI
{
    /// <summary>
    /// Interaction logic for Felvétel.xaml
    /// </summary>
    public partial class Felvétel : Window
    {
        Diak felvetelizoAdatai;
        public Felvétel()
        {
            InitializeComponent();
        }
        public Felvétel(Diak ujdiak) : this()
        {
            this.felvetelizoAdatai = ujdiak;
        }



        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                felvetelizoAdatai.OM_Azonosito = txtAzonosito.Text;
                felvetelizoAdatai.Neve = txtNev.Text;
                felvetelizoAdatai.ErtesitesiCime = txtCim.Text;
                felvetelizoAdatai.Email = txtEmail.Text;
                felvetelizoAdatai.SzuletesiDatum = Convert.ToDateTime(dpSzuletesiIdo.Text);
                felvetelizoAdatai.Matematika = int.Parse(txtMatekPontok.Text);
                felvetelizoAdatai.Magyar = int.Parse(txtMagyarPontok.Text);
                MessageBox.Show("Sikeres Felvétel");
                this.Close() ;

       

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }

        }
        private void txtRemoveWaterMark(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box)
            {

                if (box.Text == "Gipsz Jakab" || box.Text == "example@gmail.com" || box.Text == "Debrecen, Széchenyi u. 58." || box.Text == "62519514862" || box.Text == "2008.10.01" || box.Text == "50")
                {
                    box.Text = null;
                }

            }
        }
    }
}