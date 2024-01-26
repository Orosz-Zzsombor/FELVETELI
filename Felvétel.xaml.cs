using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        public Felvétel(Diak diak, bool modositas = false)
        {
            InitializeComponent();
            txtAzonosito.Text = diak.OM_Azonosito;
            txtNev.Text = diak.Neve;
            txtCim.Text = diak.ErtesitesiCime;
            txtEmail.Text = diak.Email;
            dpSzuletesiIdo.Text = diak.SzuletesiDatum.ToString("yyyy.MM.dd");
            txtMatekPontok.Text = diak.Matematika.ToString();
            txtMagyarPontok.Text = diak.Magyar.ToString();
            felvetelizoAdatai = diak;
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
          
                this.Close() ;

            }
            catch (Exception error)
            {

                HibaKezelo(error);

            }

        }
        private void btnModosit_Click(object sender, RoutedEventArgs e)
        {
            try
            {   
                felvetelizoAdatai.Neve = txtNev.Text;
                felvetelizoAdatai.ErtesitesiCime = txtCim.Text;
                felvetelizoAdatai.Email = txtEmail.Text;
                felvetelizoAdatai.SzuletesiDatum = Convert.ToDateTime(dpSzuletesiIdo.Text);
                felvetelizoAdatai.Matematika = int.Parse(txtMatekPontok.Text);
                felvetelizoAdatai.Magyar = int.Parse(txtMagyarPontok.Text);
                MessageBox.Show("Sikeres módosítás");
                this.Close();
            

            }
            catch (Exception error)
            {
                HibaKezelo(error);
            }
          
        }
 
        private void HibaKezelo(Exception error)
        {
            StringBuilder errorMessages = new StringBuilder("Hoppá!:\n");
            if (error is ArgumentException && error.Message.Contains("Neve"))
            {
                txtNev.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("Név: " + error.Message);
            }
            if (error is ArgumentException && error.Message.Contains("Email"))
            {
                txtEmail.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("Email: " + error.Message);
            }
            if (error is ArgumentException && error.Message.Contains("ErtesitesiCime"))
            {
                txtCim.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("Értesitési cím: " + error.Message);
            }
            if (error is ArgumentException && error.Message.Contains("OM_Azonosito"))
            {
                txtAzonosito.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("OM Azonosító: " + error.Message);
            }
           
            if (error is ArgumentException && error.Message.Contains("SzuletesiDatum")) 
            {
                dpSzuletesiIdo.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("Születési Dátum: " + error.Message);
            }
            if (error is ArgumentException && error.Message.Contains("Magyar"))
            {
                txtMagyarPontok.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("Magyar : " + error.Message);
            }
            if (error is ArgumentException && error.Message.Contains("Matematika"))
            {
                txtMatekPontok.BorderBrush = Brushes.Red;
                errorMessages.AppendLine("Matematika: " + error.Message);
            }
           

            MessageBox.Show(errorMessages.ToString());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#007ACC"));
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DatePicker datePicker)
            {
                if (datePicker.SelectedDate == null)
                {
                    datePicker.BorderBrush = Brushes.Red;
                }
                else
                {
                    datePicker.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#007ACC"));
                }
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