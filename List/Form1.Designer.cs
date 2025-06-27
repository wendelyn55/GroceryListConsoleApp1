namespace List
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
            listBox1 = new ListBox();
            button1 = new Button();
            label3 = new Label();
            listBox2 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 28);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "GROCERY LIST";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 87);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Add to List:";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.Cursor = Cursors.SizeNESW;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(143, 81);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 34);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(373, 81);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "Remove to List:";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Silver;
            listBox2.Cursor = Cursors.SizeNESW;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(143, 155);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(190, 34);
            listBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(373, 155);
            button2.Name = "button2";
            button2.Size = new Size(87, 34);
            button2.TabIndex = 6;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(77, 264);
            button3.Name = "button3";
            button3.Size = new Size(131, 46);
            button3.TabIndex = 7;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(295, 264);
            button4.Name = "button4";
            button4.Size = new Size(131, 46);
            button4.TabIndex = 8;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wendy55;
            ClientSize = new Size(509, 377);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private Label label3;
        private ListBox listBox2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
