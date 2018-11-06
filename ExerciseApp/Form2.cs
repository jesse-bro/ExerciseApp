using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            ToolTip ToolT = new ToolTip();
            ToolT.ToolTipIcon = ToolTipIcon.Info;
            ToolT.ToolTipTitle = "Definition";
            ToolT.IsBalloon = true;
            ToolT.ShowAlways = true;

            ToolT.SetToolTip(label1, "The name of the Exercise.");
            ToolT.SetToolTip(label2, "The weight (in Pounds) you use for this Exercise.");
            ToolT.SetToolTip(label3, "How many Repetitions in one Set.");
            ToolT.SetToolTip(label4, "A set contains the amount of Repetitions. Ex: 3 sets of 8 reps = 24 repetitions in total.");
            ToolT.SetToolTip(label5, "The Body Part this exercise mainly focuses on.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
