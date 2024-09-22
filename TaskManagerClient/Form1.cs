using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TaskManagerClient
{
    public partial class Form1 : Form
    {
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        private string serverIP = "127.0.0.1";

        public Form1()
        {

            InitializeComponent();
        }



        private void btnGetProcesses_Click(object sender, EventArgs e)
        {
            try
            {
                writer.WriteLine("GET");  
                string jsonResponse = reader.ReadLine();  
                JArray processes = JArray.Parse(jsonResponse);  
                txtOutput.Clear();
                foreach (var process in processes)
                {
                    txtOutput.AppendText($"ID: {process["Id"]} - Name: {process["Name"]}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                writer.WriteLine("delete");  
                MessageBox.Show("All proccess ended.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRunProcess_Click(object sender, EventArgs e)
        {
            try
            {
                writer.WriteLine("get");
                string response = "get";
                JArray processes = JArray.Parse(response);
                txtOutput.Text = string.Join(Environment.NewLine, processes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string ipAddress = serverIP;
                    client = new TcpClient(ipAddress, 8888); 
                    NetworkStream stream = client.GetStream();

                    writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
                    reader = new StreamReader(stream, Encoding.UTF8);

                    MessageBox.Show("Joined Successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(": " + ex.Message);
                }
            
        }
    }
}
