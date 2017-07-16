using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projekt_Skoki
{
    class Skoki
    {
        public int id;
        public double odleglosc;
        int punkty;
        int id_skoczka;
        int id_zawodow;

        // konstruktor
        public Skoki(int id, double odleglosc, int punkty, int id_skoczka, int id_zawodow)
        {
            this.id = id;
            this.odleglosc = odleglosc;
            this.punkty = punkty;
            this.id_skoczka = id_skoczka;
            this.id_zawodow = id_zawodow;
        }

        // wypisywanie
        public override string ToString()
        {
            List<Skoczkowie> listaSkoczkow = Skoczkowie.Wczytaj();
            return id + ". " + listaSkoczkow[id_skoczka - 1].imie + " " + listaSkoczkow[id_skoczka - 1].nazwisko + " [" + odleglosc + "m.] - " + punkty + "pkt.\n";
        }

        // wczytanie z bazy
        public static List<Skoki> Wczytaj()
        {
            List<Skoki> listaSkokow = new List<Skoki>();
            MySqlConnection polaczenie = Baza.Polaczenie();
            polaczenie.Open();

            try
            {
                string maxID = "SELECT MAX(ID_Skoku) FROM Skoki";
                MySqlCommand cmd = new MySqlCommand(maxID, polaczenie);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int ilosc = Convert.ToInt32(dr[0]);
                dr.Close();

                int i = 1;
                while (i <= ilosc)
                {
                    string pobierz = "SELECT * FROM Skoki WHERE ID_Skoku = " + i;
                    cmd.CommandText = pobierz;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int id = Convert.ToInt32(dr[0]);
                    int odleglosc = Convert.ToInt32(dr[1]);
                    int punkty = Convert.ToInt32(dr[2]);
                    int id_skoczka = Convert.ToInt32(dr[3]);
                    int id_zawodow = Convert.ToInt32(dr[4]);
                    dr.Close();

                    Skoki skok = new Skoki(id, odleglosc, punkty, id_skoczka, id_zawodow);
                    listaSkokow.Add(skok);
                    i++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd połączenia\n" + e.ToString());
            }
            finally
            {
                polaczenie.Close();
            }

            return listaSkokow;
        }

        // zapis do bazy
        public void Zapisz(Skoki skok)
        {
            MySqlConnection polacz = Baza.Polaczenie();
            string wstaw = String.Format("INSERT INTO Skoki VALUES(null, {0}, {1}, {2}, {3})"
                , Convert.ToDouble(skok.odleglosc), skok.punkty, skok.id_skoczka, skok.id_zawodow);

            polacz.Open();
            MySqlCommand cmd = new MySqlCommand(wstaw, polacz);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                polacz.Close();
            }
        }
    }
}
