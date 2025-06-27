namespace GroceryListWindows
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 34);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "GROCERY LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Add Item:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(12, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 198);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 3;
            label3.Text = "Remove Item:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(12, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(213, 118);
            button1.Name = "button1";
            button1.Size = new Size(91, 27);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(213, 235);
            button2.Name = "button2";
            button2.Size = new Size(91, 27);
            button2.TabIndex = 6;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(352, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(243, 319);
            listBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(98, 321);
            button3.Name = "button3";
            button3.Size = new Size(127, 56);
            button3.TabIndex = 8;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wendy55;
            ClientSize = new Size(607, 450);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
    }
}
