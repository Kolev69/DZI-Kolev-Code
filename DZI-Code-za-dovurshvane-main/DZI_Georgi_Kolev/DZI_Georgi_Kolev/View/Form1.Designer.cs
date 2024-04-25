namespace DZI_Georgi_Kolev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рожденДенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.частноПартиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктиСтокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алкохолToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безалкохолноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактиИРезервацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.участияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kontakti1 = new DZI_Georgi_Kolev.Kontakti();
            this.ceni1 = new DZI_Georgi_Kolev.Presenter.Ceni();
            this.produktiStoki1 = new DZI_Georgi_Kolev.Presenter.ProduktiStoki();
            this.registraciq1 = new DZI_Georgi_Kolev.Presenter.Registraciq();
            this.reservacii1 = new DZI_Georgi_Kolev.Presenter.Reservacii();
            this.uchastiq1 = new DZI_Georgi_Kolev.Presenter.Uchastiq();
            this.uslugi1 = new DZI_Georgi_Kolev.Presenter.Uslugi();
            this.za_nas1 = new DZI_Georgi_Kolev.Presenter.Za_nas();
            this.vhod1 = new DZI_Georgi_Kolev.Vhod();
            this.bezalkoholno1 = new DZI_Georgi_Kolev.Presenter.Bezalkoholno();
            this.uslugi21 = new DZI_Georgi_Kolev.Presenter.Uslugi2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заНасToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.цениToolStripMenuItem,
            this.продуктиСтокиToolStripMenuItem,
            this.контактиИРезервацииToolStripMenuItem,
            this.участияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(662, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // заНасToolStripMenuItem
            // 
            this.заНасToolStripMenuItem.Name = "заНасToolStripMenuItem";
            this.заНасToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.заНасToolStripMenuItem.Text = "За нас";
            this.заНасToolStripMenuItem.Click += new System.EventHandler(this.заНасToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рожденДенToolStripMenuItem,
            this.частноПартиToolStripMenuItem});
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // рожденДенToolStripMenuItem
            // 
            this.рожденДенToolStripMenuItem.Name = "рожденДенToolStripMenuItem";
            this.рожденДенToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.рожденДенToolStripMenuItem.Text = "Рожден ден";
            this.рожденДенToolStripMenuItem.Click += new System.EventHandler(this.рожденДенToolStripMenuItem_Click);
            // 
            // частноПартиToolStripMenuItem
            // 
            this.частноПартиToolStripMenuItem.Name = "частноПартиToolStripMenuItem";
            this.частноПартиToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.частноПартиToolStripMenuItem.Text = "Частно парти";
            this.частноПартиToolStripMenuItem.Click += new System.EventHandler(this.частноПартиToolStripMenuItem_Click);
            // 
            // цениToolStripMenuItem
            // 
            this.цениToolStripMenuItem.Name = "цениToolStripMenuItem";
            this.цениToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.цениToolStripMenuItem.Text = "Цени";
            this.цениToolStripMenuItem.Click += new System.EventHandler(this.цениToolStripMenuItem_Click);
            // 
            // продуктиСтокиToolStripMenuItem
            // 
            this.продуктиСтокиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алкохолToolStripMenuItem,
            this.безалкохолноToolStripMenuItem});
            this.продуктиСтокиToolStripMenuItem.Name = "продуктиСтокиToolStripMenuItem";
            this.продуктиСтокиToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.продуктиСтокиToolStripMenuItem.Text = "Продукти/Стоки";
            this.продуктиСтокиToolStripMenuItem.Click += new System.EventHandler(this.продуктиСтокиToolStripMenuItem_Click);
            // 
            // алкохолToolStripMenuItem
            // 
            this.алкохолToolStripMenuItem.Name = "алкохолToolStripMenuItem";
            this.алкохолToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.алкохолToolStripMenuItem.Text = "Алкохол";
            this.алкохолToolStripMenuItem.Click += new System.EventHandler(this.алкохолToolStripMenuItem_Click);
            // 
            // безалкохолноToolStripMenuItem
            // 
            this.безалкохолноToolStripMenuItem.Name = "безалкохолноToolStripMenuItem";
            this.безалкохолноToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.безалкохолноToolStripMenuItem.Text = "Безалкохолно";
            this.безалкохолноToolStripMenuItem.Click += new System.EventHandler(this.безалкохолноToolStripMenuItem_Click);
            // 
            // контактиИРезервацииToolStripMenuItem
            // 
            this.контактиИРезервацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контактиToolStripMenuItem,
            this.резервацииToolStripMenuItem});
            this.контактиИРезервацииToolStripMenuItem.Name = "контактиИРезервацииToolStripMenuItem";
            this.контактиИРезервацииToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.контактиИРезервацииToolStripMenuItem.Text = "Контакти и резервации";
            this.контактиИРезервацииToolStripMenuItem.Click += new System.EventHandler(this.контактиИРезервацииToolStripMenuItem_Click);
            // 
            // контактиToolStripMenuItem
            // 
            this.контактиToolStripMenuItem.Name = "контактиToolStripMenuItem";
            this.контактиToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.контактиToolStripMenuItem.Text = "Контакти";
            this.контактиToolStripMenuItem.Click += new System.EventHandler(this.контактиToolStripMenuItem_Click);
            // 
            // резервацииToolStripMenuItem
            // 
            this.резервацииToolStripMenuItem.Name = "резервацииToolStripMenuItem";
            this.резервацииToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.резервацииToolStripMenuItem.Text = "Резервации";
            this.резервацииToolStripMenuItem.Click += new System.EventHandler(this.резервацииToolStripMenuItem_Click);
            // 
            // участияToolStripMenuItem
            // 
            this.участияToolStripMenuItem.Name = "участияToolStripMenuItem";
            this.участияToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.участияToolStripMenuItem.Text = "Участия";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(104)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(424, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(104)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(538, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // kontakti1
            // 
            this.kontakti1.BackColor = System.Drawing.Color.White;
            this.kontakti1.Location = new System.Drawing.Point(2, 32);
            this.kontakti1.Name = "kontakti1";
            this.kontakti1.Size = new System.Drawing.Size(661, 418);
            this.kontakti1.TabIndex = 4;
            this.kontakti1.Load += new System.EventHandler(this.kontakti1_Load);
            // 
            // ceni1
            // 
            this.ceni1.Location = new System.Drawing.Point(0, 32);
            this.ceni1.Name = "ceni1";
            this.ceni1.Size = new System.Drawing.Size(661, 418);
            this.ceni1.TabIndex = 5;
            // 
            // produktiStoki1
            // 
            this.produktiStoki1.BackColor = System.Drawing.Color.White;
            this.produktiStoki1.Location = new System.Drawing.Point(0, 33);
            this.produktiStoki1.Name = "produktiStoki1";
            this.produktiStoki1.Size = new System.Drawing.Size(661, 418);
            this.produktiStoki1.TabIndex = 6;
            // 
            // registraciq1
            // 
            this.registraciq1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registraciq1.Location = new System.Drawing.Point(2, 33);
            this.registraciq1.Name = "registraciq1";
            this.registraciq1.Size = new System.Drawing.Size(661, 418);
            this.registraciq1.TabIndex = 7;
            // 
            // reservacii1
            // 
            this.reservacii1.BackColor = System.Drawing.Color.White;
            this.reservacii1.Location = new System.Drawing.Point(0, 32);
            this.reservacii1.Name = "reservacii1";
            this.reservacii1.Size = new System.Drawing.Size(661, 418);
            this.reservacii1.TabIndex = 8;
            // 
            // uchastiq1
            // 
            this.uchastiq1.BackColor = System.Drawing.Color.White;
            this.uchastiq1.Location = new System.Drawing.Point(2, 33);
            this.uchastiq1.Name = "uchastiq1";
            this.uchastiq1.Size = new System.Drawing.Size(661, 418);
            this.uchastiq1.TabIndex = 9;
            // 
            // uslugi1
            // 
            this.uslugi1.Location = new System.Drawing.Point(2, 33);
            this.uslugi1.Name = "uslugi1";
            this.uslugi1.Size = new System.Drawing.Size(661, 418);
            this.uslugi1.TabIndex = 10;
            // 
            // za_nas1
            // 
            this.za_nas1.Location = new System.Drawing.Point(2, 32);
            this.za_nas1.Name = "za_nas1";
            this.za_nas1.Size = new System.Drawing.Size(661, 418);
            this.za_nas1.TabIndex = 11;
            // 
            // vhod1
            // 
            this.vhod1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vhod1.Location = new System.Drawing.Point(2, 32);
            this.vhod1.Name = "vhod1";
            this.vhod1.Size = new System.Drawing.Size(661, 418);
            this.vhod1.TabIndex = 12;
            // 
            // bezalkoholno1
            // 
            this.bezalkoholno1.BackColor = System.Drawing.Color.White;
            this.bezalkoholno1.Location = new System.Drawing.Point(0, 33);
            this.bezalkoholno1.Name = "bezalkoholno1";
            this.bezalkoholno1.Size = new System.Drawing.Size(661, 418);
            this.bezalkoholno1.TabIndex = 13;
            // 
            // uslugi21
            // 
            this.uslugi21.Location = new System.Drawing.Point(0, 33);
            this.uslugi21.Name = "uslugi21";
            this.uslugi21.Size = new System.Drawing.Size(662, 417);
            this.uslugi21.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kontakti1);
            this.Controls.Add(this.ceni1);
            this.Controls.Add(this.produktiStoki1);
            this.Controls.Add(this.registraciq1);
            this.Controls.Add(this.reservacii1);
            this.Controls.Add(this.uchastiq1);
            this.Controls.Add(this.uslugi1);
            this.Controls.Add(this.za_nas1);
            this.Controls.Add(this.vhod1);
            this.Controls.Add(this.bezalkoholno1);
            this.Controls.Add(this.uslugi21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктиСтокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактиИРезервацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem участияToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem рожденДенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem частноПартиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алкохолToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безалкохолноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервацииToolStripMenuItem;
        private Kontakti kontakti1;
        private Presenter.Ceni ceni1;
        private Presenter.ProduktiStoki produktiStoki1;
        private Presenter.Registraciq registraciq1;
        private Presenter.Reservacii reservacii1;
        private Presenter.Uchastiq uchastiq1;
        private Presenter.Uslugi uslugi1;
        private Presenter.Za_nas za_nas1;
        private Vhod vhod1;
        private Presenter.Bezalkoholno bezalkoholno1;
        private Presenter.Uslugi2 uslugi21;
    }
}

