namespace GroceryListWindowsForm
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            list = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 42);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "GROCERY LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 111);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Add Item:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 223);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "Remove Item:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(22, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(22, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 4;
            // 
            // list
            // 
            list.BackColor = Color.Silver;
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(431, 111);
            list.Name = "list";
            list.Size = new Size(281, 394);
            list.TabIndex = 5;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(257, 148);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(257, 257);
            button2.Name = "button2";
            button2.Size = new Size(109, 29);
            button2.TabIndex = 7;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(22, 374);
            button3.Name = "button3";
            button3.Size = new Size(135, 55);
            button3.TabIndex = 8;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(231, 374);
            button4.Name = "button4";
            button4.Size = new Size(135, 55);
            button4.TabIndex = 9;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wendy55;
            ClientSize = new Size(724, 569);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(list);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox list;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
