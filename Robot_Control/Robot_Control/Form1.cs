using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;


namespace Robot_Control
{
    public partial class Robot_Main : Form
    {
        public static string RxString = "";
        public static string RyString = "";
        public static int Cont = 0, ContImp = 0;
        public static double[] Medidas = new double[50];
        public static string dirSalvar = "";
        public static int status = 0;
        public static int Conect_Status = 0;


        public Robot_Main()
        {
            InitializeComponent();
            TimerCom.Enabled    = true;
            timerBlocke.Enabled = true;

            TxbMaiorValor.Text  = " ---";
            TxbMenorValor.Text  = " ---";
            TxTRecebe.Text      = " ---";
            TxbRecorrente.Text  = " ---";

            BTMedirServo.Enabled = false;
            BTGrafico.Enabled    = false;
        }

        public  void Close_all ()
        {
            BTLead1.Enabled       = false;
            BTLead2.Enabled       = false;
            BTMotor1.Enabled      = false;
            BTMotor2.Enabled      = false;
         
            BTCentro.Enabled      = false;
            BTDireito.Enabled     = false;
            BTEsquerda.Enabled    = false;
            BTMedir.Enabled       = false;
            //BTMedirServo.Enabled  = false;
            //BTGrafico.Enabled     = false;
            BTMusic.Enabled       = false;
            TxbMaiorValor.Enabled = false;
            TxbMenorValor.Enabled = false;
            TxbRecorrente.Enabled = false;
            TxTRecebe.Enabled     = false;
            BTConectar.Focus();
        }
        public void Open_all()
        {
            BTLead1.Enabled       = true;
            BTLead2.Enabled       = true;
            BTMotor1.Enabled      = true;
            BTMotor2.Enabled      = true;
           
            BTCentro.Enabled      = true;
            BTDireito.Enabled     = true;
            BTEsquerda.Enabled    = true;
            BTMedir.Enabled       = true;
            //BTMedirServo.Enabled  = true;
            //BTGrafico.Enabled     = true;
            BTMusic.Enabled       = true;
            TxbMaiorValor.Enabled = true;
            TxbMenorValor.Enabled = true;
            TxbRecorrente.Enabled = true;
            TxTRecebe.Enabled     = true;
            BTConectar.Focus();
        }
        private void BTConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.BaudRate = 9600;
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                    Conect_Status = 1;
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    BTConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                    LB2.Visible = false;
                    LB3.Visible = true;
                    PB1.Visible = true;
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("P");
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    BTConectar.Text = "Conectar";
                    LB2.Visible = true;
                    LB3.Visible = false;
                    PB1.Visible = false;
                    Conect_Status = 0;
                }
                catch
                {
                    return;
                }
            }
        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- // 
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou
            i = 0;
            quantDiferente = false;
            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }
            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }
            //limpa comboBox
            comboBox1.Items.Clear();
            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch
            {
                comboBox1.Text = "Sem Portas";
                LB3.Visible = false;
                LB2.Visible = true;
                comboBox1.Enabled = true;
                BTConectar.Text = "Conectar";
            }
        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- // 
        public void serialPort1_DataReceived()
        {
            RxString = serialPort1.ReadLine();              //le o dado disponível na serial
     
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- // 
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            int i;
            double Soma = 0, Resultado = 0, Maior = 0, Menor = 0;

            double Medida = 0;
            try
            {
                //TxTRecebe.Text = " ---";
                //TxbMaiorValor.Text = " ---";
                try
                {
                    Medida = Convert.ToDouble(RxString);
                    Medidas[ContImp] = Medida/100; 
                    ContImp = ContImp + 1;
                }
                catch
                {
                    return;
                }

                if (RxString != "")
                {
                    RyString = RxString;
                   
                }
                TxbRecorrente.Text=RyString;
                RTBox.Text += "" + RyString;
                RTBox.ScrollToCaret();
                if (ContImp == 20)
                {
                    timerdistancia.Enabled = false;
                    RTBox.Text = "";
                    ContImp = 0;
                    Maior = Medidas[0];
                    Menor = Medidas[0];
                    RTBox.Text += "\n =================== \n";
                    for (i=0; i<20; i++)
                    {
                        RTBox.Text += " [" + (i+1) + "] = " + Medidas[i] + "\n";
                        Program.Med[i] = Medidas[i];
                        Soma = Soma + Medidas[i];


                        if (Maior < Medidas[i])
                        {
                            Maior = Medidas[i];
                        }

                        if (Menor > Medidas[i])
                        {
                            Menor = Medidas[i];
                        }
                    }
                    RTBox.Text += " =================== \n";
                    Resultado = Soma / 20;
                    TxTRecebe.Text = Convert.ToString(Resultado);
                    TxbMaiorValor.Text = Convert.ToString(Maior);
                    TxbMenorValor.Text = Convert.ToString(Menor);
                    Program.Maior = Convert.ToInt32(Maior);
                    Program.Menor = Convert.ToInt32(Menor);
                    TxbRecorrente.Text = " ---";
                    RTBox.Text += " Maior valor: " + TxbMaiorValor.Text + " \n";
                    RTBox.Text += " Menor valor: " + TxbMenorValor.Text + " \n";
                    RTBox.Text += " Resultado  : " + TxTRecebe.Text + " \n";
                    RxString = "";
                    RTBox.Text += " =================== \n";
                    RTBox.ScrollToCaret();
                    Open_all();
                    BTMedirServo.Enabled = true;
                    BTGrafico.Enabled    = true;
                }
                else
                {
                    serialPort1.WriteLine("H");
                    timerdistancia.Enabled = true;
                }
            }
            catch
            {
                TxTRecebe.Text = "Error!";
                RTBox.Text = "";
                RTBox.Text = "Error!\n";
                // timerdistancia.Enabled = false;
                RTBox.ScrollToCaret();
                Open_all();
            }
        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- //
        private void timerdistancia_Tick(object sender, EventArgs e)
        {
            try
            {
                serialPort1_DataReceived();
            }
            catch
            {
                TxTRecebe.Text = "Error!";
                RTBox.Text = "";
                RTBox.Text = "Error!\n";
                //timerdistancia.Enabled = false;
            }
        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- //
        private void TimerCom_Tick_1(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- //
        private void BTLead1_Click(object sender, EventArgs e)
        {
            BTLead1.Focus();
            try
            {
                status = 1; 
                serialPort1.WriteLine("A");
            }
            catch
            {
                LB2.Visible = true;
            }
        }
        private void BTLead2_Click(object sender, EventArgs e)
        {
            BTLead2.Focus();
            try
            {
                status = 2;
                serialPort1.WriteLine("B");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTMotor1_Click(object sender, EventArgs e)
        {
            BTMotor1.Focus();
            try
            {
                status = 1;
                serialPort1.WriteLine("E");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTMotor2_Click(object sender, EventArgs e)
        {
            BTMotor2.Focus();
            try
            {
                status = 2;
                serialPort1.WriteLine("F");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

       

        private void BTIniciar_Click(object sender, EventArgs e)
        {
            
            try
            {
                serialPort1.WriteLine("G");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTMedir_Click(object sender, EventArgs e)
        {
            try
            {
                Close_all();
                serialPort1.WriteLine("H"); 
                timerdistancia.Enabled = true;
                RTBox.Text = "";
                TxbMaiorValor.Text = " ---";
                TxbMenorValor.Text = " ---";
                TxTRecebe.Text     = " ---";
                TxbRecorrente.Enabled = true;
                BTMedirServo.Enabled = true;
                BTGrafico.Enabled    = true;
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTMedirServo_Click(object sender, EventArgs e)
        {
            try
            {
                dirSalvar = "";
                sfdSalvar.FileName = "Resultado";
                sfdSalvar.Title = "Salvar Documento"; //Adicionamos um titulo a janela de salvar
                sfdSalvar.Filter = "Documentos de texto (*.txt)|*.txt|Todos os arquivos|*.*"; //Adicionamos as extensões que serão salvas, .txt e .html
                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                // Se o resultado da caixa de dialogo for igual a Ok, retorna true e entra no IF
                {
                    dirSalvar = sfdSalvar.FileName;//FileName retorna o diretório, este valor adicionamos dentro da variável dirSalvar (c:/index.html, c:/texto.txt).
                    StreamWriter streamWriter = new StreamWriter(dirSalvar); //Instanciamos um novo objeto para escrita, passamos o diretório e arquivo que será escrito.
                    streamWriter.WriteLine(RTBox.Text); // Gravamos o valor no arquivo.
                    streamWriter.Close(); // Fechamos a conexão com o arquivo.
                }
            }
            catch
            {
                MessageBox.Show(" Não é possivel salvar", "Robot Control", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void BTGrafico_Click(object sender, EventArgs e)
        {
            Gráfico X = new Gráfico();
            X.Show();
        }

        private void BTMusic_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("K");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTDireito_Click(object sender, EventArgs e)
        {
            BTDireito.Focus();
            try
            {
                status = 3;
                serialPort1.WriteLine("L");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTCentro_Click(object sender, EventArgs e)
        {
            BTCentro.Focus();
            try
            {
                status = 3;
                serialPort1.WriteLine("M");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void BTEsquerda_Click(object sender, EventArgs e)
        {
            BTEsquerda.Focus();
            try
            {
                status = 3;
                serialPort1.WriteLine("N");
            }
            catch
            {
                LB2.Visible = true;
            }
        }

        private void timerBlocke_Tick(object sender, EventArgs e)
        {
            if (Conect_Status == 1)
            {
                if (status == 1)
                {
                    Close_all();
                    System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(10000));
                    Open_all();
                    status = 0;
                }
                if (status == 2)
                {
                    Close_all();
                    System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(5000));
                    Open_all();
                    status = 0;
                }
                if (status == 3)
                {
                    Close_all();
                    System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(100));
                    Open_all();
                    status = 0;
                }
            }
           
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            BTMedir.Focus();
        }

        private void TxbRecorrente_MouseClick(object sender, MouseEventArgs e)
        {
            BTMedir.Focus();
        }

        private void Robot_Main_Load(object sender, EventArgs e)
        {

        }
        // ---------------------------------------------------- // 
        // ---------------------------------------------------- //
    }
}
