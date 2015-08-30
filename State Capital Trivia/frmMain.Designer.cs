namespace State_Capital_Trivia
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.radCapital1 = new System.Windows.Forms.RadioButton();
            this.radCapital2 = new System.Windows.Forms.RadioButton();
            this.radCapital3 = new System.Windows.Forms.RadioButton();
            this.radCapital4 = new System.Windows.Forms.RadioButton();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(153, 258);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(276, 258);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(60, 336);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Visible = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(108, 200);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(41, 13);
            this.label69.TabIndex = 12;
            this.label69.Text = "Score: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "What is the capital of";
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(153, 21);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(91, 25);
            this.lblState.TabIndex = 18;
            // 
            // radCapital1
            // 
            this.radCapital1.AutoSize = true;
            this.radCapital1.Location = new System.Drawing.Point(170, 68);
            this.radCapital1.Name = "radCapital1";
            this.radCapital1.Size = new System.Drawing.Size(49, 17);
            this.radCapital1.TabIndex = 19;
            this.radCapital1.TabStop = true;
            this.radCapital1.Text = "cap1";
            this.radCapital1.UseVisualStyleBackColor = true;
            // 
            // radCapital2
            // 
            this.radCapital2.AutoSize = true;
            this.radCapital2.Location = new System.Drawing.Point(170, 91);
            this.radCapital2.Name = "radCapital2";
            this.radCapital2.Size = new System.Drawing.Size(49, 17);
            this.radCapital2.TabIndex = 20;
            this.radCapital2.TabStop = true;
            this.radCapital2.Text = "cap2";
            this.radCapital2.UseVisualStyleBackColor = true;
            // 
            // radCapital3
            // 
            this.radCapital3.AutoSize = true;
            this.radCapital3.Location = new System.Drawing.Point(170, 114);
            this.radCapital3.Name = "radCapital3";
            this.radCapital3.Size = new System.Drawing.Size(49, 17);
            this.radCapital3.TabIndex = 21;
            this.radCapital3.TabStop = true;
            this.radCapital3.Text = "cap3";
            this.radCapital3.UseVisualStyleBackColor = true;
            // 
            // radCapital4
            // 
            this.radCapital4.AutoSize = true;
            this.radCapital4.Location = new System.Drawing.Point(170, 137);
            this.radCapital4.Name = "radCapital4";
            this.radCapital4.Size = new System.Drawing.Size(49, 17);
            this.radCapital4.TabIndex = 22;
            this.radCapital4.TabStop = true;
            this.radCapital4.Text = "cap4";
            this.radCapital4.UseVisualStyleBackColor = true;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Location = new System.Drawing.Point(238, 174);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(19, 13);
            this.lblAnswer.TabIndex = 23;
            this.lblAnswer.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(170, 200);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 24;
            // 
            // lblShowAnswer
            // 
            this.lblShowAnswer.AutoSize = true;
            this.lblShowAnswer.Location = new System.Drawing.Point(70, 174);
            this.lblShowAnswer.Name = "lblShowAnswer";
            this.lblShowAnswer.Size = new System.Drawing.Size(162, 13);
            this.lblShowAnswer.TabIndex = 25;
            this.lblShowAnswer.Text = "The correct answer was number ";
            this.lblShowAnswer.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 388);
            this.Controls.Add(this.lblShowAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.radCapital4);
            this.Controls.Add(this.radCapital3);
            this.Controls.Add(this.radCapital2);
            this.Controls.Add(this.radCapital1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Name = "frmMain";
            this.Text = "State Captial Trivia!";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.RadioButton radCapital1;
        private System.Windows.Forms.RadioButton radCapital2;
        private System.Windows.Forms.RadioButton radCapital3;
        private System.Windows.Forms.RadioButton radCapital4;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblShowAnswer;
    }
}

