using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Furion_Studio {
    public partial class SelectNoteForm : Form {
        private static int res = -1;
        private int[] notesOn1Ok = new int[12];

        public SelectNoteForm() {
            InitializeComponent();

            notesOn1Ok[0] = 262; // Частота звука ноты До первой октавы
            for (int i = 1; i < 12; i++)
                // Интервал в полутон имеет соотношение частот 1 : 2 ^ (1 / 12)
                notesOn1Ok[i] = (int)(notesOn1Ok[i - 1] * Math.Pow(2, 0.083));
        }

        public static int ShowWindow() {
            res = -1;
            SelectNoteForm f = new SelectNoteForm();
            f.ShowDialog();
            return res;
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            res = notesOn1Ok[comboBox1.SelectedIndex] * ((int)(Math.Pow(2, (double)numericUpDown1.Value)) / 2);
            Close();
        }
    }
}
