using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            identifiers.Items.Clear();
            constants.Items.Clear();
            iterations.Text = "";
            Analyzer analyzer = new Analyzer(input.Text);
            if (analyzer.ErrorPosition == -1)
            {
                result.ForeColor = Color.Green;
                result.Text = "Ошибок нет";
                foreach (string id in analyzer.Identifiers)
                {
                    identifiers.Items.Add(id);
                }
                foreach (string constant in analyzer.Constants)
                {
                    constants.Items.Add(constant);
                }
                iterations.Text = analyzer.Iterations.ToString();
            }
            else
            {
                result.ForeColor = Color.Red;
                result.Text = analyzer.ErrorMessage + $" (позиция {analyzer.ErrorPosition})";
                input.Focus();
                input.Select(analyzer.ErrorPosition, input.Text.Length - analyzer.ErrorPosition);
            }
        }
    }
}
