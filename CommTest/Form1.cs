using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SerialPort port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);

            byte[] ToSend = new byte[] {(byte)'H', (byte)'E', (byte)'L', (byte)'L', (byte)'O', };

            String ToSendStr = System.Text.Encoding.UTF8.GetString(ToSend, 0, ToSend.Length);

            port.Open();
            port.Write(ToSendStr);
            port.Close();
            
        }
    }
}
