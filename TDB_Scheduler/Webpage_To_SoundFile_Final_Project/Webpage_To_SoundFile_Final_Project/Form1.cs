using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webpage_To_SoundFile_Final_Project
{
    public partial class Form1 : Form
    {
        /* The title of my final project is URL_Checker.
         * 
         * It is designed so that the user will enter a URL and it will verify that that location exists.
         * 
         * The input is text from the text_field.
         * 
         * The input comes from the user.
         * 
         * The title of my project is Location_storer.
         * 
         * It is designed so that the user will enter a URL and it will verify that that location exists.
         * It will then ask the user if he or she would like to store that location.
         * In storing that location (or bookmark), it will ask the user for specifics, such as a bookmark/location name (as well as collect the name, title, website name and address cannot be found for some reason).
         * The user can then go through the links and open the bookmarks in his or her browser of choice within that window.
         * 
         * The input is one of several textfield entries.
         * 
         * The input comes from the user.
         * 
         * The title of my project is Webpage_Scrapper
         * 
         * It is designed so that the user will enter a URL and it will verify that that location exists.
         * It will then ask the user if he or she would like to store that location.
         * //In storing that location (or bookmark), it will ask the user for specifics, such as a bookmark/location name (as well as collect the name, title, website name and address cannot be found for some reason).
         * //The user can then go through the links and open the bookmarks in his or her browser of choice within that window.
         * Upon storing that location, it will scrape the text from the web page and store it in a collapsable, with title and information (for copyright reasons).
         * The user can delete this collapsable if he or chooses in the future.
         * 
         * The inputs are from the web and various textfield inputs and button clicks.
         * 
         * These inputs come from the web and from the user.
         * 
         * The title of my final project is "Webpage_To_SoundFile."
         * 
         * It is designed so that the user will enter a URL and it will verify that that location exists.
         * //It will then ask the user if he or she would like to store that location.
         * //In storing that location (or bookmark), it will ask the user for specifics, such as a bookmark/location name (as well as collect the name, title, website name and address cannot be found for some reason).
         * //The user can then go through the links and open the bookmarks in his or her browser of choice within that window.
         * //Upon storing that location, it will scrape the text from the web page and store it in a collapsable, with title and information (for copyright reasons).
         * //The user can delete this collapsable if he or chooses in the future.
         * It will then ask if he or she would like to scrape from that website.
         * //The user will choose yes or no and it will scrape the text from that website.
         * The webpage will show up in a window below and the scrapper will ask the user to highlight what parts he or she would like to scrape.
         * The web scrapper will find the text within the html tags and scrape it and store it somewhere.
         * The text to audio program will run to convert the text to audio.
         * The user will then be prompted as to whether he or she would like an mp3 of that (copyright will be appended to the front of the audio file)
         * mp3 files will be stored in a playlist of collapsables. 
         * 
         * The inputs are from the web and various textfield inputs and button clicks.
         * 
         * These inputs come from the web and from the user.
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }
    }
}
