using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String filename = textBox1.Text;
                Byte[] bytes = File.ReadAllBytes(filename);
                String file = Convert.ToBase64String(bytes);
                textBox2.Text = file;
                Clipboard.SetText(file);
                MessageBox.Show("Successfully converted file to Base64 string.\n\nBase64 copied to your clipboard.","Success");
            }
            catch(Exception e1)
            {
                MessageBox.Show("Failed to convert file to Base64 string.","Failed");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String path = textBox1.Text;
                Byte[] bytes = Convert.FromBase64String(textBox2.Text);
                File.WriteAllBytes(path, bytes);
                MessageBox.Show("Successfully Base64 string to file.","Success");
            }
            catch(Exception e2)
            {
                MessageBox.Show("Failed to convert Base64 string to file.","Failed");
            }
        }
    }
}
