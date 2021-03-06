﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Creator
{
    class InputPrompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form();
            prompt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            prompt.Width = 250;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 10, Top = 35, Width = 210 };
            textBox.Text = defaultValue;
            Button confirmation = new Button() { Text = "OK", Left = 10, Width = 60, Top = 70 };
            Button cancel = new Button() { Text = "Cancel", Left = 90, Width = 60, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.DialogResult = DialogResult.Cancel; prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            DialogResult Result = prompt.ShowDialog();
            if (Result == DialogResult.Cancel)
                return null;
            if (Result == DialogResult.OK)
                return textBox.Text;
            else
                return null;
        }
    }
}
