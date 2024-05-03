using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgaBrowserWindowsForm
{
    public partial class AgaForm : Form
    {
        public AgaForm()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser browser;
        private void Aga_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(URL_Input.Text);
            browser.Dock = DockStyle.Fill;
            this.Main_Panel.Controls.Add(browser);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
