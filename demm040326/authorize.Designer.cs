namespace demm040326
{
    partial class authorize
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
            components = new System.ComponentModel.Container();
            txtLogin = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            bindingSource1 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            userBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(167, 97);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(167, 149);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(180, 206);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "button1";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Models.User);
            // 
            // authorize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtLogin);
            Name = "authorize";
            Text = "authorize";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPass;
        private Button btnLogin;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
        public BindingSource bindingSource1;
    }
}