using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTester
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        private delegate void SetTextDeleg(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            var port = portName.Text;
            var baudrate = int.Parse(BaudRate.Text);
            var databit = int.Parse(DataBits.Text);
            _serialPort = new SerialPort(port, baudrate, Parity.None, databit, StopBits.One);

            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();

            if (_serialPort.IsOpen)
            {
                Connect.Enabled = false;
                Disconect.Enabled = true;
                groupBox2.Enabled = true;
            }

        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            string data = _serialPort.ReadLine();
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }

        private void si_DataReceived(string data)
        {
            reciveTxt.Text = data.Trim();
        }

        private void Disconect_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            if (!_serialPort.IsOpen)
            {
                Connect.Enabled = true;
                Disconect.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void sendTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Write("c\r\n");
            _serialPort.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write(sendTxt.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void mSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write("o\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void cSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write("c\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void tSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write("t\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void openClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(interval.Text);
            timer1.Start();
            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write("o\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write("c\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }

            timer1.Stop();

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmer: Ali Ramezani\n www.aliram.ir");
        }
    }
}
