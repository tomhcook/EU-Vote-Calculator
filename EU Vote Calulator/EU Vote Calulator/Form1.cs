﻿using System;
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

        public void Form1_Load(object sender, EventArgs e)
        {
            twat.Abstain = false;
            twat.Name = "asburger";
            twat.pop = 22.6f;
            twat.Vote = true;
            twat.imgpath = @"C:\Users\computing\Downloads\ch0015_00_takeshi_256.png";

            cunt.Abstain = false;
            cunt.Name = "mo";
            cunt.pop = 22.6f;
            cunt.Vote = true;
            cunt.imgpath = @"C:\Users\computing\Downloads\ch0015_00_takeshi_256.png";

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(cunt);
            label1.Text = output;

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                outputFile.WriteLine(output);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

