using System;
using System.Windows.Forms;

namespace Furion_Studio {
    public partial class AddSampleForm : Form {
        private static Sample res = null;

        public AddSampleForm() {
            InitializeComponent();
        }

        public static Sample ShowWindow(string title) {
            res = null;
            AddSampleForm f = new AddSampleForm();
            f.Text = title;
            f.ShowDialog();
            return res; 
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            res = new Sample((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Close();
        }
    }
}
