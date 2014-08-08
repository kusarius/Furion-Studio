﻿namespace Furion_Studio {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.samplesGridView = new System.Windows.Forms.DataGridView();
            this.samplesTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.buttonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pauseSoundButton = new System.Windows.Forms.Button();
            this.playSoundButton = new System.Windows.Forms.Button();
            this.openSoundButton = new System.Windows.Forms.Button();
            this.saveSoundButton = new System.Windows.Forms.Button();
            this.editSampleButton = new System.Windows.Forms.Button();
            this.removeSampleButton = new System.Windows.Forms.Button();
            this.addSampleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.samplesGridView)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // samplesGridView
            // 
            this.samplesGridView.AllowUserToAddRows = false;
            this.samplesGridView.AllowUserToDeleteRows = false;
            this.samplesGridView.AllowUserToResizeColumns = false;
            this.samplesGridView.AllowUserToResizeRows = false;
            this.samplesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.samplesGridView.BackgroundColor = System.Drawing.Color.White;
            this.samplesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.samplesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.samplesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samplesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.samplesTextBoxColumn});
            this.samplesGridView.GridColor = System.Drawing.SystemColors.Control;
            this.samplesGridView.Location = new System.Drawing.Point(-1, -1);
            this.samplesGridView.MultiSelect = false;
            this.samplesGridView.Name = "samplesGridView";
            this.samplesGridView.ReadOnly = true;
            this.samplesGridView.RowHeadersVisible = false;
            this.samplesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.samplesGridView.Size = new System.Drawing.Size(210, 273);
            this.samplesGridView.TabIndex = 1;
            // 
            // samplesTextBoxColumn
            // 
            this.samplesTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.samplesTextBoxColumn.HeaderText = "Список сэмплов";
            this.samplesTextBoxColumn.Name = "samplesTextBoxColumn";
            this.samplesTextBoxColumn.ReadOnly = true;
            this.samplesTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Controls.Add(this.pauseSoundButton);
            this.toolbarPanel.Controls.Add(this.playSoundButton);
            this.toolbarPanel.Controls.Add(this.label1);
            this.toolbarPanel.Controls.Add(this.openSoundButton);
            this.toolbarPanel.Controls.Add(this.separator1);
            this.toolbarPanel.Controls.Add(this.saveSoundButton);
            this.toolbarPanel.Controls.Add(this.editSampleButton);
            this.toolbarPanel.Controls.Add(this.removeSampleButton);
            this.toolbarPanel.Controls.Add(this.addSampleButton);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolbarPanel.Location = new System.Drawing.Point(209, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(30, 271);
            this.toolbarPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(0, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 1);
            this.label1.TabIndex = 5;
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.separator1.Location = new System.Drawing.Point(0, 93);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(30, 1);
            this.separator1.TabIndex = 3;
            // 
            // pauseSoundButton
            // 
            this.pauseSoundButton.BackgroundImage = global::Furion_Studio.Properties.Resources.pause__1_;
            this.pauseSoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseSoundButton.FlatAppearance.BorderSize = 0;
            this.pauseSoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pauseSoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.pauseSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseSoundButton.Location = new System.Drawing.Point(4, 196);
            this.pauseSoundButton.Name = "pauseSoundButton";
            this.pauseSoundButton.Size = new System.Drawing.Size(22, 22);
            this.pauseSoundButton.TabIndex = 7;
            this.buttonsToolTip.SetToolTip(this.pauseSoundButton, "Остановить мелодию");
            this.pauseSoundButton.UseVisualStyleBackColor = true;
            // 
            // playSoundButton
            // 
            this.playSoundButton.BackgroundImage = global::Furion_Studio.Properties.Resources.dc7epb8gi;
            this.playSoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playSoundButton.FlatAppearance.BorderSize = 0;
            this.playSoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.playSoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.playSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playSoundButton.Location = new System.Drawing.Point(4, 168);
            this.playSoundButton.Name = "playSoundButton";
            this.playSoundButton.Size = new System.Drawing.Size(22, 22);
            this.playSoundButton.TabIndex = 6;
            this.buttonsToolTip.SetToolTip(this.playSoundButton, "Играть мелодию");
            this.playSoundButton.UseVisualStyleBackColor = true;
            // 
            // openSoundButton
            // 
            this.openSoundButton.BackgroundImage = global::Furion_Studio.Properties.Resources.open_file;
            this.openSoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openSoundButton.FlatAppearance.BorderSize = 0;
            this.openSoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.openSoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.openSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSoundButton.Location = new System.Drawing.Point(4, 129);
            this.openSoundButton.Name = "openSoundButton";
            this.openSoundButton.Size = new System.Drawing.Size(22, 22);
            this.openSoundButton.TabIndex = 4;
            this.buttonsToolTip.SetToolTip(this.openSoundButton, "Открыть мелодию");
            this.openSoundButton.UseVisualStyleBackColor = true;
            // 
            // saveSoundButton
            // 
            this.saveSoundButton.BackgroundImage = global::Furion_Studio.Properties.Resources.save;
            this.saveSoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveSoundButton.FlatAppearance.BorderSize = 0;
            this.saveSoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.saveSoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.saveSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSoundButton.Location = new System.Drawing.Point(4, 101);
            this.saveSoundButton.Name = "saveSoundButton";
            this.saveSoundButton.Size = new System.Drawing.Size(22, 22);
            this.saveSoundButton.TabIndex = 3;
            this.buttonsToolTip.SetToolTip(this.saveSoundButton, "Сохранить мелодию");
            this.saveSoundButton.UseVisualStyleBackColor = true;
            // 
            // editSampleButton
            // 
            this.editSampleButton.BackgroundImage = global::Furion_Studio.Properties.Resources.edit;
            this.editSampleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editSampleButton.FlatAppearance.BorderSize = 0;
            this.editSampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.editSampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.editSampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSampleButton.Location = new System.Drawing.Point(4, 62);
            this.editSampleButton.Name = "editSampleButton";
            this.editSampleButton.Size = new System.Drawing.Size(22, 22);
            this.editSampleButton.TabIndex = 2;
            this.buttonsToolTip.SetToolTip(this.editSampleButton, "Редактировать сэмпл");
            this.editSampleButton.UseVisualStyleBackColor = true;
            // 
            // removeSampleButton
            // 
            this.removeSampleButton.BackgroundImage = global::Furion_Studio.Properties.Resources.minus;
            this.removeSampleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeSampleButton.FlatAppearance.BorderSize = 0;
            this.removeSampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.removeSampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.removeSampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSampleButton.Location = new System.Drawing.Point(4, 34);
            this.removeSampleButton.Name = "removeSampleButton";
            this.removeSampleButton.Size = new System.Drawing.Size(22, 22);
            this.removeSampleButton.TabIndex = 1;
            this.buttonsToolTip.SetToolTip(this.removeSampleButton, "Удалить сэмпл");
            this.removeSampleButton.UseVisualStyleBackColor = true;
            // 
            // addSampleButton
            // 
            this.addSampleButton.BackgroundImage = global::Furion_Studio.Properties.Resources.plus;
            this.addSampleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSampleButton.FlatAppearance.BorderSize = 0;
            this.addSampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.addSampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.addSampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSampleButton.Location = new System.Drawing.Point(4, 6);
            this.addSampleButton.Name = "addSampleButton";
            this.addSampleButton.Size = new System.Drawing.Size(22, 22);
            this.addSampleButton.TabIndex = 0;
            this.buttonsToolTip.SetToolTip(this.addSampleButton, "Добавить сэмпл");
            this.addSampleButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 271);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.samplesGridView);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 310);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Furion";
            ((System.ComponentModel.ISupportInitialize)(this.samplesGridView)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView samplesGridView;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn samplesTextBoxColumn;
        private System.Windows.Forms.Button addSampleButton;
        private System.Windows.Forms.Button editSampleButton;
        private System.Windows.Forms.Button removeSampleButton;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Button saveSoundButton;
        private System.Windows.Forms.ToolTip buttonsToolTip;
        private System.Windows.Forms.Button openSoundButton;
        private System.Windows.Forms.Button playSoundButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseSoundButton;
    }
}

