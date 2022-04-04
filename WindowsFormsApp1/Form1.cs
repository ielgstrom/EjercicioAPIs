using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorris;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    var response = API.Random(exclude: new string[] { "explicit" });
        //    var joke = response.Result;
        //    richTextBox1.Text = joke.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var response = API.Categorias();
            var categ = response.Result;
            //comboBox1.Items.Add(categ.Categ);
            richTextBox1.Text = categ.ToString();
        }
    }
}
