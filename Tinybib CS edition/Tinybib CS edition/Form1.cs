using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinybib_CS_edition
{

    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        
        }
            
        

        

        private string Book() {

            string articleName1;
            string authorName1;
            string authorSurname1;
            string websiteTitle1;
            string publisherName1;
            string url1;
            string datePublished1;
            string dateAccessed1;
            string cityPublished1;
            string print;
            articleName1 = articleName.Text.ToString();
            authorName1 = authorName.Text.ToString();
            authorSurname1 = authorSurname.Text.ToString();
            websiteTitle1 = websiteTitle.Text.ToString();
            publisherName1 = publisherName.Text.ToString();
            url1 = url.Text.ToString();
            datePublished1 = datePublished.Text.ToString();
            dateAccessed1 = dateAccessed.Text.ToString();
            cityPublished1 = cityPublished.Text.ToString();

            if (authorSurname1 == null || authorSurname1 == "")
            {
               print = authorName1 + ". " + "'" + articleName1 + "." + "' " + cityPublished1 + ": " + publisherName1 + ", " + datePublished1 + ". " + "Print.";
                print = string.Format("{0}.'{1}.' {2}: {3}, {4}. Print.", authorName1, articleName1, cityPublished1, publisherName1, datePublished1);
            }
            else
            {
                print = string.Format("{0}, {1}.'{2}.' {3}: {4}, {5}. Print.", authorSurname1,authorName1,articleName1,cityPublished1,publisherName1,datePublished1);
                print = authorSurname1 + ", " + authorName1 + ". " + "'" + articleName1 + "." + "' " + cityPublished1 + ": " + publisherName1 + ", " + datePublished1 + ". " + "Print.";
            }
            return print;
        }

    
        private string Webpage() {

            
            string articleName1;
            string authorName1;
            string authorSurname1;
            string websiteTitle1;
            string publisherName1;
            string url1;
            string datePublished1;
            string dateAccessed1;
            string print;
            articleName1 = articleName.Text.ToString();
            authorName1 = authorName.Text.ToString();
            authorSurname1 = authorSurname.Text.ToString();
            websiteTitle1 = websiteTitle.Text.ToString();
            publisherName1 = publisherName.Text.ToString();
            url1 = url.Text.ToString();
            datePublished1 = datePublished.Text.ToString();
            dateAccessed1 = dateAccessed.Text.ToString();

            if (authorSurname1 == null || authorSurname1 == "")
            {
                print = string.Format("{0}. '{1}'. {2}. {3}, Date published: {4}. Date accessed: {5}.Web: <{6}>.", authorName1, articleName1, websiteTitle1, publisherName1, datePublished1, dateAccessed1, url1);

            }

            else{
              
                print = string.Format("{0}, {1}. '{2}'. {3}. {4}, Date published: {5}. Date accessed: {6}. Web: <{7}>.", authorSurname1, authorName1, articleName1, websiteTitle1, publisherName1, datePublished1, dateAccessed1, url1);
            };

           

            return print;
        }

        private string Ebook() {

            string articleName1;
            string authorName1;
            string authorSurname1;
            string websiteTitle1;
            string publisherName1;
            string url1;
            string datePublished1;
            string dateAccessed1;
            string print;
            string volumeNumber1;
            string sectionTitle1;
            articleName1 = articleName.Text.ToString();
            authorName1 = authorName.Text.ToString();
            authorSurname1 = authorSurname.Text.ToString();
            websiteTitle1 = websiteTitle.Text.ToString();
            publisherName1 = publisherName.Text.ToString();
            url1 = url.Text.ToString();
            datePublished1 = datePublished.Text.ToString();
            dateAccessed1 = dateAccessed.Text.ToString();
            volumeNumber1 = volumeNumber.Text.ToString();
            sectionTitle1 = sectionTitle.Text.ToString();


            print = string.Format("{0}, {1}. '{2}.' {3}, {4}, {5}, ", authorSurname1, authorName1, articleName1, volumeNumber1, publisherName1, datePublished1);
           
            return print;
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true) {
                Clipboard.SetText(Webpage());
                System.Windows.Forms.MessageBox.Show("Bibliography copied to the clipboard!");
            }

            if (radioButton2.Checked == true) {
                Clipboard.SetText(Book());
                System.Windows.Forms.MessageBox.Show("Bibliography copied to the clipboard!");
                
            }

            if (radioButton3.Checked == true)
            {
                Clipboard.SetText(Ebook());
                System.Windows.Forms.MessageBox.Show("Bibliography copied to the clipboard!");
                
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Title";
            url.Visible = true;
            label7.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Book name";
            label11.Visible = true;
            url.Visible = false;
            label7.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Book name";
            label11.Visible = true;
            url.Visible = true;
            label7.Visible = true;
            //articleName.Visible = false;
        }

        private void articleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
