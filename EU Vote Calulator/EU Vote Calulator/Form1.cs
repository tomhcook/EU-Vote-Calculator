using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU_Vote_Calulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Classes.Countries twat = new Classes.Countries();
            twat.Name = "asburger";
            twat.pop = 22.6f;
            twat.Vote = true;
            twat.imgpath = @"C:\Users\computing\Downloads\ch0015_00_takeshi_256.png";
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
