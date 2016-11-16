using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace InterfaceSystemController
{
    public partial class Form1 : Form
    {

        ServiceReference.SystemControllerSoapClient service = new ServiceReference.SystemControllerSoapClient();
        private string routeArchive;

        public Form1(string route)
        {
            InitializeComponent();
           /* service = new ServiceReference.SystemControllerSoapClient();*/
            this.routeArchive = route;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = service.initialize_List(routeArchive, deviceName.Text, "create");
            richTextBox1.Text += message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameDevice_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void nameXML_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadDevice_Click(object sender, EventArgs e)
        {
            string content = service.initialize_List(routeArchive, nameSearch.Text, Action.Text);

            richTextBox1.Text += content;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
