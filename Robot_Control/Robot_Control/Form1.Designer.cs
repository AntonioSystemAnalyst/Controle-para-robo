namespace Robot_Control
{
    partial class Robot_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot_Main));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.LB3 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.BTConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TimerCom = new System.Windows.Forms.Timer(this.components);
            this.RTBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTMotor2 = new System.Windows.Forms.Button();
            this.BTMotor1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTLead1 = new System.Windows.Forms.Button();
            this.BTLead2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BTCentro = new System.Windows.Forms.Button();
            this.BTEsquerda = new System.Windows.Forms.Button();
            this.BTDireito = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbMenorValor = new System.Windows.Forms.TextBox();
            this.TxbMaiorValor = new System.Windows.Forms.TextBox();
            this.TxTRecebe = new System.Windows.Forms.TextBox();
            this.TxbRecorrente = new System.Windows.Forms.TextBox();
            this.BTGrafico = new System.Windows.Forms.Button();
            this.BTMedirServo = new System.Windows.Forms.Button();
            this.BTMedir = new System.Windows.Forms.Button();
            this.timerdistancia = new System.Windows.Forms.Timer(this.components);
            this.sfdSalvar = new System.Windows.Forms.SaveFileDialog();
            this.BTMusic = new System.Windows.Forms.Button();
            this.timerBlocke = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PB1);
            this.groupBox2.Controls.Add(this.PB2);
            this.groupBox2.Controls.Add(this.LB3);
            this.groupBox2.Controls.Add(this.LB2);
            this.groupBox2.Controls.Add(this.BTConectar);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // PB1
            // 
            this.PB1.Image = global::Robot_Control.Properties.Resources.Red_icon;
            this.PB1.Location = new System.Drawing.Point(213, 13);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(44, 31);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 10;
            this.PB1.TabStop = false;
            this.PB1.Visible = false;
            // 
            // PB2
            // 
            this.PB2.Image = global::Robot_Control.Properties.Resources.Yellow_icon;
            this.PB2.Location = new System.Drawing.Point(214, 13);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(44, 31);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB2.TabIndex = 11;
            this.PB2.TabStop = false;
            // 
            // LB3
            // 
            this.LB3.AutoSize = true;
            this.LB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB3.Location = new System.Drawing.Point(22, 47);
            this.LB3.Name = "LB3";
            this.LB3.Size = new System.Drawing.Size(84, 13);
            this.LB3.TabIndex = 10;
            this.LB3.Text = "Conectado !!!";
            this.LB3.Visible = false;
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB2.Location = new System.Drawing.Point(19, 48);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(110, 13);
            this.LB2.TabIndex = 8;
            this.LB2.Text = "Não conectado !!!";
            // 
            // BTConectar
            // 
            this.BTConectar.Location = new System.Drawing.Point(7, 14);
            this.BTConectar.Name = "BTConectar";
            this.BTConectar.Size = new System.Drawing.Size(75, 23);
            this.BTConectar.TabIndex = 4;
            this.BTConectar.Text = "Conectar";
            this.BTConectar.UseVisualStyleBackColor = true;
            this.BTConectar.Click += new System.EventHandler(this.BTConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // TimerCom
            // 
            this.TimerCom.Tick += new System.EventHandler(this.TimerCom_Tick_1);
            // 
            // RTBox
            // 
            this.RTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBox.Location = new System.Drawing.Point(6, 16);
            this.RTBox.Name = "RTBox";
            this.RTBox.ReadOnly = true;
            this.RTBox.Size = new System.Drawing.Size(251, 123);
            this.RTBox.TabIndex = 11;
            this.RTBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RTBox);
            this.groupBox1.Location = new System.Drawing.Point(214, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 145);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor";
            // 
            // BTMotor2
            // 
            this.BTMotor2.Location = new System.Drawing.Point(87, 19);
            this.BTMotor2.Name = "BTMotor2";
            this.BTMotor2.Size = new System.Drawing.Size(75, 61);
            this.BTMotor2.TabIndex = 13;
            this.BTMotor2.Text = "Motor 2";
            this.BTMotor2.UseVisualStyleBackColor = true;
            this.BTMotor2.Click += new System.EventHandler(this.BTMotor2_Click);
            // 
            // BTMotor1
            // 
            this.BTMotor1.Location = new System.Drawing.Point(6, 19);
            this.BTMotor1.Name = "BTMotor1";
            this.BTMotor1.Size = new System.Drawing.Size(75, 61);
            this.BTMotor1.TabIndex = 14;
            this.BTMotor1.Text = "Motor 1";
            this.BTMotor1.UseVisualStyleBackColor = true;
            this.BTMotor1.Click += new System.EventHandler(this.BTMotor1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTMotor1);
            this.groupBox3.Controls.Add(this.BTMotor2);
            this.groupBox3.Location = new System.Drawing.Point(12, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 97);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motores";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTLead1);
            this.groupBox4.Controls.Add(this.BTLead2);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 63);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LEDs";
            // 
            // BTLead1
            // 
            this.BTLead1.Location = new System.Drawing.Point(8, 21);
            this.BTLead1.Name = "BTLead1";
            this.BTLead1.Size = new System.Drawing.Size(75, 23);
            this.BTLead1.TabIndex = 16;
            this.BTLead1.Text = "LEDs 1";
            this.BTLead1.UseVisualStyleBackColor = true;
            this.BTLead1.Click += new System.EventHandler(this.BTLead1_Click);
            // 
            // BTLead2
            // 
            this.BTLead2.Location = new System.Drawing.Point(89, 21);
            this.BTLead2.Name = "BTLead2";
            this.BTLead2.Size = new System.Drawing.Size(75, 23);
            this.BTLead2.TabIndex = 15;
            this.BTLead2.Text = "LEDs 2";
            this.BTLead2.UseVisualStyleBackColor = true;
            this.BTLead2.Click += new System.EventHandler(this.BTLead2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTCentro);
            this.groupBox5.Controls.Add(this.BTEsquerda);
            this.groupBox5.Controls.Add(this.BTDireito);
            this.groupBox5.Location = new System.Drawing.Point(12, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 61);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Servo";
            // 
            // BTCentro
            // 
            this.BTCentro.Location = new System.Drawing.Point(67, 23);
            this.BTCentro.Name = "BTCentro";
            this.BTCentro.Size = new System.Drawing.Size(49, 23);
            this.BTCentro.TabIndex = 23;
            this.BTCentro.Text = "Centro";
            this.BTCentro.UseVisualStyleBackColor = true;
            this.BTCentro.Click += new System.EventHandler(this.BTCentro_Click);
            // 
            // BTEsquerda
            // 
            this.BTEsquerda.Location = new System.Drawing.Point(122, 23);
            this.BTEsquerda.Name = "BTEsquerda";
            this.BTEsquerda.Size = new System.Drawing.Size(49, 23);
            this.BTEsquerda.TabIndex = 23;
            this.BTEsquerda.Text = "Direita";
            this.BTEsquerda.UseVisualStyleBackColor = true;
            this.BTEsquerda.Click += new System.EventHandler(this.BTEsquerda_Click);
            // 
            // BTDireito
            // 
            this.BTDireito.Location = new System.Drawing.Point(8, 23);
            this.BTDireito.Name = "BTDireito";
            this.BTDireito.Size = new System.Drawing.Size(49, 23);
            this.BTDireito.TabIndex = 22;
            this.BTDireito.Text = "Esqerda";
            this.BTDireito.UseVisualStyleBackColor = true;
            this.BTDireito.Click += new System.EventHandler(this.BTDireito_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.TxbMenorValor);
            this.groupBox6.Controls.Add(this.TxbMaiorValor);
            this.groupBox6.Controls.Add(this.TxTRecebe);
            this.groupBox6.Controls.Add(this.TxbRecorrente);
            this.groupBox6.Controls.Add(this.BTGrafico);
            this.groupBox6.Controls.Add(this.BTMedirServo);
            this.groupBox6.Controls.Add(this.BTMedir);
            this.groupBox6.Location = new System.Drawing.Point(12, 251);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(368, 100);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Senor Ultrasonic";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Corrente  (cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Resultado  (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Menor valor (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Maior valor  (cm)";
            // 
            // TxbMenorValor
            // 
            this.TxbMenorValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxbMenorValor.Location = new System.Drawing.Point(247, 69);
            this.TxbMenorValor.Name = "TxbMenorValor";
            this.TxbMenorValor.ReadOnly = true;
            this.TxbMenorValor.Size = new System.Drawing.Size(100, 20);
            this.TxbMenorValor.TabIndex = 28;
            this.TxbMenorValor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxbRecorrente_MouseClick);
            // 
            // TxbMaiorValor
            // 
            this.TxbMaiorValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxbMaiorValor.Location = new System.Drawing.Point(247, 27);
            this.TxbMaiorValor.Name = "TxbMaiorValor";
            this.TxbMaiorValor.ReadOnly = true;
            this.TxbMaiorValor.Size = new System.Drawing.Size(100, 20);
            this.TxbMaiorValor.TabIndex = 27;
            this.TxbMaiorValor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxbRecorrente_MouseClick);
            // 
            // TxTRecebe
            // 
            this.TxTRecebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxTRecebe.Location = new System.Drawing.Point(117, 69);
            this.TxTRecebe.Name = "TxTRecebe";
            this.TxTRecebe.ReadOnly = true;
            this.TxTRecebe.Size = new System.Drawing.Size(100, 20);
            this.TxTRecebe.TabIndex = 26;
            this.TxTRecebe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxbRecorrente_MouseClick);
            // 
            // TxbRecorrente
            // 
            this.TxbRecorrente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxbRecorrente.Location = new System.Drawing.Point(117, 27);
            this.TxbRecorrente.Name = "TxbRecorrente";
            this.TxbRecorrente.ReadOnly = true;
            this.TxbRecorrente.Size = new System.Drawing.Size(100, 20);
            this.TxbRecorrente.TabIndex = 25;
            this.TxbRecorrente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxbRecorrente_MouseClick);
            // 
            // BTGrafico
            // 
            this.BTGrafico.Location = new System.Drawing.Point(8, 68);
            this.BTGrafico.Name = "BTGrafico";
            this.BTGrafico.Size = new System.Drawing.Size(75, 23);
            this.BTGrafico.TabIndex = 24;
            this.BTGrafico.Text = "Gráfico";
            this.BTGrafico.UseVisualStyleBackColor = true;
            this.BTGrafico.Click += new System.EventHandler(this.BTGrafico_Click);
            // 
            // BTMedirServo
            // 
            this.BTMedirServo.Location = new System.Drawing.Point(8, 42);
            this.BTMedirServo.Name = "BTMedirServo";
            this.BTMedirServo.Size = new System.Drawing.Size(75, 23);
            this.BTMedirServo.TabIndex = 23;
            this.BTMedirServo.Text = "Salvar";
            this.BTMedirServo.UseVisualStyleBackColor = true;
            this.BTMedirServo.Click += new System.EventHandler(this.BTMedirServo_Click);
            // 
            // BTMedir
            // 
            this.BTMedir.Location = new System.Drawing.Point(8, 17);
            this.BTMedir.Name = "BTMedir";
            this.BTMedir.Size = new System.Drawing.Size(75, 23);
            this.BTMedir.TabIndex = 22;
            this.BTMedir.Text = "Medir";
            this.BTMedir.UseVisualStyleBackColor = true;
            this.BTMedir.Click += new System.EventHandler(this.BTMedir_Click);
            // 
            // timerdistancia
            // 
            this.timerdistancia.Tick += new System.EventHandler(this.timerdistancia_Tick);
            // 
            // sfdSalvar
            // 
            this.sfdSalvar.FileName = "Pesquisa";
            // 
            // BTMusic
            // 
            this.BTMusic.Image = global::Robot_Control.Properties.Resources.Star_Wars;
            this.BTMusic.Location = new System.Drawing.Point(383, 254);
            this.BTMusic.Name = "BTMusic";
            this.BTMusic.Size = new System.Drawing.Size(100, 100);
            this.BTMusic.TabIndex = 19;
            this.BTMusic.UseVisualStyleBackColor = true;
            this.BTMusic.Click += new System.EventHandler(this.BTMusic_Click);
            // 
            // timerBlocke
            // 
            this.timerBlocke.Interval = 10;
            this.timerBlocke.Tick += new System.EventHandler(this.timerBlocke_Tick);
            // 
            // Robot_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(486, 363);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BTMusic);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Robot_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Control - Orphew Algorithms";
            this.Load += new System.EventHandler(this.Robot_Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB3;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Button BTConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer TimerCom;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.RichTextBox RTBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTMotor2;
        private System.Windows.Forms.Button BTMotor1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTLead1;
        private System.Windows.Forms.Button BTLead2;
        private System.Windows.Forms.Button BTMusic;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbMenorValor;
        private System.Windows.Forms.TextBox TxbMaiorValor;
        private System.Windows.Forms.TextBox TxTRecebe;
        private System.Windows.Forms.TextBox TxbRecorrente;
        private System.Windows.Forms.Button BTGrafico;
        private System.Windows.Forms.Button BTMedirServo;
        private System.Windows.Forms.Button BTMedir;
        private System.Windows.Forms.Timer timerdistancia;
        private System.Windows.Forms.Button BTCentro;
        private System.Windows.Forms.Button BTEsquerda;
        private System.Windows.Forms.Button BTDireito;
        private System.Windows.Forms.SaveFileDialog sfdSalvar;
        private System.Windows.Forms.Timer timerBlocke;
    }
}

