namespace WeatherTest
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
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            find = new Button();
            countryTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(find);
            groupBox1.Controls.Add(countryTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(6, 141);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 204);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите город: ";
            // 
            // find
            // 
            find.Location = new Point(40, 75);
            find.Name = "find";
            find.Size = new Size(75, 23);
            find.TabIndex = 0;
            find.Text = "Поиск";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click_1;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(6, 36);
            countryTextBox.Multiline = true;
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(109, 33);
            countryTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 395);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button find;
        private TextBox countryTextBox;
        private RichTextBox richTextBox1;
    }
}