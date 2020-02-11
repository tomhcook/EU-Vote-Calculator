using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EU_Vote_Calulator
{
    public partial class Form1 : Form
    {
        Classes.Countries cunt = new Classes.Countries();
        Classes.Countries twat = new Classes.Countries();
        public Form1()
        {
            InitializeComponent();
            
        }
        //https://en.wikipedia.org/wiki/List_of_European_Union_member_states_by_population
        public void Form1_Load(object sender, EventArgs e)
        {
            twat.Abstain = false;
            twat.Name = "asburger";
            twat.pop = 22.6f;
            twat.Vote = true;
            twat.imgpath = @"\\imgs\flags\Austria.png";

            cunt.Abstain = false;
            cunt.Name = "mo";
            cunt.pop = 22.6f;
            cunt.Vote = true;
            cunt.imgpath = @"C:\Users\computing\Downloads\ch0015_00_takeshi_256.png";

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources.Austria;
            string output = JsonConvert.SerializeObject(cunt);
            label1.Text = output;

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                outputFile.WriteLine(output);
            }
            Classes.Countries test = JsonConvert.DeserializeObject<Classes.Countries>(output);
            label1.Text = test.Name;
        }

        private void pictureBox1_Update(object sender, EventArgs e)
        {

        }
        public void maths()
        {
            //code
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

