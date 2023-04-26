using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BBLevelEditor
{
    public partial class Form1 : Form
    {

        int x, y, hp, color;

        private void button55_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {

            XmlWriter writer = XmlWriter.Create("brickTest.xml");

            writer.WriteStartElement("Bricks");

            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    string xLocation = Convert.ToString(c.Location.X);
                    string yLocation = Convert.ToString(c.Location.Y);
                    string hpValue = Convert.ToString(c.Text);
                   
                    writer.WriteStartElement("brick");
                    writer.WriteElementString("X", xLocation);
                    writer.WriteElementString("Y", yLocation);
                    writer.WriteElementString("HP", hpValue);
                    

                    writer.WriteEndElement();

                }
            }
            writer.WriteEndElement();
            writer.Close();

        }
    }
}
