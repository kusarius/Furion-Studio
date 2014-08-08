using System;
using System.Windows.Forms;

namespace Furion_Studio {
    public partial class AddEditSampleForm : Form {
        private static Sample res = null;

        public AddEditSampleForm() {
            InitializeComponent();
        }

        public static Sample ShowWindow(string title, int v1, int v2) {
            res = null;
            AddEditSampleForm f = new AddEditSampleForm();
            f.numericUpDown1.Value = v1;
            f.numericUpDown2.Value = v2;
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

        private void button3_Click(object sender, EventArgs e) {
            int val = SelectNoteForm.ShowWindow();
            if (val > -1) numericUpDown1.Value = val;
        }
    }
}
