using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt_Skoki
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        // *** SKOCZKOWIE ***
        // Wypełenienie dgvSkoczkowie
        private void bt_skoczek_wyswietl_Click(object sender, EventArgs e)
        {
            string query = "select s.id_skoczka as ID, s.Imie, s.Nazwisko, s.data_urodzenia as 'Data urodzenia', s.Punkty, concat(t.imie,' ',t.nazwisko) as Trener, r.nazwa as Reprezentacja from skoczkowie s " +
                "inner join trenerzy t on s.id_trenera = t.id_trenera " +
                "inner join reprezentacje r on s.id_reprezentacji = r.id_reprezentacji order by id_skoczka";
            Wypelnij(query, dgvSkoczkowie);
        }
        
        // *** SYMULACJA ***
        // Rozpoczęcie SYMULACJI skoków
        private void bt_symulacja_start_Click(object sender, EventArgs e)
        {
            rtb_symulacja_rekordy.Clear();
            rtb_symulacja_skoki.Clear();
            List<Skoczkowie> listaSkoczkow = Skoczkowie.Wczytaj();
            List<Skocznie> listaSkoczni = Skocznie.Wczytaj();
            List<Zawody> listaZawodow = Zawody.Wczytaj();
            List<Skoki> listaSkokow = Skoki.Wczytaj();

            // symulacja na wszystkich skoczniach
            if (cb_symulacja_skocznie.Checked)
            {
                foreach (Skocznie skocznia in listaSkoczni)
                {
                    skocznia.PobitoRekord += skocznia_PobitoRekord;
                    Zawody turniej = new Zawody(listaZawodow.Count + 1, DateTime.Now, skocznia.id);
                    listaZawodow.Add(turniej);
                    if (cb_symulacja_zapis.Checked)
                        turniej.Zapisz(turniej);

                    foreach (Skoczkowie skoczek in listaSkoczkow)
                    {
                        Skoki skok = Symuluj(listaSkokow.Count + 1, skoczek, skocznia, turniej.id);
                        listaSkokow.Add(skok);
                        if (cb_symulacja_zapis.Checked)
                        {
                            skok.Zapisz(skok);
                            skoczek.ZapiszZdobytePunkty(skoczek);
                        }

                        if (!cb_symulacja_widok.Checked)
                            rtb_symulacja_skoki.Text += skok.ToString();
                    }
                }
            }
            
        }

        // *** ZDARZENIA ***
        // Zdarzenie informujące o pobiciu rekordu
        private void skocznia_PobitoRekord(object sender, Zdarzenie e)
        {
            rtb_symulacja_rekordy.Text += e.Tekst;
        }
       
        // Wyszukiwanie w bazie
        void Znajdz(string query, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
                dgv.Rows[i].Selected = false;
            MySqlConnection polaczenie = Baza.Polaczenie();
            MySqlCommand cmd = new MySqlCommand(query, polaczenie);

            try
            {
                polaczenie.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    int index = Convert.ToInt32(dr[0]);
                    dgv.MultiSelect = true;
                    dgv.Rows[index - 1].Selected = true;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}