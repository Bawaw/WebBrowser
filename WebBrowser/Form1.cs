using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }

        private void browser_Load(object sender, EventArgs e)
        {

        }

        private void goBack(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void goForward(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refresh(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void search(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void doResize(object sender, EventArgs e)
        {
            webBrowser1.Size = new Size(this.Size.Width - (791 - 758), this.Size.Height - (514 - 429));
        }
    }
}
