namespace Projekt_Skoki
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pb_skocznia = new System.Windows.Forms.PictureBox();
            this.bt_skocznia_zdjecie = new System.Windows.Forms.Button();
            this.tb_skocznia_szukaj = new System.Windows.Forms.TextBox();
            this.rb_skocznia_rekord = new System.Windows.Forms.RadioButton();
            this.rb_skocznia_miasto = new System.Windows.Forms.RadioButton();
            this.rb_skocznia_kraj = new System.Windows.Forms.RadioButton();
            this.rb_skocznia_nazwa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_skocznia_wyswietl = new System.Windows.Forms.Button();
            this.dgvSkocznie = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_skoczek_wyzeruj = new System.Windows.Forms.Button();
            this.pb_skoczek = new System.Windows.Forms.PictureBox();
            this.bt_skoczek_zdjecie = new System.Windows.Forms.Button();
            this.tb_skoczek_szukaj = new System.Windows.Forms.TextBox();
            this.rb_skoczek_trener = new System.Windows.Forms.RadioButton();
            this.rb_skoczek_kraj = new System.Windows.Forms.RadioButton();
            this.rb_skoczek_nazwisko = new System.Windows.Forms.RadioButton();
            this.rb_skoczek_imie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_skoczek_wyswietl = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rb_turniej_punkty = new System.Windows.Forms.RadioButton();
            this.rb_turniej_odleglosc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvWyniki = new System.Windows.Forms.DataGridView();
            this.bt_turniej_wyniki = new System.Windows.Forms.Button();
            this.lb_turnieje = new System.Windows.Forms.ListBox();
            this.bt_turniej_wyswietl = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cb_symulacja_widok = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_symulacja_skoki = new System.Windows.Forms.RichTextBox();
            this.cb_symulacja_zapis = new System.Windows.Forms.CheckBox();
            this.bt_symulacja_start = new System.Windows.Forms.Button();
            this.cb_symulacja_skocznie = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_symulacja_skocznie = new System.Windows.Forms.ComboBox();
            this.skocznieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtb_symulacja_rekordy = new System.Windows.Forms.RichTextBox();
            this.dgvSkoczkowie = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_skocznia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkocznie)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_skoczek)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyniki)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skocznieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skokiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkoczkowie)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pb_skocznia);
            this.tabPage2.Controls.Add(this.bt_skocznia_zdjecie);
            this.tabPage2.Controls.Add(this.tb_skocznia_szukaj);
            this.tabPage2.Controls.Add(this.rb_skocznia_rekord);
            this.tabPage2.Controls.Add(this.rb_skocznia_miasto);
            this.tabPage2.Controls.Add(this.rb_skocznia_kraj);
            this.tabPage2.Controls.Add(this.rb_skocznia_nazwa);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bt_skocznia_wyswietl);
            this.tabPage2.Controls.Add(this.dgvSkocznie);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(915, 436);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Skocznie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pb_skocznia
            // 
            this.pb_skocznia.Location = new System.Drawing.Point(665, 181);
            this.pb_skocznia.Name = "pb_skocznia";
            this.pb_skocznia.Size = new System.Drawing.Size(240, 245);
            this.pb_skocznia.TabIndex = 22;
            this.pb_skocznia.TabStop = false;
            // 
            // bt_skocznia_zdjecie
            // 
            this.bt_skocznia_zdjecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_skocznia_zdjecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_skocznia_zdjecie.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_skocznia_zdjecie.Location = new System.Drawing.Point(664, 152);
            this.bt_skocznia_zdjecie.Name = "bt_skocznia_zdjecie";
            this.bt_skocznia_zdjecie.Size = new System.Drawing.Size(241, 23);
            this.bt_skocznia_zdjecie.TabIndex = 21;
            this.bt_skocznia_zdjecie.Text = "Wyświetl zdjęcie skoczni";
            this.bt_skocznia_zdjecie.UseVisualStyleBackColor = false;
            // 
            // tb_skocznia_szukaj
            // 
            this.tb_skocznia_szukaj.Location = new System.Drawing.Point(664, 109);
            this.tb_skocznia_szukaj.Name = "tb_skocznia_szukaj";
            this.tb_skocznia_szukaj.Size = new System.Drawing.Size(241, 22);
            this.tb_skocznia_szukaj.TabIndex = 19;
            this.tb_skocznia_szukaj.TextChanged += new System.EventHandler(this.tb_skocznia_szukaj_TextChanged);
            // 
            // rb_skocznia_rekord
            // 
            this.rb_skocznia_rekord.AutoSize = true;
            this.rb_skocznia_rekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skocznia_rekord.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skocznia_rekord.Location = new System.Drawing.Point(765, 86);
            this.rb_skocznia_rekord.Name = "rb_skocznia_rekord";
            this.rb_skocznia_rekord.Size = new System.Drawing.Size(76, 17);
            this.rb_skocznia_rekord.TabIndex = 18;
            this.rb_skocznia_rekord.TabStop = true;
            this.rb_skocznia_rekord.Text = "rekordzista";
            this.rb_skocznia_rekord.UseVisualStyleBackColor = true;
            // 
            // rb_skocznia_miasto
            // 
            this.rb_skocznia_miasto.AutoSize = true;
            this.rb_skocznia_miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skocznia_miasto.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skocznia_miasto.Location = new System.Drawing.Point(765, 63);
            this.rb_skocznia_miasto.Name = "rb_skocznia_miasto";
            this.rb_skocznia_miasto.Size = new System.Drawing.Size(55, 17);
            this.rb_skocznia_miasto.TabIndex = 17;
            this.rb_skocznia_miasto.TabStop = true;
            this.rb_skocznia_miasto.Text = "miasto";
            this.rb_skocznia_miasto.UseVisualStyleBackColor = true;
            // 
            // rb_skocznia_kraj
            // 
            this.rb_skocznia_kraj.AutoSize = true;
            this.rb_skocznia_kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skocznia_kraj.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skocznia_kraj.Location = new System.Drawing.Point(665, 86);
            this.rb_skocznia_kraj.Name = "rb_skocznia_kraj";
            this.rb_skocznia_kraj.Size = new System.Drawing.Size(42, 17);
            this.rb_skocznia_kraj.TabIndex = 16;
            this.rb_skocznia_kraj.TabStop = true;
            this.rb_skocznia_kraj.Text = "kraj";
            this.rb_skocznia_kraj.UseVisualStyleBackColor = true;
            // 
            // rb_skocznia_nazwa
            // 
            this.rb_skocznia_nazwa.AutoSize = true;
            this.rb_skocznia_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skocznia_nazwa.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skocznia_nazwa.Location = new System.Drawing.Point(665, 63);
            this.rb_skocznia_nazwa.Name = "rb_skocznia_nazwa";
            this.rb_skocznia_nazwa.Size = new System.Drawing.Size(56, 17);
            this.rb_skocznia_nazwa.TabIndex = 15;
            this.rb_skocznia_nazwa.TabStop = true;
            this.rb_skocznia_nazwa.Text = "nazwa";
            this.rb_skocznia_nazwa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(661, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Wyszukaj według :";
            // 
            // bt_skocznia_wyswietl
            // 
            this.bt_skocznia_wyswietl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_skocznia_wyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_skocznia_wyswietl.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_skocznia_wyswietl.Location = new System.Drawing.Point(662, 12);
            this.bt_skocznia_wyswietl.Name = "bt_skocznia_wyswietl";
            this.bt_skocznia_wyswietl.Size = new System.Drawing.Size(241, 23);
            this.bt_skocznia_wyswietl.TabIndex = 13;
            this.bt_skocznia_wyswietl.Text = "Wyświetl skocznie";
            this.bt_skocznia_wyswietl.UseVisualStyleBackColor = false;
            this.bt_skocznia_wyswietl.Click += new System.EventHandler(this.bt_skocznia_wyswietl_Click);
            // 
            // dgvSkocznie
            // 
            this.dgvSkocznie.AllowUserToAddRows = false;
            this.dgvSkocznie.AllowUserToDeleteRows = false;
            this.dgvSkocznie.AllowUserToResizeColumns = false;
            this.dgvSkocznie.AllowUserToResizeRows = false;
            this.dgvSkocznie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkocznie.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkocznie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSkocznie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkocznie.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSkocznie.Location = new System.Drawing.Point(3, 3);
            this.dgvSkocznie.MultiSelect = false;
            this.dgvSkocznie.Name = "dgvSkocznie";
            this.dgvSkocznie.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSkocznie.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSkocznie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkocznie.Size = new System.Drawing.Size(653, 423);
            this.dgvSkocznie.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dgvSkoczkowie);
            this.tabPage1.Controls.Add(this.bt_skoczek_wyzeruj);
            this.tabPage1.Controls.Add(this.pb_skoczek);
            this.tabPage1.Controls.Add(this.bt_skoczek_zdjecie);
            this.tabPage1.Controls.Add(this.tb_skoczek_szukaj);
            this.tabPage1.Controls.Add(this.rb_skoczek_trener);
            this.tabPage1.Controls.Add(this.rb_skoczek_kraj);
            this.tabPage1.Controls.Add(this.rb_skoczek_nazwisko);
            this.tabPage1.Controls.Add(this.rb_skoczek_imie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bt_skoczek_wyswietl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(915, 436);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Skoczkowie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_skoczek_wyzeruj
            // 
            this.bt_skoczek_wyzeruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_skoczek_wyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_skoczek_wyzeruj.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_skoczek_wyzeruj.Location = new System.Drawing.Point(662, 33);
            this.bt_skoczek_wyzeruj.Name = "bt_skoczek_wyzeruj";
            this.bt_skoczek_wyzeruj.Size = new System.Drawing.Size(241, 23);
            this.bt_skoczek_wyzeruj.TabIndex = 12;
            this.bt_skoczek_wyzeruj.Text = "Wyzeruj punkty";
            this.bt_skoczek_wyzeruj.UseVisualStyleBackColor = false;
            // 
            // pb_skoczek
            // 
            this.pb_skoczek.Location = new System.Drawing.Point(666, 182);
            this.pb_skoczek.Name = "pb_skoczek";
            this.pb_skoczek.Size = new System.Drawing.Size(240, 245);
            this.pb_skoczek.TabIndex = 10;
            this.pb_skoczek.TabStop = false;
            // 
            // bt_skoczek_zdjecie
            // 
            this.bt_skoczek_zdjecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_skoczek_zdjecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_skoczek_zdjecie.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_skoczek_zdjecie.Location = new System.Drawing.Point(666, 153);
            this.bt_skoczek_zdjecie.Name = "bt_skoczek_zdjecie";
            this.bt_skoczek_zdjecie.Size = new System.Drawing.Size(241, 23);
            this.bt_skoczek_zdjecie.TabIndex = 9;
            this.bt_skoczek_zdjecie.Text = "Wyświetl zdjęcie zawodnika";
            this.bt_skoczek_zdjecie.UseVisualStyleBackColor = false;
            // 
            // tb_skoczek_szukaj
            // 
            this.tb_skoczek_szukaj.Location = new System.Drawing.Point(665, 127);
            this.tb_skoczek_szukaj.Name = "tb_skoczek_szukaj";
            this.tb_skoczek_szukaj.Size = new System.Drawing.Size(237, 22);
            this.tb_skoczek_szukaj.TabIndex = 8;
            this.tb_skoczek_szukaj.TextChanged += new System.EventHandler(this.tb_skoczek_szukaj_TextChanged);
            // 
            // rb_skoczek_trener
            // 
            this.rb_skoczek_trener.AutoSize = true;
            this.rb_skoczek_trener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skoczek_trener.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skoczek_trener.Location = new System.Drawing.Point(766, 104);
            this.rb_skoczek_trener.Name = "rb_skoczek_trener";
            this.rb_skoczek_trener.Size = new System.Drawing.Size(52, 17);
            this.rb_skoczek_trener.TabIndex = 7;
            this.rb_skoczek_trener.TabStop = true;
            this.rb_skoczek_trener.Text = "trener";
            this.rb_skoczek_trener.UseVisualStyleBackColor = true;
            // 
            // rb_skoczek_kraj
            // 
            this.rb_skoczek_kraj.AutoSize = true;
            this.rb_skoczek_kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skoczek_kraj.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skoczek_kraj.Location = new System.Drawing.Point(766, 81);
            this.rb_skoczek_kraj.Name = "rb_skoczek_kraj";
            this.rb_skoczek_kraj.Size = new System.Drawing.Size(42, 17);
            this.rb_skoczek_kraj.TabIndex = 6;
            this.rb_skoczek_kraj.TabStop = true;
            this.rb_skoczek_kraj.Text = "kraj";
            this.rb_skoczek_kraj.UseVisualStyleBackColor = true;
            // 
            // rb_skoczek_nazwisko
            // 
            this.rb_skoczek_nazwisko.AutoSize = true;
            this.rb_skoczek_nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skoczek_nazwisko.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skoczek_nazwisko.Location = new System.Drawing.Point(665, 104);
            this.rb_skoczek_nazwisko.Name = "rb_skoczek_nazwisko";
            this.rb_skoczek_nazwisko.Size = new System.Drawing.Size(69, 17);
            this.rb_skoczek_nazwisko.TabIndex = 5;
            this.rb_skoczek_nazwisko.TabStop = true;
            this.rb_skoczek_nazwisko.Text = "nazwisko";
            this.rb_skoczek_nazwisko.UseVisualStyleBackColor = true;
            // 
            // rb_skoczek_imie
            // 
            this.rb_skoczek_imie.AutoSize = true;
            this.rb_skoczek_imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_skoczek_imie.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_skoczek_imie.Location = new System.Drawing.Point(666, 81);
            this.rb_skoczek_imie.Name = "rb_skoczek_imie";
            this.rb_skoczek_imie.Size = new System.Drawing.Size(43, 17);
            this.rb_skoczek_imie.TabIndex = 4;
            this.rb_skoczek_imie.TabStop = true;
            this.rb_skoczek_imie.Text = "imię";
            this.rb_skoczek_imie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(663, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wyszukaj według :";
            // 
            // bt_skoczek_wyswietl
            // 
            this.bt_skoczek_wyswietl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_skoczek_wyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_skoczek_wyswietl.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_skoczek_wyswietl.Location = new System.Drawing.Point(662, 4);
            this.bt_skoczek_wyswietl.Name = "bt_skoczek_wyswietl";
            this.bt_skoczek_wyswietl.Size = new System.Drawing.Size(241, 23);
            this.bt_skoczek_wyswietl.TabIndex = 1;
            this.bt_skoczek_wyswietl.Text = "Wyświetl skoczków";
            this.bt_skoczek_wyswietl.UseVisualStyleBackColor = false;
            this.bt_skoczek_wyswietl.Click += new System.EventHandler(this.bt_skoczek_wyswietl_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 465);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rb_turniej_punkty);
            this.tabPage3.Controls.Add(this.rb_turniej_odleglosc);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dgvWyniki);
            this.tabPage3.Controls.Add(this.bt_turniej_wyniki);
            this.tabPage3.Controls.Add(this.lb_turnieje);
            this.tabPage3.Controls.Add(this.bt_turniej_wyswietl);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(915, 436);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Turnieje";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rb_turniej_punkty
            // 
            this.rb_turniej_punkty.AutoSize = true;
            this.rb_turniej_punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_turniej_punkty.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_turniej_punkty.Location = new System.Drawing.Point(145, 311);
            this.rb_turniej_punkty.Name = "rb_turniej_punkty";
            this.rb_turniej_punkty.Size = new System.Drawing.Size(97, 17);
            this.rb_turniej_punkty.TabIndex = 16;
            this.rb_turniej_punkty.TabStop = true;
            this.rb_turniej_punkty.Text = "zdobyte punkty";
            this.rb_turniej_punkty.UseVisualStyleBackColor = true;
            // 
            // rb_turniej_odleglosc
            // 
            this.rb_turniej_odleglosc.AutoSize = true;
            this.rb_turniej_odleglosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_turniej_odleglosc.ForeColor = System.Drawing.Color.DarkOrange;
            this.rb_turniej_odleglosc.Location = new System.Drawing.Point(55, 311);
            this.rb_turniej_odleglosc.Name = "rb_turniej_odleglosc";
            this.rb_turniej_odleglosc.Size = new System.Drawing.Size(72, 17);
            this.rb_turniej_odleglosc.TabIndex = 15;
            this.rb_turniej_odleglosc.TabStop = true;
            this.rb_turniej_odleglosc.Text = "odległość";
            this.rb_turniej_odleglosc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(52, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wyświetl wyniki posortowane według :";
            // 
            // dgvWyniki
            // 
            this.dgvWyniki.AllowUserToAddRows = false;
            this.dgvWyniki.AllowUserToDeleteRows = false;
            this.dgvWyniki.AllowUserToResizeColumns = false;
            this.dgvWyniki.AllowUserToResizeRows = false;
            this.dgvWyniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWyniki.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWyniki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWyniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWyniki.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWyniki.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvWyniki.Location = new System.Drawing.Point(325, 45);
            this.dgvWyniki.MultiSelect = false;
            this.dgvWyniki.Name = "dgvWyniki";
            this.dgvWyniki.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvWyniki.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvWyniki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWyniki.Size = new System.Drawing.Size(567, 342);
            this.dgvWyniki.TabIndex = 13;
            // 
            // bt_turniej_wyniki
            // 
            this.bt_turniej_wyniki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_turniej_wyniki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_turniej_wyniki.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_turniej_wyniki.Location = new System.Drawing.Point(55, 334);
            this.bt_turniej_wyniki.Name = "bt_turniej_wyniki";
            this.bt_turniej_wyniki.Size = new System.Drawing.Size(187, 23);
            this.bt_turniej_wyniki.TabIndex = 2;
            this.bt_turniej_wyniki.Text = "Wyniki";
            this.bt_turniej_wyniki.UseVisualStyleBackColor = false;
            this.bt_turniej_wyniki.Click += new System.EventHandler(this.bt_turniej_wyniki_Click);
            // 
            // lb_turnieje
            // 
            this.lb_turnieje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_turnieje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_turnieje.FormattingEnabled = true;
            this.lb_turnieje.Items.AddRange(new object[] {
            "--- --- --- Turnieje --- --- ---"});
            this.lb_turnieje.Location = new System.Drawing.Point(13, 45);
            this.lb_turnieje.Name = "lb_turnieje";
            this.lb_turnieje.Size = new System.Drawing.Size(296, 238);
            this.lb_turnieje.TabIndex = 1;
            // 
            // bt_turniej_wyswietl
            // 
            this.bt_turniej_wyswietl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_turniej_wyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_turniej_wyswietl.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_turniej_wyswietl.Location = new System.Drawing.Point(55, 16);
            this.bt_turniej_wyswietl.Name = "bt_turniej_wyswietl";
            this.bt_turniej_wyswietl.Size = new System.Drawing.Size(205, 23);
            this.bt_turniej_wyswietl.TabIndex = 0;
            this.bt_turniej_wyswietl.Text = "Wyświetl turnieje";
            this.bt_turniej_wyswietl.UseVisualStyleBackColor = false;
            this.bt_turniej_wyswietl.Click += new System.EventHandler(this.bt_turniej_wyswietl_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cb_symulacja_widok);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.rtb_symulacja_skoki);
            this.tabPage4.Controls.Add(this.cb_symulacja_zapis);
            this.tabPage4.Controls.Add(this.bt_symulacja_start);
            this.tabPage4.Controls.Add(this.cb_symulacja_skocznie);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.combo_symulacja_skocznie);
            this.tabPage4.Controls.Add(this.rtb_symulacja_rekordy);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(915, 436);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Symulacja";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cb_symulacja_widok
            // 
            this.cb_symulacja_widok.AutoSize = true;
            this.cb_symulacja_widok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_symulacja_widok.ForeColor = System.Drawing.Color.DarkOrange;
            this.cb_symulacja_widok.Location = new System.Drawing.Point(728, 129);
            this.cb_symulacja_widok.Name = "cb_symulacja_widok";
            this.cb_symulacja_widok.Size = new System.Drawing.Size(85, 17);
            this.cb_symulacja_widok.TabIndex = 9;
            this.cb_symulacja_widok.Text = "Nie pokazuj ";
            this.cb_symulacja_widok.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(669, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Skoki ;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(205, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rekordy ;";
            // 
            // rtb_symulacja_skoki
            // 
            this.rtb_symulacja_skoki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_symulacja_skoki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_symulacja_skoki.Location = new System.Drawing.Point(469, 146);
            this.rtb_symulacja_skoki.Name = "rtb_symulacja_skoki";
            this.rtb_symulacja_skoki.Size = new System.Drawing.Size(433, 285);
            this.rtb_symulacja_skoki.TabIndex = 6;
            this.rtb_symulacja_skoki.Text = "";
            // 
            // cb_symulacja_zapis
            // 
            this.cb_symulacja_zapis.AutoSize = true;
            this.cb_symulacja_zapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_symulacja_zapis.ForeColor = System.Drawing.Color.DarkOrange;
            this.cb_symulacja_zapis.Location = new System.Drawing.Point(13, 82);
            this.cb_symulacja_zapis.Name = "cb_symulacja_zapis";
            this.cb_symulacja_zapis.Size = new System.Drawing.Size(128, 17);
            this.cb_symulacja_zapis.TabIndex = 5;
            this.cb_symulacja_zapis.Text = "Zapisz wyniki w bazie";
            this.cb_symulacja_zapis.UseVisualStyleBackColor = true;
            // 
            // bt_symulacja_start
            // 
            this.bt_symulacja_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_symulacja_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_symulacja_start.ForeColor = System.Drawing.Color.OrangeRed;
            this.bt_symulacja_start.Location = new System.Drawing.Point(28, 108);
            this.bt_symulacja_start.Name = "bt_symulacja_start";
            this.bt_symulacja_start.Size = new System.Drawing.Size(75, 23);
            this.bt_symulacja_start.TabIndex = 4;
            this.bt_symulacja_start.Text = "Start";
            this.bt_symulacja_start.UseVisualStyleBackColor = false;
            this.bt_symulacja_start.Click += new System.EventHandler(this.bt_symulacja_start_Click);
            // 
            // cb_symulacja_skocznie
            // 
            this.cb_symulacja_skocznie.AutoSize = true;
            this.cb_symulacja_skocznie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_symulacja_skocznie.ForeColor = System.Drawing.Color.DarkOrange;
            this.cb_symulacja_skocznie.Location = new System.Drawing.Point(13, 58);
            this.cb_symulacja_skocznie.Name = "cb_symulacja_skocznie";
            this.cb_symulacja_skocznie.Size = new System.Drawing.Size(119, 17);
            this.cb_symulacja_skocznie.TabIndex = 3;
            this.cb_symulacja_skocznie.Text = "Wszystkie skocznie";
            this.cb_symulacja_skocznie.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wybierz skocznie";
            // 
            // combo_symulacja_skocznie
            // 
            this.combo_symulacja_skocznie.DataSource = this.skocznieBindingSource;
            this.combo_symulacja_skocznie.DisplayMember = "Miejscowosc";
            this.combo_symulacja_skocznie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_symulacja_skocznie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combo_symulacja_skocznie.FormattingEnabled = true;
            this.combo_symulacja_skocznie.Location = new System.Drawing.Point(12, 30);
            this.combo_symulacja_skocznie.Name = "combo_symulacja_skocznie";
            this.combo_symulacja_skocznie.Size = new System.Drawing.Size(129, 23);
            this.combo_symulacja_skocznie.TabIndex = 1;
            // 
            // skocznieBindingSource
            // 
            this.skocznieBindingSource.DataMember = "skocznie";
            this.skocznieBindingSource.DataSource = this.skokiDataSet;
            // 
            // skokiDataSet
            // 
            // 
            // rtb_symulacja_rekordy
            // 
            this.rtb_symulacja_rekordy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_symulacja_rekordy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_symulacja_rekordy.Location = new System.Drawing.Point(12, 146);
            this.rtb_symulacja_rekordy.Name = "rtb_symulacja_rekordy";
            this.rtb_symulacja_rekordy.Size = new System.Drawing.Size(450, 285);
            this.rtb_symulacja_rekordy.TabIndex = 0;
            this.rtb_symulacja_rekordy.Text = "";
            // 
            // skocznieTableAdapter
            // 
            // 
            // dgvSkoczkowie
            // 
            this.dgvSkoczkowie.AllowUserToAddRows = false;
            this.dgvSkoczkowie.AllowUserToDeleteRows = false;
            this.dgvSkoczkowie.AllowUserToResizeColumns = false;
            this.dgvSkoczkowie.AllowUserToResizeRows = false;
            this.dgvSkoczkowie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkoczkowie.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkoczkowie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSkoczkowie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkoczkowie.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSkoczkowie.Location = new System.Drawing.Point(7, 3);
            this.dgvSkoczkowie.MultiSelect = false;
            this.dgvSkoczkowie.Name = "dgvSkoczkowie";
            this.dgvSkoczkowie.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSkoczkowie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSkoczkowie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkoczkowie.Size = new System.Drawing.Size(653, 423);
            this.dgvSkoczkowie.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(914, 465);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Skoki narciarskie";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_skocznia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkocznie)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_skoczek)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyniki)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skocznieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skokiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkoczkowie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button bt_skoczek_wyswietl;
        private System.Windows.Forms.RadioButton rb_skoczek_trener;
        private System.Windows.Forms.RadioButton rb_skoczek_kraj;
        private System.Windows.Forms.RadioButton rb_skoczek_nazwisko;
        private System.Windows.Forms.RadioButton rb_skoczek_imie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_skoczek_szukaj;
        private System.Windows.Forms.PictureBox pb_skoczek;
        private System.Windows.Forms.Button bt_skoczek_zdjecie;
        private System.Windows.Forms.DataGridView dgvSkocznie;
        private System.Windows.Forms.Button bt_skocznia_wyswietl;
        private System.Windows.Forms.TextBox tb_skocznia_szukaj;
        private System.Windows.Forms.RadioButton rb_skocznia_rekord;
        private System.Windows.Forms.RadioButton rb_skocznia_miasto;
        private System.Windows.Forms.RadioButton rb_skocznia_kraj;
        private System.Windows.Forms.RadioButton rb_skocznia_nazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_skocznia;
        private System.Windows.Forms.Button bt_skocznia_zdjecie;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lb_turnieje;
        private System.Windows.Forms.Button bt_turniej_wyswietl;
        private System.Windows.Forms.Button bt_turniej_wyniki;
        private System.Windows.Forms.DataGridView dgvWyniki;
        private System.Windows.Forms.RadioButton rb_turniej_punkty;
        private System.Windows.Forms.RadioButton rb_turniej_odleglosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_symulacja_skocznie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_symulacja_skocznie;
        private System.Windows.Forms.RichTextBox rtb_symulacja_rekordy;
        private skokiDataSet skokiDataSet;
        private System.Windows.Forms.BindingSource skocznieBindingSource;
        private skokiDataSetTableAdapters.skocznieTableAdapter skocznieTableAdapter;
        private System.Windows.Forms.CheckBox cb_symulacja_zapis;
        private System.Windows.Forms.Button bt_symulacja_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_symulacja_skoki;
        private System.Windows.Forms.Button bt_skoczek_wyzeruj;
        private System.Windows.Forms.CheckBox cb_symulacja_widok;
        private System.Windows.Forms.DataGridView dgvSkoczkowie;

    }
}
