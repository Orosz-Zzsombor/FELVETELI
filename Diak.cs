using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELVETELI
{
    internal class Diak : IFelvetelizo
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
            string[] adatok = csvString.Split(';');
            omAzonosito = adatok[0];
            neve = adatok[1];
            ertesitesiCime = adatok[2];
            email = adatok[3];
            szuletesiDatum = DateTime.Parse(adatok[4]);
            matematika = adatok[5] == "NULL" ? matematika = -1 : matematika = int.Parse(adatok[5]);
            magyar = adatok[6] == "NULL" ? magyar = -1 : magyar = int.Parse(adatok[6]);
            /*
            if (adatok.Length != 7)
                {
                    throw new ArgumentException("Érvénytelen CSV formátum. A CSV sort 7 adatnak kell tartalmaznia.");
                }

               try
                {

                }
                catch (FormatException)
                {
                    throw new ArgumentException("Érvénytelen adatformátum a CSV sorban.");
                }
            */
        }


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

            public string OM_Azonosito
            {
                get => omAzonosito;
                set
                {
                    if (value.All(char.IsDigit) && value.Length == 11)
                        omAzonosito = value;
                    else
                        throw new ArgumentException("Az OM azonosítónak 11 számjegyből kell állnia.");
                }
            }

            public string Neve
            {
                get => neve;
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        neve = value;
                    else
                        throw new ArgumentException("A név nem lehet üres.");
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
                        throw new ArgumentException("Az értesítési cím nem lehet üres.");
                }
            }

            public string Email
            {
                get => email; set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {

                        if (value.Contains("@") && value.Contains("."))
                            email = value;
                        else
                            throw new ArgumentException("Érvénytelen e-mail cím formátum.");
                    }
                    else
                    {
                        throw new ArgumentException("Az e-mail cím nem lehet üres.");
                    }
                }
            }
            public DateTime SzuletesiDatum
            {
                get => szuletesiDatum;
                set
                {
                    if (value >= new DateTime(1980, 1, 1) && value <= DateTime.Now)
                        szuletesiDatum = value;
                    else
                        throw new ArgumentException("Érvénytelen születési dátum.");
                }
            }

            public int Matematika
            {
                get => matematika;
                set
                {
                    if (value >= 0 && value <= 50)
                        matematika = value;
                    else
                        throw new ArgumentException("A matematika pontszám nem lehet negatív.");
                }
            }

            public int Magyar
            {
                get => magyar;
                set
                {
                    if (value >= 0 && value <= 50)
                        magyar = value;
                    else
                        throw new ArgumentException("A magyar pontszám nem lehet negatív.");
                }
            }

            public string CSVSortAdVissza()
            {
                return $"{OM_Azonosito},{Neve},{ErtesitesiCime},{Email},{SzuletesiDatum},{Matematika},{Magyar}";
            }

            public void ModositCSVSorral(string csvString)
            {


            }
        }
}
