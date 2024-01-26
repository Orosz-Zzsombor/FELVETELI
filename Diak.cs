using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FELVETELI
{
    public class Diak : IFelvetelizo
    {

        private string omAzonosito;
        private string neve;
        private string ertesitesiCime;
        private string email;
        private DateTime szuletesiDatum;
        private int matematika;
        private int magyar;

        public Diak(string csvString)
        {
            try
            {
                string[] adatok = csvString.Split(';');
                omAzonosito = adatok[0];
                neve = adatok[1];
                ertesitesiCime = adatok[2];
                email = adatok[3];
                szuletesiDatum = DateTime.Parse(adatok[4]);
                matematika = adatok[5] == "NULL" ? matematika = -1 : matematika = int.Parse(adatok[5]);
                magyar = adatok[6] == "NULL" ? magyar = -1 : magyar = int.Parse(adatok[6]);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Érvénytelen adatformátum a CSV sorban.");
            }
        }
        
             public Diak() { }


            public Diak(string omAzonosito, string neve, string ertesitesiCime, string email, DateTime szuletesiDatum, int matematika, int magyar)
            {
                this.omAzonosito = omAzonosito;
                this.neve = neve;
                this.ertesitesiCime = ertesitesiCime;
                this.email = email;
                this.szuletesiDatum = szuletesiDatum;
                this.matematika = matematika;
                this.magyar = magyar;
            }

    
        public string Neve
        {
            get => neve;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit))
                {
                    string[] words = value.Split(" ");

                    if (words.Length >= 2 && words.All(word => char.IsUpper(word[0])))
                    {
                
                        if (value.Contains("  "))
                        {
                            throw new ArgumentException("Nem megengedett dupla szóköz a névben.", nameof(Neve));
                        }

                        neve = value;
                    }
                    else
                    {
                        throw new ArgumentException("A névnek legalább két szóból kell álljon, és minden szónak nagybetűvel kell kezdődnie.", nameof(Neve));
                    }
                }
                else
                {
                    throw new ArgumentException("A név nem lehet üres / nem tartalmazhat számot.", nameof(Neve));
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Count(c => c == '@') == 1 && !value.Contains(" ") && value.Contains("."))
                    {
                        email = value;
                    }
                    else
                    {
                        throw new ArgumentException("Érvénytelen e-mail cím formátum.", nameof(Email));
                    }
                }
                else
                {
                    throw new ArgumentException("Az e-mail cím nem lehet üres.", nameof(Email));
                }
            }
        }
        public string ErtesitesiCime
            {
                get => ertesitesiCime;
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        ertesitesiCime = value;
                    else
                        throw new ArgumentException("Az értesítési cím nem lehet üres.",nameof(ErtesitesiCime));
                }
            }
        public string OM_Azonosito
        {
            get => omAzonosito;
            set
            {
                if (value.All(char.IsDigit) && value.Length == 11)
                    omAzonosito = value;
                else
                    throw new ArgumentException("Az OM azonosítónak 11 számjegyből kell állnia.", nameof(OM_Azonosito));
            }
        }


        public DateTime SzuletesiDatum
            {
                get => szuletesiDatum;
                set
                {
                    if (value >= new DateTime(2000, 1, 1) && value <= new DateTime(2013,1,1))
                        szuletesiDatum = value;
                    else
                        throw new ArgumentException("Érvénytelen születési dátum.", nameof(SzuletesiDatum));
                }
            }

        public int Magyar
        {
            get => magyar;
            set
            {
                if (value >= -1 && value <= 50 && !string.IsNullOrWhiteSpace(Convert.ToString(value)))
                    magyar = value;
                else
                    throw new ArgumentException("A pontszámnak 0 és 50 között kell lennie.", nameof(Magyar));
            }
        }
        public int Matematika
            {
                get => matematika;
                set
                {
                    if (value >= -1 && value <= 50 && !string.IsNullOrWhiteSpace(Convert.ToString(value)))
                        matematika = value;
                    else
                    throw new ArgumentException("A pontszámnak 0 és 50 között kell lennie.", nameof(Matematika));
                 }
            }


            public string CSVSortAdVissza()
            {
                return $"{OM_Azonosito};{Neve};{ErtesitesiCime};{Email};{SzuletesiDatum};{Matematika};{Magyar}";
            }

            public void ModositCSVSorral(String csvString)
            {
            string[] adatok = csvString.Split(';');
            omAzonosito = adatok[0];
            neve = adatok[1];
            ertesitesiCime = adatok[2];
            email = adatok[3];
            szuletesiDatum = DateTime.Parse(adatok[4]);
            matematika = adatok[5] == "NULL" ? matematika = -1 : matematika = int.Parse(adatok[5]);
            magyar = adatok[6] == "NULL" ? magyar = -1 : magyar = int.Parse(adatok[6]);

        }
        }
}
