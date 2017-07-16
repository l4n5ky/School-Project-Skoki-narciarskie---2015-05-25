using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projekt_Skoki
{
    class Skoczkowie
    {
        public int id;
        public string imie;
        public string nazwisko;
        DateTime data;
        public int punkty;
        public string a_zdjecia;
        int id_trenera;
        int id_reprezentacji;

        // konstruktor
        public Skoczkowie(int id, string imie, string nazwisko, DateTime data, int pkt, string a_zdj, int id_t, int id_r)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.data = data;
            punkty = pkt;
            a_zdjecia = a_zdj;
            id_trenera = id_t;
            id_reprezentacji = id_r;
        }

        // operator dodawania punktów
        public static Skoczkowie operator + (Skoczkowie skoczek, int wartosc)
        {
            Skoczkowie poSkoku = skoczek;
            poSkoku.punkty += wartosc;
            return poSkoku;
        }

        // zapisanie do bazy podliczonych punktów
        public void ZapiszZdobytePunkty(Skoczkowie skoczek)
        {
            string zmiana = "UPDATE Skoczkowie SET Punkty = " + skoczek.punkty + " WHERE ID_Skoczka = " + skoczek.id;
            MySqlConnection polacz = Baza.Polaczenie();
            MySqlCommand cmd = new MySqlCommand(zmiana, polacz);

            polacz.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // wyzerowanie punktów w bazie
        public void WyzerujPunkty(Skoczkowie skoczek)
        {
            string zeruj = "UPDATE Skoczkowie SET Punkty = 0 WHERE ID_Skoczka = " + skoczek.id;
            MySqlConnection polacz = Baza.Polaczenie();
            MySqlCommand cmd = new MySqlCommand(zeruj, polacz);

            polacz.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // wczytywanie skoczków z bazy do listy
        public static List<Skoczkowie> Wczytaj()
        {
            List<Skoczkowie> listaSkoczkow = new List<Skoczkowie>();
            MySqlConnection polacz = Baza.Polaczenie();
            polacz.Open();

            try
            {
                string maxID = "SELECT MAX(ID_Skoczka) FROM Skoczkowie";
                MySqlCommand cmd = new MySqlCommand(maxID, polacz);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int ilosc = Convert.ToInt32(dr[0]);
                dr.Close();

                int i = 1;
                while (i <= ilosc)
                {
                    string pobierz = "SELECT * FROM Skoczkowie WHERE ID_Skoczka = " + i;
                    cmd.CommandText = pobierz;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int id = Convert.ToInt32(dr[0]);
                    string imie = Convert.ToString(dr[1]);
                    string nazwisko = Convert.ToString(dr[2]);
                    DateTime data_ur = Convert.ToDateTime(dr[3]);
                    int punkty = 0;
                    if (dr[4] != DBNull.Value)
                        punkty = Convert.ToInt32(dr[4]);
                    string adres_zdjecia = Convert.ToString(dr[5]);
                    int id_trenera = Convert.ToInt32(dr[6]);
                    int id_reprezentacji = Convert.ToInt32(dr[7]);
                    dr.Close();

                    Skoczkowie skoczek = new Skoczkowie(id, imie, nazwisko, data_ur, punkty, adres_zdjecia, id_trenera, id_reprezentacji);
                    listaSkoczkow.Add(skoczek);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                polacz.Close();
            }

            return listaSkoczkow;
        }
    }
}
