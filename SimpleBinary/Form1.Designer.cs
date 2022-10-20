namespace SimpleBinary
{
    partial class Form1
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
            this.uiSaveButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.TextBox();
            this.uiAge = new System.Windows.Forms.TextBox();
            this.uiBalance = new System.Windows.Forms.TextBox();
            this.uiQuote = new System.Windows.Forms.TextBox();
            this.uiQuoteButton = new System.Windows.Forms.Button();
            this.uiShowTextBox = new System.Windows.Forms.TextBox();
            this.uiLoadButon = new System.Windows.Forms.Button();
            this.uiCreateButton = new System.Windows.Forms.Button();
            this.uiFamous = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiSaveButton
            // 
            this.uiSaveButton.Location = new System.Drawing.Point(316, 137);
            this.uiSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiSaveButton.Name = "uiSaveButton";
            this.uiSaveButton.Size = new System.Drawing.Size(112, 35);
            this.uiSaveButton.TabIndex = 0;
            this.uiSaveButton.Text = "Save";
            this.uiSaveButton.UseVisualStyleBackColor = true;
            this.uiSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 22);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quote";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(14, 102);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(67, 20);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "Balance";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(14, 63);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(84, 17);
            this.uName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(148, 26);
            this.uName.TabIndex = 5;
            // 
            // uiAge
            // 
            this.uiAge.Location = new System.Drawing.Point(84, 57);
            this.uiAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiAge.Name = "uiAge";
            this.uiAge.Size = new System.Drawing.Size(148, 26);
            this.uiAge.TabIndex = 6;
            // 
            // uiBalance
            // 
            this.uiBalance.Location = new System.Drawing.Point(84, 97);
            this.uiBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiBalance.Name = "uiBalance";
            this.uiBalance.Size = new System.Drawing.Size(148, 26);
            this.uiBalance.TabIndex = 7;
            // 
            // uiQuote
            // 
            this.uiQuote.Location = new System.Drawing.Point(316, 52);
            this.uiQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiQuote.Name = "uiQuote";
            this.uiQuote.Size = new System.Drawing.Size(310, 26);
            this.uiQuote.TabIndex = 8;
            // 
            // uiQuoteButton
            // 
            this.uiQuoteButton.Location = new System.Drawing.Point(316, 92);
            this.uiQuoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiQuoteButton.Name = "uiQuoteButton";
            this.uiQuoteButton.Size = new System.Drawing.Size(112, 35);
            this.uiQuoteButton.TabIndex = 9;
            this.uiQuoteButton.Text = "Add Quote";
            this.uiQuoteButton.UseVisualStyleBackColor = true;
            this.uiQuoteButton.Click += new System.EventHandler(this.uiQuoteButton_Click);
            // 
            // uiShowTextBox
            // 
            this.uiShowTextBox.Location = new System.Drawing.Point(84, 257);
            this.uiShowTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiShowTextBox.Multiline = true;
            this.uiShowTextBox.Name = "uiShowTextBox";
            this.uiShowTextBox.Size = new System.Drawing.Size(542, 279);
            this.uiShowTextBox.TabIndex = 10;
            // 
            // uiLoadButon
            // 
            this.uiLoadButon.Location = new System.Drawing.Point(84, 212);
            this.uiLoadButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLoadButon.Name = "uiLoadButon";
            this.uiLoadButon.Size = new System.Drawing.Size(112, 35);
            this.uiLoadButon.TabIndex = 11;
            this.uiLoadButon.Text = "Load";
            this.uiLoadButon.UseVisualStyleBackColor = true;
            this.uiLoadButon.Click += new System.EventHandler(this.uiLoadButon_Click);
            // 
            // uiCreateButton
            // 
            this.uiCreateButton.Location = new System.Drawing.Point(84, 137);
            this.uiCreateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCreateButton.Name = "uiCreateButton";
            this.uiCreateButton.Size = new System.Drawing.Size(112, 35);
            this.uiCreateButton.TabIndex = 12;
            this.uiCreateButton.Text = "Create";
            this.uiCreateButton.UseVisualStyleBackColor = true;
            this.uiCreateButton.Click += new System.EventHandler(this.uiCreateButton_Click);
            // 
            // uiFamous
            // 
            this.uiFamous.AutoSize = true;
            this.uiFamous.Location = new System.Drawing.Point(315, 14);
            this.uiFamous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiFamous.Name = "uiFamous";
            this.uiFamous.Size = new System.Drawing.Size(93, 24);
            this.uiFamous.TabIndex = 13;
            this.uiFamous.Text = "Famous";
            this.uiFamous.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 12);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiFamous);
            this.Controls.Add(this.uiCreateButton);
            this.Controls.Add(this.uiLoadButon);
            this.Controls.Add(this.uiShowTextBox);
            this.Controls.Add(this.uiQuoteButton);
            this.Controls.Add(this.uiQuote);
            this.Controls.Add(this.uiBalance);
            this.Controls.Add(this.uiAge);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.uiSaveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiSaveButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.TextBox uiAge;
        private System.Windows.Forms.TextBox uiBalance;
        private System.Windows.Forms.TextBox uiQuote;
        private System.Windows.Forms.Button uiQuoteButton;
        private System.Windows.Forms.TextBox uiShowTextBox;
        private System.Windows.Forms.Button uiLoadButon;
        private System.Windows.Forms.Button uiCreateButton;
        private System.Windows.Forms.CheckBox uiFamous;
        private System.Windows.Forms.Button button1;
    }
}

