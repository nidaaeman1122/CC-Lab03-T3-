using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_T3_
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
            string text = richTextBox1.Text;
            string regexPattern = @"\b[tm]\w+";

            MatchCollection matches = Regex.Matches(text, regexPattern);

            dataGridView1.Rows.Clear();

            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add(match.Value);
            }

            label1.Text = $"Found {matches.Count} words starting with 't' or 'm'";
        }
    }
    }

