using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furion_Studio {
    public partial class MainForm : Form {
        List<Sample> samples = new List<Sample>();
        bool pause = false;

        public MainForm() {
            InitializeComponent();
        }

        private void addSampleButton_Click(object sender, EventArgs e) {
            Sample s = AddEditSampleForm.ShowWindow("Добавить сэмпл", 16, 1);
            if (s != null) {
                samplesGridView.Rows.Add(string.Format("{0} Гц, {1} мс", s.Frequency, s.Duration));
                samples.Add(s);
            }
        }

        private void removeSampleButton_Click(object sender, EventArgs e) {
            if (samplesGridView.SelectedRows.Count != 0) {
                samplesGridView.Rows.Remove(samplesGridView.SelectedRows[0]);
                if (samples.Count == 1) samples.Clear();
                else samples.RemoveAt(samplesGridView.SelectedRows[0].Index);
            }
        }

        private void editSampleButton_Click(object sender, EventArgs e) {
            string[] rowtext = samplesGridView.SelectedRows[0].Cells[0].Value.ToString().Split(',');
            Sample s = AddEditSampleForm.ShowWindow("Редактировать сэмпл",
                int.Parse(rowtext[0].Substring(0, rowtext[0].Length - 3)),
                int.Parse(rowtext[1].Substring(0, rowtext[1].Length - 3)));

            if (s != null) {
                samples[samplesGridView.SelectedRows[0].Index] = s;
                samplesGridView.SelectedRows[0].Cells[0].Value = string.Format("{0} Гц, {1} мс",
                    s.Frequency, s.Duration);
            }
        }

        private void playSoundButton_Click(object sender, EventArgs e) {
            if (pause) pause = false;
            new Task(() => {
                for (int i = samplesGridView.SelectedRows[0].Index; i < samples.Count; i++) 
                    if (!pause) {
                        samples[i].Play();
                        samplesGridView.Rows[i + 1].Selected = true;
                    }
            }).Start();
        }

        private void pauseSoundButton_Click(object sender, EventArgs e) {
            pause = true;
        }
    }
}