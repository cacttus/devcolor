using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calc();
            _lblStatus.Text = "Developed by Derek Page (Armor Monkey Games)";
        }

        public double[] Color {  get {
                double[] f = new double[4];
                f[0] = (double)_btnPickColor.BackColor.R / 255.0;
                f[1] = (double)_btnPickColor.BackColor.G / 255.0;
                f[2] = (double)_btnPickColor.BackColor.B / 255.0;
                f[3] = (double)_btnPickColor.BackColor.A / 255.0;
                return f;
            }
        }
        private void _btnPickColor_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _btnPickColor.BackColor = cd.Color;
            }

            Calc();
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void Calc()
        {
            string text = "";


            byte[] bytes = new byte[4];
            bytes[0] = (byte)(Color[0] * 255.0f);
            bytes[1] = (byte)(Color[1] * 255.0f);
            bytes[2] = (byte)(Color[2] * 255.0f);
            bytes[3] = (byte)(Color[3] * 255.0f);

            if (_optFloat.Checked)
            {
                string fmt = "{0:0.";
                for (int i = 0; i < (int)_nudPrecis.Value; ++i)
                {
                    fmt += "0";
                }
                fmt += "}";

                text = "" + String.Format(fmt, Color[0]) + "f," +
                    String.Format(fmt, Color[1]) + "f," +
                    String.Format(fmt, Color[2]) + "f";
                if (_optRgba.Checked)
                {
                    text += "," + String.Format(fmt, Color[3]) + "f";
                }
            }
            else if (_optByte.Checked)
            {

                text = "" + bytes[0] + "," +
                     bytes[1] + "," +
                      bytes[2] + ",";
                if (_optRgba.Checked)
                {
                    text += bytes[3] + "";
                }
            }
            else if (_optDouble.Checked)
            {
                string fmt = "{0:0.000000000000000}";
                text = "" + String.Format(fmt, Color[0]) + "," +
                    String.Format(fmt, Color[1]) + "," +
                    String.Format(fmt, Color[2]);
                if (_optRgba.Checked)
                {
                    text += "," + String.Format(fmt, Color[3]);
                }
            }
            else if (_optHex.Checked)
            {
                if (_optRgb.Checked)
                {
                    text = "0x" + BitConverter.ToString(new byte[] { bytes[0], bytes[1], bytes[2] }).Replace("-", string.Empty); ;
                }
                else
                {
                    text = "0x" + BitConverter.ToString(bytes).Replace("-", string.Empty); ;
                }
            }
            _txtOutput.Text = text;
        }

        private void _optRgb_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void _optRgba_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void _btnCopyFloat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_txtOutput.Text) == false)
            {
                Clipboard.SetText(_txtOutput.Text);
                _lblStatus.Text = "Copied to clipboard.";
            }
            else
            {
                _lblStatus.Text = "No data to copy to clipboard.";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _optFloat_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void _optByte_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void _optHex_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void _optDouble_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Form4 _frmSwatches = new Form4();

        private void swatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmSwatches.Show();
        }

        private void _nudPrecis_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
