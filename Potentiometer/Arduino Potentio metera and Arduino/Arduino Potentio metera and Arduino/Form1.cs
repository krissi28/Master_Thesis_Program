namespace Arduino_Potentio_metera_and_Arduino
{
    using System;
    using System.Windows.Forms;
    using System.IO.Ports;
    public partial class Form1 : Form
    {
        bool READ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_On_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Start Reading value from Arduino");
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM4";
            myport.Open();

            /* while (true)
             {
                 Btn_On.Enabled = false;
                 Btn_Off.Enabled = true;

             }*/
            var form2 = new Form2(); // Make new form when connected to arduino
            form2.Show();
            Btn_On.Enabled = false;
            Btn_Off.Enabled = true;
        }

        private void Btn_Off_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stop Reading Value from Arduino");
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM4";
            myport.Close();
            Btn_On.Enabled = true;
            Btn_Off.Enabled = false;
        }
    }
}
