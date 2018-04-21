using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace Loader {
	public partial class Form1 : MetroForm {
		public Form1() {
			InitializeComponent();

			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e) {
			this.timer1.Stop();

			this.metroProgressBar1.Value = 100;

			if (this.metroProgressBar1.Value == 100) {
				this.Hide();
				Form2 Form2 = new Form2();
				Form2.Show();
			}
		}
	}
}
