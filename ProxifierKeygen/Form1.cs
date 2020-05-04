using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxifierKeygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            buttonGenerate_Click(sender, e);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int expDate = 0;
            string customKeyPart = null;
            if (checkBoxCustomKeyPart.Checked)
            {
                customKeyPart = textBoxCustomKeyPart.Text;
            }
            if (checkBoxExpiration.Checked)
            {
                expDate = (dateTimePicker1.Value.Year - 2000) * 12 + dateTimePicker1.Value.Month - 1;
            }
            textBoxKeyOutput.Text = Keygen.GenerateKey(comboBox1.SelectedIndex, customKeyPart, expDate);
            Clipboard.SetText(textBoxKeyOutput.Text);
        }
        
        private void checkBoxCustomKeyPart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomKeyPart.Checked)
            {
                textBoxCustomKeyPart.Enabled = true;
                if (textBoxCustomKeyPart.Text.Length != 5)
                    buttonGenerate.Enabled = false;
                textBoxCustomKeyPart.Focus();
            }
            else
            {
                textBoxCustomKeyPart.Enabled = false;
                buttonGenerate.Enabled = true;
            }
        }

        private void checkBoxExpiration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExpiration.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }
        
        private void textBoxCustomKeyPart_TextChanged(object sender, EventArgs e)
        {
            var cursorPosition = textBoxCustomKeyPart.SelectionStart;
            textBoxCustomKeyPart.Text = string.Concat(textBoxCustomKeyPart.Text.Where(char.IsLetterOrDigit)).ToUpper();
            textBoxCustomKeyPart.SelectionStart = cursorPosition;
            if (textBoxCustomKeyPart.Text.Length == 5)
            {
                buttonGenerate.Enabled = true;
            }
            else
            {
                buttonGenerate.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
