namespace WindowsFormsApp1
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SmallLetter = new System.Windows.Forms.CheckBox();
            this.CapitalLetter = new System.Windows.Forms.CheckBox();
            this.Numbers = new System.Windows.Forms.CheckBox();
            this.Symbols = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPasswordLength = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinNormal = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.buttonMinNormal);
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(803, 41);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password Generator";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(197, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 52);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SmallLetter
            // 
            this.SmallLetter.AutoSize = true;
            this.SmallLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallLetter.Location = new System.Drawing.Point(92, 202);
            this.SmallLetter.Name = "SmallLetter";
            this.SmallLetter.Size = new System.Drawing.Size(142, 28);
            this.SmallLetter.TabIndex = 2;
            this.SmallLetter.Text = "SmallLetters";
            this.SmallLetter.UseVisualStyleBackColor = true;
            this.SmallLetter.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // CapitalLetter
            // 
            this.CapitalLetter.AutoSize = true;
            this.CapitalLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalLetter.Location = new System.Drawing.Point(260, 202);
            this.CapitalLetter.Name = "CapitalLetter";
            this.CapitalLetter.Size = new System.Drawing.Size(160, 28);
            this.CapitalLetter.TabIndex = 2;
            this.CapitalLetter.Text = "Capital Letters";
            this.CapitalLetter.UseVisualStyleBackColor = true;
            this.CapitalLetter.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numbers.Location = new System.Drawing.Point(446, 202);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(114, 28);
            this.Numbers.TabIndex = 3;
            this.Numbers.Text = "Numbers";
            this.Numbers.UseVisualStyleBackColor = true;
            this.Numbers.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Symbols
            // 
            this.Symbols.AutoSize = true;
            this.Symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symbols.Location = new System.Drawing.Point(586, 202);
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(108, 28);
            this.Symbols.TabIndex = 4;
            this.Symbols.Text = "Symbols";
            this.Symbols.UseVisualStyleBackColor = true;
            this.Symbols.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(20, 52);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(477, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseEnter += new System.EventHandler(this.trackBar1_MouseEnter);
            this.trackBar1.MouseLeave += new System.EventHandler(this.trackBar1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Length =";
            // 
            // labelPasswordLength
            // 
            this.labelPasswordLength.AutoSize = true;
            this.labelPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLength.ForeColor = System.Drawing.Color.White;
            this.labelPasswordLength.Location = new System.Drawing.Point(196, 7);
            this.labelPasswordLength.Name = "labelPasswordLength";
            this.labelPasswordLength.Size = new System.Drawing.Size(30, 31);
            this.labelPasswordLength.TabIndex = 10;
            this.labelPasswordLength.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.labelPasswordLength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 100);
            this.panel1.TabIndex = 11;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Image = global::WindowsFormsApp1.Properties.Resources.icons8_mechanistic_analysis_35;
            this.buttonGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerate.Location = new System.Drawing.Point(433, 389);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(149, 49);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            this.buttonGenerate.MouseEnter += new System.EventHandler(this.buttonGenerate_MouseEnter);
            this.buttonGenerate.MouseLeave += new System.EventHandler(this.buttonGenerate_MouseLeave);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCopy.Image = global::WindowsFormsApp1.Properties.Resources.icons8;
            this.buttonCopy.Location = new System.Drawing.Point(586, 69);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(37, 37);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            this.buttonCopy.MouseEnter += new System.EventHandler(this.buttonCopy_MouseEnter);
            this.buttonCopy.MouseLeave += new System.EventHandler(this.buttonCopy_MouseLeave);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reset_391;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(197, 389);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(143, 49);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "  Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonReset.MouseEnter += new System.EventHandler(this.buttonReset_MouseEnter);
            this.buttonReset.MouseLeave += new System.EventHandler(this.buttonReset_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_show_password_41;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinNormal
            // 
            this.buttonMinNormal.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinNormal.FlatAppearance.BorderSize = 0;
            this.buttonMinNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinNormal.Image = global::WindowsFormsApp1.Properties.Resources.icons8_minimize_sign_32_removebg_preview1;
            this.buttonMinNormal.Location = new System.Drawing.Point(720, 3);
            this.buttonMinNormal.Name = "buttonMinNormal";
            this.buttonMinNormal.Size = new System.Drawing.Size(37, 35);
            this.buttonMinNormal.TabIndex = 9;
            this.buttonMinNormal.UseVisualStyleBackColor = false;
            this.buttonMinNormal.Click += new System.EventHandler(this.buttonMinNormal_Click);
            this.buttonMinNormal.DragLeave += new System.EventHandler(this.buttonMinNormal_DragLeave);
            this.buttonMinNormal.MouseEnter += new System.EventHandler(this.buttonMinNormal_MouseEnter);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::WindowsFormsApp1.Properties.Resources.icons8_minimize_262;
            this.buttonMinimize.Location = new System.Drawing.Point(677, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(37, 35);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.DragLeave += new System.EventHandler(this.buttonMinimize_DragLeave);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.buttonMinimize_MouseEnter);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_close_26;
            this.buttonClose.Location = new System.Drawing.Point(763, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 35);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.CapitalLetter);
            this.Controls.Add(this.SmallLetter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMinNormal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox SmallLetter;
        private System.Windows.Forms.CheckBox CapitalLetter;
        private System.Windows.Forms.CheckBox Numbers;
        private System.Windows.Forms.CheckBox Symbols;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPasswordLength;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCopy;
    }
}

