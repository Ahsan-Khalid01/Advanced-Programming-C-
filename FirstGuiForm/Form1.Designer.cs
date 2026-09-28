namespace FirstGuiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            UserName = new Label();
            label3 = new Label();
            password = new TextBox();
            username1 = new TextBox();
            btnSignIn = new Button();
            btnSignUp = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Cursor = Cursors.AppStarting;
            label1.Font = new Font("Algerian", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(40, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 0;
            label1.Text = "      Student Login\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // UserName
            // 
            UserName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.Location = new Point(65, 128);
            UserName.Name = "UserName";
            UserName.Size = new Size(123, 26);
            UserName.TabIndex = 1;
            UserName.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 226);
            label3.Name = "label3";
            label3.Size = new Size(122, 27);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // password
            // 
            password.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(65, 267);
            password.Name = "password";
            password.PlaceholderText = "e.g. ••••••••";
            password.Size = new Size(274, 30);
            password.TabIndex = 3;
            // 
            // username1
            // 
            username1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username1.Location = new Point(65, 157);
            username1.Name = "username1";
            username1.PlaceholderText = "e.g. ahsan.khalid";
            username1.Size = new Size(274, 30);
            username1.TabIndex = 4;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.MenuHighlight;
            btnSignIn.BackgroundImage = (Image)resources.GetObject("btnSignIn.BackgroundImage");
            btnSignIn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.ActiveCaptionText;
            btnSignIn.Location = new Point(65, 327);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(123, 37);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.MenuHighlight;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(205, 327);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(123, 37);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += button2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Colonna MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 61);
            label2.Name = "label2";
            label2.Size = new Size(175, 18);
            label2.TabIndex = 7;
            label2.Text = "Welcome To Platform";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(408, 501);
            Controls.Add(label2);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(username1);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(UserName);
            Controls.Add(label1);
            Cursor = Cursors.AppStarting;
            Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            Location = new Point(10, 10);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LOGIN PAGE";
            TransparencyKey = Color.Red;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label UserName;
        private Label label3;
        private TextBox password;
        private TextBox username1;
        private Button btnSignIn;
        private Button btnSignUp;
        private Label label2;
    }
}
