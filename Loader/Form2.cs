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

using Microsoft.Win32;

namespace Loader {
	public partial class Form2 : MetroForm {
		public Form2() {
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e) {
			// Opening our key
			RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + "Ayyhook");

			// If it does exist, retrieve the stored values
			if (Key != null) {
				this.metroTextBox1.Text = (string) Key.GetValue("Username");
				this.metroTextBox2.Text = (string) Key.GetValue("Password");
			}
		}

		private void metroButton1_Click(object sender, EventArgs e) {

		}

		private void metroButton2_Click(object sender, EventArgs e) {

		}

		private void metroButton3_Click(object sender, EventArgs e) {

		}
	}
}