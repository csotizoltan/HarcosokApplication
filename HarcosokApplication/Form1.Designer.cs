namespace HarcosokApplication
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
            this.buttonHarcosLetrehozasa = new System.Windows.Forms.Button();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.labelHarcosLetrehozasa = new System.Windows.Forms.Label();
            this.labelHarcosNev = new System.Windows.Forms.Label();
            this.labelKepessegHozzaadasa = new System.Windows.Forms.Label();
            this.labelHarcosElvalaszto = new System.Windows.Forms.Label();
            this.labelKepessegElvalaszto = new System.Windows.Forms.Label();
            this.labelKepessegHasznalo = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.labelKepessegNev = new System.Windows.Forms.Label();
            this.buttonKepessegLetrehozasa = new System.Windows.Forms.Button();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.labelKepessegLeiras = new System.Windows.Forms.Label();
            this.labelHarcosok = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.labelKepessegei = new System.Windows.Forms.Label();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.labelKepessegLeirasa = new System.Windows.Forms.Label();
            this.kepessegLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.buttonKepessegLeirasModosit = new System.Windows.Forms.Button();
            this.buttonKepessegTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHarcosLetrehozasa
            // 
            this.buttonHarcosLetrehozasa.Location = new System.Drawing.Point(230, 42);
            this.buttonHarcosLetrehozasa.Name = "buttonHarcosLetrehozasa";
            this.buttonHarcosLetrehozasa.Size = new System.Drawing.Size(114, 25);
            this.buttonHarcosLetrehozasa.TabIndex = 0;
            this.buttonHarcosLetrehozasa.Text = "Létrehozás";
            this.buttonHarcosLetrehozasa.UseVisualStyleBackColor = true;
            this.buttonHarcosLetrehozasa.Click += new System.EventHandler(this.buttonHarcosLetrehozasa_Click);
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(65, 42);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(147, 22);
            this.harcosNeveTextBox.TabIndex = 1;
            this.harcosNeveTextBox.TextChanged += new System.EventHandler(this.harcosNeveTextBox_TextChanged);
            // 
            // labelHarcosLetrehozasa
            // 
            this.labelHarcosLetrehozasa.AutoSize = true;
            this.labelHarcosLetrehozasa.Location = new System.Drawing.Point(24, 13);
            this.labelHarcosLetrehozasa.Name = "labelHarcosLetrehozasa";
            this.labelHarcosLetrehozasa.Size = new System.Drawing.Size(125, 16);
            this.labelHarcosLetrehozasa.TabIndex = 2;
            this.labelHarcosLetrehozasa.Text = "Harcos létrehozása";
            // 
            // labelHarcosNev
            // 
            this.labelHarcosNev.AutoSize = true;
            this.labelHarcosNev.Location = new System.Drawing.Point(24, 42);
            this.labelHarcosNev.Name = "labelHarcosNev";
            this.labelHarcosNev.Size = new System.Drawing.Size(36, 16);
            this.labelHarcosNev.TabIndex = 3;
            this.labelHarcosNev.Text = "Név:";
            // 
            // labelKepessegHozzaadasa
            // 
            this.labelKepessegHozzaadasa.AutoSize = true;
            this.labelKepessegHozzaadasa.Location = new System.Drawing.Point(24, 101);
            this.labelKepessegHozzaadasa.Name = "labelKepessegHozzaadasa";
            this.labelKepessegHozzaadasa.Size = new System.Drawing.Size(147, 16);
            this.labelKepessegHozzaadasa.TabIndex = 5;
            this.labelKepessegHozzaadasa.Text = "Képesség hozzáadása";
            // 
            // labelHarcosElvalaszto
            // 
            this.labelHarcosElvalaszto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHarcosElvalaszto.Location = new System.Drawing.Point(24, 83);
            this.labelHarcosElvalaszto.Name = "labelHarcosElvalaszto";
            this.labelHarcosElvalaszto.Size = new System.Drawing.Size(680, 2);
            this.labelHarcosElvalaszto.TabIndex = 4;
            // 
            // labelKepessegElvalaszto
            // 
            this.labelKepessegElvalaszto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelKepessegElvalaszto.Location = new System.Drawing.Point(25, 247);
            this.labelKepessegElvalaszto.Name = "labelKepessegElvalaszto";
            this.labelKepessegElvalaszto.Size = new System.Drawing.Size(680, 2);
            this.labelKepessegElvalaszto.TabIndex = 6;
            // 
            // labelKepessegHasznalo
            // 
            this.labelKepessegHasznalo.AutoSize = true;
            this.labelKepessegHasznalo.Location = new System.Drawing.Point(24, 138);
            this.labelKepessegHasznalo.Name = "labelKepessegHasznalo";
            this.labelKepessegHasznalo.Size = new System.Drawing.Size(68, 16);
            this.labelKepessegHasznalo.TabIndex = 7;
            this.labelKepessegHasznalo.Text = "Használó:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(112, 138);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(243, 24);
            this.hasznaloComboBox.TabIndex = 8;
            this.hasznaloComboBox.SelectedIndexChanged += new System.EventHandler(this.hasznaloComboBox_SelectedIndexChanged);
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(112, 182);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(243, 22);
            this.kepessegNeveTextBox.TabIndex = 9;
            // 
            // labelKepessegNev
            // 
            this.labelKepessegNev.AutoSize = true;
            this.labelKepessegNev.Location = new System.Drawing.Point(24, 182);
            this.labelKepessegNev.Name = "labelKepessegNev";
            this.labelKepessegNev.Size = new System.Drawing.Size(36, 16);
            this.labelKepessegNev.TabIndex = 10;
            this.labelKepessegNev.Text = "Név:";
            // 
            // buttonKepessegLetrehozasa
            // 
            this.buttonKepessegLetrehozasa.Location = new System.Drawing.Point(27, 214);
            this.buttonKepessegLetrehozasa.Name = "buttonKepessegLetrehozasa";
            this.buttonKepessegLetrehozasa.Size = new System.Drawing.Size(114, 25);
            this.buttonKepessegLetrehozasa.TabIndex = 11;
            this.buttonKepessegLetrehozasa.Text = "Hozzáad";
            this.buttonKepessegLetrehozasa.UseVisualStyleBackColor = true;
            this.buttonKepessegLetrehozasa.Click += new System.EventHandler(this.buttonKepessegLetrehozasa_Click);
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(387, 132);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(293, 72);
            this.leirasTextBox.TabIndex = 12;
            // 
            // labelKepessegLeiras
            // 
            this.labelKepessegLeiras.AutoSize = true;
            this.labelKepessegLeiras.Location = new System.Drawing.Point(384, 101);
            this.labelKepessegLeiras.Name = "labelKepessegLeiras";
            this.labelKepessegLeiras.Size = new System.Drawing.Size(48, 16);
            this.labelKepessegLeiras.TabIndex = 13;
            this.labelKepessegLeiras.Text = "Leírás:";
            // 
            // labelHarcosok
            // 
            this.labelHarcosok.AutoSize = true;
            this.labelHarcosok.Location = new System.Drawing.Point(24, 277);
            this.labelHarcosok.Name = "labelHarcosok";
            this.labelHarcosok.Size = new System.Drawing.Size(70, 16);
            this.labelHarcosok.TabIndex = 14;
            this.labelHarcosok.Text = "Harcosok:";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.ItemHeight = 16;
            this.harcosokListBox.Location = new System.Drawing.Point(27, 302);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(150, 324);
            this.harcosokListBox.TabIndex = 15;
            this.harcosokListBox.SelectedIndexChanged += new System.EventHandler(this.harcosokListBox_SelectedIndexChanged);
            // 
            // labelKepessegei
            // 
            this.labelKepessegei.AutoSize = true;
            this.labelKepessegei.Location = new System.Drawing.Point(218, 277);
            this.labelKepessegei.Name = "labelKepessegei";
            this.labelKepessegei.Size = new System.Drawing.Size(84, 16);
            this.labelKepessegei.TabIndex = 16;
            this.labelKepessegei.Text = "Képességei:";
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.ItemHeight = 16;
            this.kepessegekListBox.Location = new System.Drawing.Point(221, 302);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(150, 324);
            this.kepessegekListBox.TabIndex = 17;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegekListBox_SelectedIndexChanged);
            // 
            // labelKepessegLeirasa
            // 
            this.labelKepessegLeirasa.AutoSize = true;
            this.labelKepessegLeirasa.Location = new System.Drawing.Point(426, 277);
            this.labelKepessegLeirasa.Name = "labelKepessegLeirasa";
            this.labelKepessegLeirasa.Size = new System.Drawing.Size(114, 16);
            this.labelKepessegLeirasa.TabIndex = 18;
            this.labelKepessegLeirasa.Text = "Képesség leírása";
            // 
            // kepessegLeirasaTextBox
            // 
            this.kepessegLeirasaTextBox.Location = new System.Drawing.Point(429, 302);
            this.kepessegLeirasaTextBox.Multiline = true;
            this.kepessegLeirasaTextBox.Name = "kepessegLeirasaTextBox";
            this.kepessegLeirasaTextBox.Size = new System.Drawing.Size(251, 104);
            this.kepessegLeirasaTextBox.TabIndex = 19;
            // 
            // buttonKepessegLeirasModosit
            // 
            this.buttonKepessegLeirasModosit.Location = new System.Drawing.Point(580, 421);
            this.buttonKepessegLeirasModosit.Name = "buttonKepessegLeirasModosit";
            this.buttonKepessegLeirasModosit.Size = new System.Drawing.Size(100, 25);
            this.buttonKepessegLeirasModosit.TabIndex = 20;
            this.buttonKepessegLeirasModosit.Text = "Módosít";
            this.buttonKepessegLeirasModosit.UseVisualStyleBackColor = true;
            this.buttonKepessegLeirasModosit.Click += new System.EventHandler(this.buttonKepessegLeirasModosit_Click);
            // 
            // buttonKepessegTorol
            // 
            this.buttonKepessegTorol.Location = new System.Drawing.Point(221, 644);
            this.buttonKepessegTorol.Name = "buttonKepessegTorol";
            this.buttonKepessegTorol.Size = new System.Drawing.Size(100, 25);
            this.buttonKepessegTorol.TabIndex = 21;
            this.buttonKepessegTorol.Text = "Törlés";
            this.buttonKepessegTorol.UseVisualStyleBackColor = true;
            this.buttonKepessegTorol.Click += new System.EventHandler(this.buttonKepessegTorol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 682);
            this.Controls.Add(this.buttonKepessegTorol);
            this.Controls.Add(this.buttonKepessegLeirasModosit);
            this.Controls.Add(this.kepessegLeirasaTextBox);
            this.Controls.Add(this.labelKepessegLeirasa);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.labelKepessegei);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.labelHarcosok);
            this.Controls.Add(this.labelKepessegLeiras);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.buttonKepessegLetrehozasa);
            this.Controls.Add(this.labelKepessegNev);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.labelKepessegHasznalo);
            this.Controls.Add(this.labelKepessegElvalaszto);
            this.Controls.Add(this.labelKepessegHozzaadasa);
            this.Controls.Add(this.labelHarcosElvalaszto);
            this.Controls.Add(this.labelHarcosNev);
            this.Controls.Add(this.labelHarcosLetrehozasa);
            this.Controls.Add(this.harcosNeveTextBox);
            this.Controls.Add(this.buttonHarcosLetrehozasa);
            this.Name = "Form1";
            this.Text = "Harcosok -- Csóti Zoltán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHarcosLetrehozasa;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Label labelHarcosLetrehozasa;
        private System.Windows.Forms.Label labelHarcosNev;
        private System.Windows.Forms.Label labelKepessegHozzaadasa;
        private System.Windows.Forms.Label labelHarcosElvalaszto;
        private System.Windows.Forms.Label labelKepessegElvalaszto;
        private System.Windows.Forms.Label labelKepessegHasznalo;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Label labelKepessegNev;
        private System.Windows.Forms.Button buttonKepessegLetrehozasa;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Label labelKepessegLeiras;
        private System.Windows.Forms.Label labelHarcosok;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.Label labelKepessegei;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.Label labelKepessegLeirasa;
        private System.Windows.Forms.TextBox kepessegLeirasaTextBox;
        private System.Windows.Forms.Button buttonKepessegLeirasModosit;
        private System.Windows.Forms.Button buttonKepessegTorol;
    }
}

