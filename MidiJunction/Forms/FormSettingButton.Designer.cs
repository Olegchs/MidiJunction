﻿namespace MidiJunction.Forms
{
  partial class FormSettingButton
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
      this.cancelButton = new System.Windows.Forms.Button();
      this.okButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(280, 133);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 25);
      this.cancelButton.TabIndex = 70;
      this.cancelButton.Text = "Cancel";
      // 
      // okButton
      // 
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Location = new System.Drawing.Point(196, 133);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(78, 25);
      this.okButton.TabIndex = 69;
      this.okButton.Text = "OK";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 71;
      this.label1.Text = "Instrument Name";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(28, 41);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(327, 20);
      this.textBox1.TabIndex = 72;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(25, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 73;
      this.label2.Text = "MIDI Virtual Bus";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Bus A",
            "Bus B",
            "Bus C",
            "Bus D"});
      this.comboBox1.Location = new System.Drawing.Point(28, 94);
      this.comboBox1.MaxDropDownItems = 4;
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 74;
      // 
      // comboBox2
      // 
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
      this.comboBox2.Location = new System.Drawing.Point(176, 94);
      this.comboBox2.MaxDropDownItems = 16;
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(179, 21);
      this.comboBox2.TabIndex = 76;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(173, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 13);
      this.label3.TabIndex = 75;
      this.label3.Text = "MIDI Channel";
      // 
      // FormSettingButton
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(382, 180);
      this.ControlBox = false;
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormSettingButton";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Edit device name";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Label label3;
  }
}