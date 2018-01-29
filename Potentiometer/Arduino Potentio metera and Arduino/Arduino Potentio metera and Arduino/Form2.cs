namespace Arduino_Potentio_metera_and_Arduino
{
    using System;
    using System.Windows.Forms;

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /* ------  For Switch 1 in Relay box*/
        private void SW1_ON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW1"); // Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000); // Is 1 sec delay
            Console.WriteLine("On"); // Turn the Relay On since the connection is normally open
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
            string Data = Console.ReadLine();
            if(Data == "On")
            {
                SW1_Fig.Image = Properties.Resources.Bulb_On;
            }
            else
            {
                SW1_Fig.Image = Properties.Resources.Bulb_Off;
            }            
        }

        private void SW1_OFF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW1");// Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("Off");// Turn the Relay Off since the connection is normally open
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }
        /* ----------------------------------*/

        /* ------  For Switch 2 in Relay box*/
        private void SW2_ON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW2"); // Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("On"); // Turn the Relay On since the connection is normally open
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }

        private void SW2_OFF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW2");// Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("Off");// Turn the Relay Off since the connection is normally open
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }
        /* ----------------------------------*/


        /* ------  For Switch 3 in Relay box*/
        private void SW3_ON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW3"); // Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("On"); // Turn the Relay On since the connection is normally open
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }

        private void SW3_OFF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW3");// Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("Off");// Turn the Relay Off since the connection is normally open
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }
        /* ----------------------------------*/



        /* ------  For Switch 4 in Relay box*/
        private void SW4_ON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW4"); // Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("On"); // Turn the Relay On since the connection is normally closed
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }

        private void SW4_OFF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SW4");// Initialize that SW1 is what is talking about
            System.Threading.Thread.Sleep(1000);// Is 1 sec delay
            Console.WriteLine("Off");// Turn the Relay Off since the connection is normally closed
            System.Threading.Thread.Sleep(500);// Is 500 ms delay
        }
        /* ----------------------------------*/
    }
}
