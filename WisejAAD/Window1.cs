
using System;
using Wisej.Web;

namespace WisejAAD
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
			this.Text = Wisej.Web.Application.User?.Identity?.Name;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Wisej.Web.Application.Navigate("https://localhost:44386/Login.aspx");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
			Wisej.Web.Application.Navigate("https://localhost:44386/Logout.aspx");
		}
    }
}
