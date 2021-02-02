namespace AlgorithmsAssignment5
{
    partial class Findbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkboxWholeWord = new System.Windows.Forms.CheckBox();
            this.checkboxMatchCase = new System.Windows.Forms.CheckBox();
            this.dropdownAlgo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.richFileContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(423, 162);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(232, 33);
            this.txtWord.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(699, 162);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(153, 39);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find Next";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(699, 224);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 38);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkboxWholeWord
            // 
            this.checkboxWholeWord.AutoSize = true;
            this.checkboxWholeWord.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxWholeWord.Location = new System.Drawing.Point(205, 231);
            this.checkboxWholeWord.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxWholeWord.Name = "checkboxWholeWord";
            this.checkboxWholeWord.Size = new System.Drawing.Size(276, 28);
            this.checkboxWholeWord.TabIndex = 4;
            this.checkboxWholeWord.Text = "Match whole word only";
            this.checkboxWholeWord.UseVisualStyleBackColor = true;
            // 
            // checkboxMatchCase
            // 
            this.checkboxMatchCase.AutoSize = true;
            this.checkboxMatchCase.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxMatchCase.Location = new System.Drawing.Point(205, 276);
            this.checkboxMatchCase.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxMatchCase.Name = "checkboxMatchCase";
            this.checkboxMatchCase.Size = new System.Drawing.Size(155, 28);
            this.checkboxMatchCase.TabIndex = 5;
            this.checkboxMatchCase.Text = "Match case";
            this.checkboxMatchCase.UseVisualStyleBackColor = true;
            this.checkboxMatchCase.CheckedChanged += new System.EventHandler(this.checkboxMatchCase_CheckedChanged);
            // 
            // dropdownAlgo
            // 
            this.dropdownAlgo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdownAlgo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdownAlgo.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownAlgo.FormattingEnabled = true;
            this.dropdownAlgo.Items.AddRange(new object[] {
            "Brute Force",
            "Rabin-Karp",
            "Knuth-Morris-Pratt"});
            this.dropdownAlgo.Location = new System.Drawing.Point(423, 101);
            this.dropdownAlgo.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownAlgo.Name = "dropdownAlgo";
            this.dropdownAlgo.Size = new System.Drawing.Size(232, 32);
            this.dropdownAlgo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Algorithm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "String Matching Algorithms";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadFile.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(44, 49);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(208, 39);
            this.btnUploadFile.TabIndex = 7;
            this.btnUploadFile.Text = "Upload Folder";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // richFileContent
            // 
            this.richFileContent.Font = new System.Drawing.Font("Century Gothic", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richFileContent.Location = new System.Drawing.Point(12, 374);
            this.richFileContent.Name = "richFileContent";
            this.richFileContent.Size = new System.Drawing.Size(1800, 700);
            this.richFileContent.TabIndex = 11;
            this.richFileContent.TabStop = false;
            this.richFileContent.Text = "";
            // 
            // Findbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1814, 1054);
            this.Controls.Add(this.richFileContent);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdownAlgo);
            this.Controls.Add(this.checkboxMatchCase);
            this.Controls.Add(this.checkboxWholeWord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Findbox";
            this.Text = "Findbox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Findbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkboxWholeWord;
        private System.Windows.Forms.CheckBox checkboxMatchCase;
        private System.Windows.Forms.ComboBox dropdownAlgo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.RichTextBox richFileContent;
    }
}