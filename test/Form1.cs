using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {

        // Set the COM1 serial port to speed = 4800 baud, parity = odd,
        // data bits = 8, stop bits = 1.
        SerialPort port = new SerialPort("COM3", 1200, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
            this.sendRead.Text = "Enter Commands or queries here";

            // set read time out to 2 seconds
            port.ReadTimeout = 2000;

            // open serial port
            port.Open();

            //Enable Event Handler
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void sendRead_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //write line to serial port
                port.WriteLine(sendRead.Text);

                //clear the text box
                sendRead.Text = "";
            }

            catch (System.Exception ex)
            {
                sendRead.Text = ex.Message;
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = port.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            //port.Read(byteBuffer, 0, intBuffer); //<--- YOU ARE READING (AND DISCARDING) DATA HERE
            this.Invoke(new EventHandler(DoUpDate));
        }

        private void DoUpDate(object s, EventArgs e)
        {
            //sendRead.Text = port.ReadLine(); //<--- YOU ARE TRYING TO READ AGAIN
            //sendRead.Text += port.ReadLine();
            rcvData.Text = port.ReadLine();
        }

        private void Form1_FromClosing(object sender, EventArgs e)
        {
            port.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

}
