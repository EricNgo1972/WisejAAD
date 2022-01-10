namespace WisejAAD
{
	partial class Window1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Logout = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(382, 351);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(186, 41);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "LogOut";
            this.Logout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "login";
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Logout);
            this.Name = "Window1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.Button Logout;
        private Wisej.Web.Button button2;
    }
}

