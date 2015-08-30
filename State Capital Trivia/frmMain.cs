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

namespace State_Capital_Trivia
{
    public partial class frmMain : Form
    { 
        StreamReader inFile;
        bool Submit = false;
        int answer = 0;
        double score = 0;

        public frmMain()
        {
            
            InitializeComponent();
            try
            {
                inFile = File.OpenText("stateCapitals.txt");
            
                lblState.Text = inFile.ReadLine() + "?";
                radCapital1.Text = "1. " + inFile.ReadLine();
                radCapital2.Text = "2. " + inFile.ReadLine();
                radCapital3.Text = "3. " + inFile.ReadLine();
                radCapital4.Text = "4. " + inFile.ReadLine();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radCapital1.Checked = false;
            radCapital2.Checked = false;
            radCapital3.Checked = false;
            radCapital4.Checked = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\DeleteMe";
            openFileDialog1.Title = "Open My File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string stateName;
                try
                {
                    
                    inFile = File.OpenText(openFileDialog1.FileName);
                    while (!inFile.EndOfStream)
                    {
                        stateName = inFile.ReadLine();
                        

                    }
                    inFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nevermind");
            }
               
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter outFile;
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outFile = File.CreateText(saveFileDialog1.FileName);
                outFile.WriteLine("It works!");
                outFile.Close();
            }
            else
                MessageBox.Show("File not saved");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Here we go!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Submit)
            {
                if (!inFile.EndOfStream)
                {
                    lblState.Text = inFile.ReadLine();
                    radCapital1.Text = "1. " + inFile.ReadLine();
                    radCapital2.Text = "2. " + inFile.ReadLine();
                    radCapital3.Text = "3. " + inFile.ReadLine();
                    radCapital4.Text = "4. " + inFile.ReadLine();

                    btnClear.Visible = true;
                    btnSubmit.Visible = true;
                    lblShowAnswer.Visible = false;
                    lblAnswer.Visible = false;
                    Submit = false;
                }
                else
                {
                    MessageBox.Show("Congratulations, you finished the game with a score of " + score.ToString() + "%");
                }
            }
            else
            {
                MessageBox.Show("Must select and submit an answer");
            }
          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!radCapital1.Checked && !radCapital2.Checked && !radCapital3.Checked && !radCapital4.Checked)
            {
                MessageBox.Show("Must select an Answer");
            }
            else
            {
                lblAnswer.Text = inFile.ReadLine();
                lblShowAnswer.Visible = true;
                lblAnswer.Visible = true;
                int.TryParse(lblAnswer.Text, out answer);
                Submit = true;
                if (answer == 1 && radCapital1.Checked)
                {
                    score = score + 25;
                    lblScore.Text = score.ToString();
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;

                }
                else if (answer == 2 && radCapital2.Checked)
                {
                    score = score + 25;
                    lblScore.Text = score.ToString();
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;

                }
                else if (answer == 3 && radCapital3.Checked)
                {
                    score = score + 25;
                    lblScore.Text = score.ToString();
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;

                }
                else if (answer == 4 && radCapital4.Checked)
                {
                    score = score + 25;
                    lblScore.Text = score.ToString();
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;

                }
                else
                {
                    lblScore.Text = score.ToString();
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;
                }
            }
        }
    }
}
