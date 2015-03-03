namespace KWIC_Shared
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNoise = new System.Windows.Forms.Label();
            this.txtNoise = new System.Windows.Forms.TextBox();
            this.chkReplace = new System.Windows.Forms.CheckBox();
            this.chkNoise = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(18, 30);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Tag = "lblInput";
            this.lblInput.Text = "Input";
            this.lblInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(18, 104);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Tag = "lblOutput";
            this.lblOutput.Text = "Output";
            this.lblOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(83, 205);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(83, 45);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(98, 27);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(275, 68);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(98, 101);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(275, 68);
            this.txtOutput.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNoise
            // 
            this.lblNoise.AutoSize = true;
            this.lblNoise.Location = new System.Drawing.Point(488, 30);
            this.lblNoise.Name = "lblNoise";
            this.lblNoise.Size = new System.Drawing.Size(90, 13);
            this.lblNoise.TabIndex = 5;
            this.lblNoise.Text = "Add Noise Words";
            // 
            // txtNoise
            // 
            this.txtNoise.Enabled = false;
            this.txtNoise.Location = new System.Drawing.Point(446, 56);
            this.txtNoise.Multiline = true;
            this.txtNoise.Name = "txtNoise";
            this.txtNoise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoise.Size = new System.Drawing.Size(196, 149);
            this.txtNoise.TabIndex = 6;
            // 
            // chkReplace
            // 
            this.chkReplace.AutoSize = true;
            this.chkReplace.Enabled = false;
            this.chkReplace.Location = new System.Drawing.Point(446, 244);
            this.chkReplace.Name = "chkReplace";
            this.chkReplace.Size = new System.Drawing.Size(100, 17);
            this.chkReplace.TabIndex = 7;
            this.chkReplace.Text = "Replace Words";
            this.chkReplace.UseVisualStyleBackColor = true;
            // 
            // chkNoise
            // 
            this.chkNoise.AutoSize = true;
            this.chkNoise.Location = new System.Drawing.Point(446, 220);
            this.chkNoise.Name = "chkNoise";
            this.chkNoise.Size = new System.Drawing.Size(130, 17);
            this.chkNoise.TabIndex = 7;
            this.chkNoise.Text = "Remove Noise Words";
            this.chkNoise.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 273);
            this.Controls.Add(this.chkNoise);
            this.Controls.Add(this.chkReplace);
            this.Controls.Add(this.txtNoise);
            this.Controls.Add(this.lblNoise);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Tag = "lblInput";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNoise;
        private System.Windows.Forms.TextBox txtNoise;
        private System.Windows.Forms.CheckBox chkReplace;
        private System.Windows.Forms.CheckBox chkNoise;
    }
}

