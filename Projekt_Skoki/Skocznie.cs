using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projekt_Skoki
{
    class Skocznie
    {
        // zdarzenie PobitoRekord
        public event EventHandler<Zdarzenie> PobitoRekord;
        protected virtual void OnPobitoRekord(Zdarzenie args)
        {
            EventHandler<Zdarzenie> handler = PobitoRekord;
            if (handler != null)
                handler(this, args);
        }

        public int id;
        public string nazwa;
        public string miasto;
        public string kraj;
        public int punktK;
        public int rekord;
        public string czyj_rekord;
        public string a_zdjecia;

        // zdarzenie - pobicie rekordu skoczni
        public int Rekord
        {
            get { return rekord; }
            set
            {
                if (value > rekord)
                {
                    rekord = value;
                    Zdarzenie args = new Zdarzenie();
                    args.Tekst = "Pobito rekord skoczni : " + nazwa + " (" + miasto + "). ";
                    args.Tekst += "Nowy rekord to : " + rekord.ToString() + " m.\n";
                    if (PobitoRekord != null)
                        OnPobitoRekord(args);
                }
            }
        }

        // zapisanie do bazy nowego rekordu
        public void ZapiszRekord(Skocznie skocznia,Skoczkowie skoczek, double nowyRekord)
        {
            string rekord = "UPDATE Skocznie SET Rekord = '" + nowyRekord + "' WHERE ID_Skoczni = " + skocznia.id;
            string pom = skoczek.imie + " " + skoczek.nazwisko.ToUpper();
            string czyj_rekord = "UPDATE Skocznie SET Czyj_rekord = '" + pom + "' WHERE ID_Skoczni = " + skocznia.id;
            MySqlConnection polacz = Baza.Polaczenie();
            MySqlCommand cmd = new MySqlCommand(rekord, polacz);

            polacz.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = czyj_rekord;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // konstruktor
        public Skocznie(int id, string nazwa, string miasto, string kraj, int pktK, int rek, string czyj, string zdj)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.miasto = miasto;
            this.kraj = kraj;
            punktK = pktK;
            rekord = rek;
            czyj_rekord = czyj;
            a_zdjecia = zdj;
        }

        // wczytanie skoczni z bazy do listy
        public static List<Skocznie> Wczytaj()
        {
            List<Skocznie> listaSkoczni = new List<Skocznie>();
            MySqlConnection polacz = Baza.Polaczenie();
            polacz.Open();

            try
            {
                string maxID = "SELECT MAX(ID_Skoczni) FROM Skocznie";
                MySqlCommand cmd = new MySqlCommand(maxID, polacz);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int ilosc = Convert.ToInt32(dr[0]);
                dr.Close();

                int i = 1;
                while (i <= ilosc)
                {
                    string pobierz = "SELECT * FROM Skocznie WHERE ID_Skoczni = " + i;
                    cmd.CommandText = pobierz;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int id = Convert.ToInt32(dr[0]);
                    string nazwa = Convert.ToString(dr[1]);
                    string miasto = Convert.ToString(dr[2]);
                    string kraj = Convert.ToString(dr[3]);
                    int punktK = Convert.ToInt32(dr[4]);
                    int rekord = 0;
                    if (dr[5] != DBNull.Value)
                        rekord = Convert.ToInt32(dr[5]);
                    string czyj = null;
                    if (dr[6] != DBNull.Value)
                        czyj = Convert.ToString(dr[6]);
                    string a_zdjecia = Convert.ToString(dr[7]);
                    dr.Close();

                    Skocznie skocznia = new Skocznie(id, nazwa, miasto, kraj, punktK, rekord, czyj, a_zdjecia);
                    listaSkoczni.Add(skocznia);
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

            return listaSkoczni;
        }
    }
}
