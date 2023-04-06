namespace Debrid_Skeleton
{
    partial class Form3
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            login_button = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(425, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(425, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 228);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 7;
            label3.Text = "Please enter a password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 187);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 6;
            label2.Text = "Please enter a username: ";
            // 
            // button1
            // 
            button1.Location = new Point(425, 292);
            button1.Name = "button1";
            button1.Size = new Size(227, 23);
            button1.TabIndex = 10;
            button1.Text = "Forget your login info? Click here.";
            button1.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            login_button.Location = new Point(246, 292);
            login_button.Name = "login_button";
            login_button.Size = new Size(125, 23);
            login_button.TabIndex = 11;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_button);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Exisiting Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button login_button;
    }
}