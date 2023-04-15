namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReadButton_Click = new Button();
            SortButton = new Button();
            resultsListBox = new ListBox();
            Save = new Button();
            textBox1 = new TextBox();
            Open = new Button();
            SuspendLayout();
            // 
            // ReadButton_Click
            // 
            ReadButton_Click.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ReadButton_Click.Location = new Point(417, 70);
            ReadButton_Click.Name = "ReadButton_Click";
            ReadButton_Click.Size = new Size(149, 59);
            ReadButton_Click.TabIndex = 0;
            ReadButton_Click.Text = "ReadButton";
            ReadButton_Click.UseVisualStyleBackColor = true;
            ReadButton_Click.Click += button1_Click;
            // 
            // SortButton
            // 
            SortButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SortButton.Location = new Point(432, 288);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(134, 64);
            SortButton.TabIndex = 1;
            SortButton.Text = "SortButton";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // resultsListBox
            // 
            resultsListBox.FormattingEnabled = true;
            resultsListBox.ItemHeight = 15;
            resultsListBox.Location = new Point(12, 222);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(367, 214);
            resultsListBox.TabIndex = 2;
            resultsListBox.SelectedIndexChanged += resultsListBox_SelectedIndexChanged;
            // 
            // Save
            // 
            Save.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Save.Location = new Point(627, 288);
            Save.Name = "Save";
            Save.Size = new Size(122, 64);
            Save.TabIndex = 3;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 204);
            textBox1.TabIndex = 4;
            // 
            // Open
            // 
            Open.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Open.Location = new Point(627, 70);
            Open.Name = "Open";
            Open.Size = new Size(122, 59);
            Open.TabIndex = 5;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Open);
            Controls.Add(textBox1);
            Controls.Add(Save);
            Controls.Add(resultsListBox);
            Controls.Add(SortButton);
            Controls.Add(ReadButton_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReadButton_Click;
        private Button SortButton;
        private ListBox resultsListBox;
        private Button Save;
        private TextBox textBox1;
        private Button Open;
    }
}