using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projekt_Skoki
{
    class Zawody
    {
        public int id;
        DateTime data;
        int id_skoczni;

        // konstruktor
        public Zawody(int id, DateTime data, int id_skoczni)
        {
            this.id = id;
            this.data = data;
            this.id_skoczni = id_skoczni;
        }

        // wypisanie
        public override string ToString()
        {
            List<Skocznie> listaSkoczni = Skocznie.Wczytaj();
            return id + ". " + listaSkoczni[id_skoczni - 1].miasto + " [" + listaSkoczni[id_skoczni - 1].kraj + "] - " + data.ToShortDateString();
        }

        // wczytanie z bazy
        public static List<Zawody> Wczytaj()
        {
            List<Zawody> listaZawodow = new List<Zawody>();
            MySqlConnection polaczenie = Baza.Polaczenie();
            polaczenie.Open();

            try
            {
                string maxID = "SELECT MAX(ID_Zawodow) FROM Zawody";
                MySqlCommand cmd = new MySqlCommand(maxID, polaczenie);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int ilosc = Convert.ToInt32(dr[0]);
                dr.Close();

                int i = 1;
                while (i <= ilosc)
                {
                    string pobierz = "SELECT * FROM Zawody WHERE ID_Zawodow = " + i;
                    cmd.CommandText = pobierz;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int id = Convert.ToInt32(dr[0]);
                    DateTime data = Convert.ToDateTime(dr[1]);
                    int id_skoczni = Convert.ToInt32(dr[2]);
                    dr.Close();

                    Zawody turniej = new Zawody(id, data, id_skoczni);
                    listaZawodow.Add(turniej);
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

            return listaZawodow;
        }

        // zapis do bazy
        public void Zapisz(Zawody turniej)
        {
            MySqlConnection polacz = Baza.Polaczenie();
            polacz.Open();
            string wstaw = String.Format("INSERT INTO Zawody VALUES({0},'{1}',{2})", turniej.id, turniej.data, turniej.id_skoczni);
            MySqlCommand cmd = new MySqlCommand(wstaw, polacz);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd połączenia\n" + e.ToString());
            }
            finally
            {
                polacz.Close();
            }
        }
    }
}
