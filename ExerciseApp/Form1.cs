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

namespace ExerciseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }


        private void readOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Title = "Open Text File";
            Dialog.Filter = "TXT files|*.txt";
            Dialog.InitialDirectory = @"C:\";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = Dialog.FileName;
                    var exercise = from line in File.ReadAllLines(file)
                                   let parts = line.Split(',')
                                   select new Exercise
                                   {
                                       ExerciseMovement = parts[0],
                                       Weight = parts[1],
                                       Reps = parts[2],
                                       Sets = parts[3],
                                       BodyPart = parts[4]
                                   };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could Not Read File. Original error: " + ex.Message);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
        }
    }
}
