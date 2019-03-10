namespace DevColor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._btnPickColor = new System.Windows.Forms.Button();
            this._optRgb = new System.Windows.Forms.RadioButton();
            this._optRgba = new System.Windows.Forms.RadioButton();
            this._txtOutput = new System.Windows.Forms.TextBox();
            this._btnCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._optFloat = new System.Windows.Forms.RadioButton();
            this._optByte = new System.Windows.Forms.RadioButton();
            this._optHex = new System.Windows.Forms.RadioButton();
            this._optDouble = new System.Windows.Forms.RadioButton();
            this._nudPrecis = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPrecis)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnPickColor
            // 
            this._btnPickColor.BackColor = System.Drawing.Color.Yellow;
            this._btnPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPickColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnPickColor.Location = new System.Drawing.Point(69, 28);
            this._btnPickColor.Name = "_btnPickColor";
            this._btnPickColor.Size = new System.Drawing.Size(127, 69);
            this._btnPickColor.TabIndex = 1;
            this._btnPickColor.UseVisualStyleBackColor = false;
            this._btnPickColor.Click += new System.EventHandler(this._btnPickColor_Click);
            // 
            // _optRgb
            // 
            this._optRgb.AutoSize = true;
            this._optRgb.Location = new System.Drawing.Point(24, 9);
            this._optRgb.Name = "_optRgb";
            this._optRgb.Size = new System.Drawing.Size(55, 20);
            this._optRgb.TabIndex = 5;
            this._optRgb.Text = "RGB";
            this._optRgb.UseVisualStyleBackColor = true;
            this._optRgb.CheckedChanged += new System.EventHandler(this._optRgb_CheckedChanged);
            // 
            // _optRgba
            // 
            this._optRgba.AutoSize = true;
            this._optRgba.Checked = true;
            this._optRgba.Location = new System.Drawing.Point(87, 9);
            this._optRgba.Name = "_optRgba";
            this._optRgba.Size = new System.Drawing.Size(64, 20);
            this._optRgba.TabIndex = 5;
            this._optRgba.TabStop = true;
            this._optRgba.Text = "RGBA";
            this._optRgba.UseVisualStyleBackColor = true;
            this._optRgba.CheckedChanged += new System.EventHandler(this._optRgba_CheckedChanged);
            // 
            // _txtOutput
            // 
            this._txtOutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtOutput.Location = new System.Drawing.Point(43, 229);
            this._txtOutput.Multiline = true;
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.Size = new System.Drawing.Size(209, 76);
            this._txtOutput.TabIndex = 2;
            // 
            // _btnCopy
            // 
            this._btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnCopy.BackgroundImage")));
            this._btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCopy.Location = new System.Drawing.Point(12, 229);
            this._btnCopy.Name = "_btnCopy";
            this._btnCopy.Size = new System.Drawing.Size(25, 23);
            this._btnCopy.TabIndex = 4;
            this._btnCopy.UseVisualStyleBackColor = true;
            this._btnCopy.Click += new System.EventHandler(this._btnCopyFloat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._optRgb);
            this.groupBox1.Controls.Add(this._optRgba);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 33);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._nudPrecis);
            this.groupBox2.Controls.Add(this._optDouble);
            this.groupBox2.Controls.Add(this._optHex);
            this.groupBox2.Controls.Add(this._optByte);
            this.groupBox2.Controls.Add(this._optFloat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(268, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // _optFloat
            // 
            this._optFloat.AutoSize = true;
            this._optFloat.Checked = true;
            this._optFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optFloat.Location = new System.Drawing.Point(7, 20);
            this._optFloat.Name = "_optFloat";
            this._optFloat.Size = new System.Drawing.Size(51, 20);
            this._optFloat.TabIndex = 0;
            this._optFloat.TabStop = true;
            this._optFloat.Text = "float";
            this._optFloat.UseVisualStyleBackColor = true;
            this._optFloat.CheckedChanged += new System.EventHandler(this._optFloat_CheckedChanged);
            // 
            // _optByte
            // 
            this._optByte.AutoSize = true;
            this._optByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optByte.Location = new System.Drawing.Point(96, 20);
            this._optByte.Name = "_optByte";
            this._optByte.Size = new System.Drawing.Size(52, 20);
            this._optByte.TabIndex = 0;
            this._optByte.Text = "byte";
            this._optByte.UseVisualStyleBackColor = true;
            this._optByte.CheckedChanged += new System.EventHandler(this._optByte_CheckedChanged);
            // 
            // _optHex
            // 
            this._optHex.AutoSize = true;
            this._optHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHex.Location = new System.Drawing.Point(150, 20);
            this._optHex.Name = "_optHex";
            this._optHex.Size = new System.Drawing.Size(47, 20);
            this._optHex.TabIndex = 0;
            this._optHex.Text = "hex";
            this._optHex.UseVisualStyleBackColor = true;
            this._optHex.CheckedChanged += new System.EventHandler(this._optHex_CheckedChanged);
            // 
            // _optDouble
            // 
            this._optDouble.AutoSize = true;
            this._optDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optDouble.Location = new System.Drawing.Point(6, 46);
            this._optDouble.Name = "_optDouble";
            this._optDouble.Size = new System.Drawing.Size(68, 20);
            this._optDouble.TabIndex = 0;
            this._optDouble.Text = "double";
            this._optDouble.UseVisualStyleBackColor = true;
            this._optDouble.CheckedChanged += new System.EventHandler(this._optDouble_CheckedChanged);
            // 
            // _nudPrecis
            // 
            this._nudPrecis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nudPrecis.Location = new System.Drawing.Point(57, 20);
            this._nudPrecis.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this._nudPrecis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudPrecis.Name = "_nudPrecis";
            this._nudPrecis.Size = new System.Drawing.Size(33, 22);
            this._nudPrecis.TabIndex = 14;
            this._nudPrecis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nudPrecis.ValueChanged += new System.EventHandler(this._nudPrecis_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(268, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swatchesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // swatchesToolStripMenuItem
            // 
            this.swatchesToolStripMenuItem.Name = "swatchesToolStripMenuItem";
            this.swatchesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.swatchesToolStripMenuItem.Text = "Swatches";
            this.swatchesToolStripMenuItem.Click += new System.EventHandler(this.swatchesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 339);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnCopy);
            this.Controls.Add(this._txtOutput);
            this.Controls.Add(this._btnPickColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Programmer\'s Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPrecis)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnPickColor;
        private System.Windows.Forms.RadioButton _optRgb;
        private System.Windows.Forms.RadioButton _optRgba;
        private System.Windows.Forms.TextBox _txtOutput;
        private System.Windows.Forms.Button _btnCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
        private System.Windows.Forms.RadioButton _optDouble;
        private System.Windows.Forms.RadioButton _optHex;
        private System.Windows.Forms.RadioButton _optByte;
        private System.Windows.Forms.RadioButton _optFloat;
        private System.Windows.Forms.NumericUpDown _nudPrecis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swatchesToolStripMenuItem;
    }
}

