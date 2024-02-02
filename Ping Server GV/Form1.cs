using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Ping_Server_GV
{
    public partial class Form1 : Form
    {
        #region variables
        Image gArrow = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:assets/green arrow.png")));
        Image rArrow = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:assets/red arrow.png")));
        string adress,roundtrip,ttl,df,buffer,nombre,jsonPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:assets/adress.json"));
        int _ticks;
        bool _check = true;
        #endregion
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(jsonPath))
            {
                try
                {
                    string json = sr.ReadToEnd();
                    var table = JsonConvert.DeserializeObject<List<Adress>>(json);
                    if (json.Contains(txtNombre.Text) || json.Contains(txtAdrs.Text))
                    {
                        var newJson = JsonConvert.SerializeObject(table.Where(i => (i.nombre != txtNombre.Text) && (i.direccion != txtAdrs.Text)), Formatting.Indented);
                        timer1.Stop();
                        sr.Close();
                        File.WriteAllText(jsonPath, newJson);
                        timer1.Start();
                        txtAdrs.Clear();
                        txtNombre.Clear();
                        MessageBox.Show("Se eliminó una dirección!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Esta dirección no forma parte del registro\nFavor de revisarla", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception){ throw; }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_check)
            {
                MessageBox.Show("El monitoreo será detenido");
                _check = false;
                timer1.Stop();
                this.Text = "Monitoreo detenido";
            }
            else
            {
                MessageBox.Show("El monitoreo será restablecido");
                _check = true;
                timer1.Start();
                this.Text = "Monitoreo restablecido";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress adress;
                if (IPAddress.TryParse(txtAdrs.Text, out adress) || Uri.IsWellFormedUriString(txtAdrs.Text, UriKind.Absolute))
                {
                    using (StreamReader rd = new StreamReader(jsonPath))
                    {
                        string json = rd.ReadToEnd();
                        if (json.Contains(txtAdrs.Text) || json.Contains(txtNombre.Text))
                        {
                            MessageBox.Show("Esta direccion ya existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            var newItem = JsonConvert.DeserializeObject<List<Adress>>(json);
                            newItem.Add(new Adress(txtNombre.Text, txtAdrs.Text));
                            string newJson = JsonConvert.SerializeObject(newItem, Formatting.Indented);
                            timer1.Stop();
                            rd.Close();
                            File.WriteAllText(jsonPath, newJson);
                            timer1.Start();
                            txtAdrs.Clear();
                            txtNombre.Clear();
                            MessageBox.Show("Se agrego una nueva dirección!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No es posible añadir esta dirección\nPrueba una dirección valida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception err){  throw;  }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _ticks++;
                this.Text = _ticks.ToString();
                if (_ticks == 5)
                {
                    dataGridView1.Rows.Clear();
                    this.Text = "Refresh!";
                    PingMonitor();
                    _ticks = 0;
                }
                timer1.Interval = 1000;
            }
            catch (Exception etime) { throw; }
        }

        public Form1()
        {
            InitializeComponent();
            PingMonitor();
            timer1.Start();
        }

        private void PingMonitor()
        {

            using (StreamReader rd = new StreamReader(jsonPath))
            {
                string json = rd.ReadToEnd();
                dynamic table = JsonConvert.DeserializeObject<dynamic>(json);
                foreach (var item in table)
                {
                    try
                    {
                        Ping ping = new Ping();
                        PingReply pingReply = ping.Send(item.direccion.ToString(), 1000);
                        if (pingReply.Status == IPStatus.Success)
                        {
                            adress = item.direccion.ToString();
                            roundtrip = pingReply.RoundtripTime.ToString();
                            ttl = pingReply.Options.Ttl.ToString();
                            df = pingReply.Options.DontFragment.ToString();
                            buffer = pingReply.Buffer.Length.ToString();
                            DataGridViewRow nR = new DataGridViewRow();
                            nR.CreateCells(dataGridView1);
                            nR.Cells[0].Value = item.nombre.ToString();
                            nR.Cells[1].Value = item.direccion.ToString();
                            nR.Cells[2].Value = $"{roundtrip} ms";
                            nR.Cells[3].Value = ttl;
                            nR.Cells[4].Value = df;
                            nR.Cells[5].Value = buffer;
                            nR.Cells[6].Value = gArrow;
                            dataGridView1.Rows.Add(nR);
                            ping.Dispose();
                        }
                        else
                        {
                            DataGridViewRow nR = new DataGridViewRow();
                            nR.CreateCells(dataGridView1);
                            nR.Cells[0].Value = item.nombre.ToString();
                            nR.Cells[1].Value = item.direccion.ToString();
                            nR.Cells[2].Value = "NA";
                            nR.Cells[3].Value = "NA";
                            nR.Cells[4].Value = "NA";
                            nR.Cells[5].Value = "NA";
                            nR.Cells[6].Value = rArrow;
                            dataGridView1.Rows.Add(nR);
                            ping.Dispose();
                        }
                    }
                    catch (Exception err)
                    {
                        DataGridViewRow nR = new DataGridViewRow();
                        nR.CreateCells(dataGridView1);
                        nR.Cells[0].Value = item.nombre.ToString();
                        nR.Cells[1].Value = item.direccion.ToString();
                        nR.Cells[2].Value = $"{roundtrip} ms";
                        nR.Cells[3].Value = ttl;
                        nR.Cells[4].Value = df;
                        nR.Cells[5].Value = buffer;
                        nR.Cells[6].Value = gArrow;
                        dataGridView1.Rows.Add(nR);
                    }
                }
            }
        }

        public class Adress 
        {
            public string nombre { get; set; }
            public string direccion { get; set; }
            public Adress(string text1, string text2)
            {
                this.nombre = text1;
                this.direccion = text2;
            }
        }
    }
}
