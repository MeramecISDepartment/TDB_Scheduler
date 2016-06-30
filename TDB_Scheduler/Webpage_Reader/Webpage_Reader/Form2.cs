using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Webpage_Reader
{
    public partial class Form2 : Form
    {
        public string textFileName = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* I referenced this page on stack overflow
             * http://stackoverflow.com/questions/2767273/c-sharp-textbox-cursor-positioning
             * to set the cursor position at the front of the textbox.
             */

            button1.Visible = true;
        }

        /*private Form1 originalForm;*/

        public void button1_Click(object sender, EventArgs e)
        {
            /*I referenced this article on MSDN
             * https://msdn.microsoft.com/en-us/library/aa288422(v=vs.71).aspx
             * to use a variable from another form.
             */
            textFileName += textBox1.Text + ".txt";
            this.Close();
        }
    }
}
