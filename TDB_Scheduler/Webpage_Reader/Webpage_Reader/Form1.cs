/*
I started this project today: 12/14/2015

 
I reference this video tutorial: https://www.youtube.com/watch?v=NyT33tOkxYQ 
(C# Tutorial 91: How to get Source Code from a Website with C#)
published by ProgrammingKnowledge.

All of the following code is by him so far.

---------------------------------------------------------------------------------------------------------------
Get the sourcecode
in the window
edit it
save it to a file
in another tab 
open the file
convert the file to an audio file or read it out
--------------------------------------------------
 My final project is designed to take a website, scrape the text from it, and convert that text into an 
 audio file.  How it works is that the user gives it a URL.  The program verifies that the URL exists 
 and then gets the source code from that website.  The program then scrapes out only the text from that
 website, disregarding the tags.  It then converts the text to audio and stores it as an mp3 so that the 
 user can listen to the web page in the future.

The inputs are a URL entered by the user, the source code, the text of the web page and the audio of that text.
These inputs come from the user, who entered the URL or copied and pasted it, the web page, it's source code, 
the  text from the source code and the audio from that text. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
// I referenced http://www.dotnetperls.com/streamwriter for how to include StreamWriter
using System.IO;

namespace Webpage_Reader
{
    public partial class Form1 : Form
    {
        /*public string textFileName = "";*/

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = url_Textbox.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            /*button7.Visible = true;*/
            button3.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*I referenced this Code Project page
             http://www.codeproject.com/Questions/213245/how-to-enable-disable-textbox
             to enable the richTextBox1 text field for editing.*/
            richTextBox1.Enabled = true;
        }

        /*public Form2 nameFileForm;*/

        private void button3_Click(object sender, EventArgs e)
        {
            /*string newTextFileName = nameFileForm.textFileName;*/
            /*I referenced https://www.youtube.com/watch?v=hs74fKPJpFw for how to write to a file.*/
            StreamWriter File = new StreamWriter("newTextFile.txt");
            File.Write(richTextBox1.Text);
            /*string webText = richTextBox1.Text;
            System.IO.File.WriteAllLines(@"C:\Users\Tyler Barton\Desktop\", webText);*/
            /*I referenced here 
             * https://msdn.microsoft.com/library/ms752080(v=vs.100).aspx
             * to create a message box.
             */
            
            MessageBox.Show("Your text file was saved.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // I referenced this page on Stack Overflow:
            // http://stackoverflow.com/questions/5718183/how-to-open-the-second-form
            // to open a seperate form window.
            //
            // Create a new instance of the Form2 class
            Form2 nameFileForm = new Form2();

            // Show the settings form
            nameFileForm.Show();

            /*button3.Visible = true;*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string locationOfFile = textBox2.Text;

            /*
            SaveFileDialog my_Sfd = new SaveFileDialog();
            my_Sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav";
            my_Sfd.Title = "Save to a wav file.";
            my_Sfd.FilterIndex = 2;
            my_Sfd.RestoreDirectory = true;
            if ((my_Sfd.ShowDialog() == DialogResult.OK)&&(TxtArea_Chk.Checked == true))
                {
                spFileStream.Open(my_Sfd.FileName, spFileMode, false);
                my_Voice.AudioOutputStream = spFileStream;
                my_Voice.Speak(TextArea_User.Text, my_Spflag);
                my_Voice.WaitUntilDone(-1);
                spFileStream.Close();
                }
            else if((my_Sfd.ShowDialog() == 
		DialogResult.OK)&&(TxtFilePath_Chk.Checked == true))
                {
                spFileStream.Open(my_Sfd.FileName, spFileMode, false);
                my_Voice.AudioOutputStream = spFileStream;
                my_Voice.Speak(my_fDlg.FileName, SpeechVoiceSpeakFlags.SVSFIsFilename);
                my_Voice.WaitUntilDone(-1);
                spFileStream.Close();
                }
             */
        }
        /*
         * Referencing Prof. Oberst's TextFile.cs file in the ConsoleReadInvitation Solution.
         * 
        class TextFile
        {
            public string InFile { get; set; }

            public List<string> LinesRead { get; set; }

            public TextFile(string inFile = "") 
            {
                if (inFile.Length > 0)
                {
                    this.InFile = inFile;
                    ReadFile();
                }
            }

	        // Read in a file line-by-line, and store it all in a List.
            private void ReadFile() 
            {
	            List<string> list = new List<string>();

	            using (StreamReader reader = new StreamReader(this.InFile))
	            {
	                string line;
	                while ((line = reader.ReadLine()) != null)
		                list.Add(line); // Add to list.
	            }

                this.LinesRead = list;
            }
         */

    }
}
