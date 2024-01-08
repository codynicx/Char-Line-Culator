namespace PageCalculator
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
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_Right = new System.Windows.Forms.Label();
            this.lbl_Left = new System.Windows.Forms.Label();
            this.lbl_Bottom = new System.Windows.Forms.Label();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_margin = new System.Windows.Forms.Label();
            this.lbl_Spacing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.comboBox_Spacing = new System.Windows.Forms.ComboBox();
            this.lblPointSize = new System.Windows.Forms.Label();
            this.txtPointSize = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.txtBottom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_length.ForeColor = System.Drawing.Color.White;
            this.lbl_length.Location = new System.Drawing.Point(28, 68);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(41, 13);
            this.lbl_length.TabIndex = 0;
            this.lbl_length.Text = "length";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.ForeColor = System.Drawing.Color.White;
            this.lbl_width.Location = new System.Drawing.Point(28, 96);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(37, 13);
            this.lbl_width.TabIndex = 1;
            this.lbl_width.Text = "width";
            this.lbl_width.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Right
            // 
            this.lbl_Right.AutoSize = true;
            this.lbl_Right.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Right.ForeColor = System.Drawing.Color.White;
            this.lbl_Right.Location = new System.Drawing.Point(28, 214);
            this.lbl_Right.Name = "lbl_Right";
            this.lbl_Right.Size = new System.Drawing.Size(35, 13);
            this.lbl_Right.TabIndex = 3;
            this.lbl_Right.Text = "Right";
            // 
            // lbl_Left
            // 
            this.lbl_Left.AutoSize = true;
            this.lbl_Left.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Left.ForeColor = System.Drawing.Color.White;
            this.lbl_Left.Location = new System.Drawing.Point(28, 170);
            this.lbl_Left.Name = "lbl_Left";
            this.lbl_Left.Size = new System.Drawing.Size(27, 13);
            this.lbl_Left.TabIndex = 4;
            this.lbl_Left.Text = "Left";
            // 
            // lbl_Bottom
            // 
            this.lbl_Bottom.AutoSize = true;
            this.lbl_Bottom.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bottom.ForeColor = System.Drawing.Color.White;
            this.lbl_Bottom.Location = new System.Drawing.Point(147, 221);
            this.lbl_Bottom.Name = "lbl_Bottom";
            this.lbl_Bottom.Size = new System.Drawing.Size(44, 13);
            this.lbl_Bottom.TabIndex = 5;
            this.lbl_Bottom.Text = "Bottom";
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Top.ForeColor = System.Drawing.Color.White;
            this.lbl_Top.Location = new System.Drawing.Point(160, 173);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(26, 13);
            this.lbl_Top.TabIndex = 6;
            this.lbl_Top.Text = "Top";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(71)))), ((int)(((byte)(28)))));
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(193, 293);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(71)))), ((int)(((byte)(28)))));
            this.btn_Calculate.FlatAppearance.BorderSize = 0;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("SF UI  Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Calculate.Location = new System.Drawing.Point(193, 328);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 11;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lbl_margin
            // 
            this.lbl_margin.AutoSize = true;
            this.lbl_margin.Font = new System.Drawing.Font("SF UI  Text 2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_margin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_margin.Location = new System.Drawing.Point(28, 139);
            this.lbl_margin.Name = "lbl_margin";
            this.lbl_margin.Size = new System.Drawing.Size(61, 18);
            this.lbl_margin.TabIndex = 13;
            this.lbl_margin.Text = "Margin";
            // 
            // lbl_Spacing
            // 
            this.lbl_Spacing.AutoSize = true;
            this.lbl_Spacing.Font = new System.Drawing.Font("SF UI  Text 2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Spacing.Location = new System.Drawing.Point(28, 307);
            this.lbl_Spacing.Name = "lbl_Spacing";
            this.lbl_Spacing.Size = new System.Drawing.Size(70, 18);
            this.lbl_Spacing.TabIndex = 14;
            this.lbl_Spacing.Text = "Spacing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF UI  Text 2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Size";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLength.Font = new System.Drawing.Font("SF UI  Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.ForeColor = System.Drawing.Color.Gray;
            this.txtLength.Location = new System.Drawing.Point(70, 60);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(196, 21);
            this.txtLength.TabIndex = 16;
            this.txtLength.Text = "Write length in inches";
            this.txtLength.Click += new System.EventHandler(this.txtLength_Click);
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.Color.AliceBlue;
            this.txtWidth.Font = new System.Drawing.Font("SF UI  Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.ForeColor = System.Drawing.Color.Gray;
            this.txtWidth.Location = new System.Drawing.Point(70, 96);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(196, 21);
            this.txtWidth.TabIndex = 17;
            this.txtWidth.Text = "Write width in inches";
            this.txtWidth.Click += new System.EventHandler(this.txtWidth_Click);
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // txtLeft
            // 
            this.txtLeft.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLeft.Location = new System.Drawing.Point(70, 166);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(71, 20);
            this.txtLeft.TabIndex = 19;
            this.txtLeft.Leave += new System.EventHandler(this.txtLeft_Leave);
            // 
            // comboBox_Spacing
            // 
            this.comboBox_Spacing.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox_Spacing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Spacing.Font = new System.Drawing.Font("SF UI  Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Spacing.FormattingEnabled = true;
            this.comboBox_Spacing.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.comboBox_Spacing.Location = new System.Drawing.Point(31, 328);
            this.comboBox_Spacing.Name = "comboBox_Spacing";
            this.comboBox_Spacing.Size = new System.Drawing.Size(116, 21);
            this.comboBox_Spacing.TabIndex = 22;
            this.comboBox_Spacing.SelectedIndexChanged += new System.EventHandler(this.comboBox_Spacing_SelectedIndexChanged);
            this.comboBox_Spacing.Click += new System.EventHandler(this.comboBox_Spacing_Click);
            // 
            // lblPointSize
            // 
            this.lblPointSize.AutoSize = true;
            this.lblPointSize.Font = new System.Drawing.Font("SF UI  Text 2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPointSize.Location = new System.Drawing.Point(26, 255);
            this.lblPointSize.Name = "lblPointSize";
            this.lblPointSize.Size = new System.Drawing.Size(82, 18);
            this.lblPointSize.TabIndex = 23;
            this.lblPointSize.Text = "Point Size";
            // 
            // txtPointSize
            // 
            this.txtPointSize.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPointSize.Location = new System.Drawing.Point(29, 276);
            this.txtPointSize.Name = "txtPointSize";
            this.txtPointSize.Size = new System.Drawing.Size(118, 20);
            this.txtPointSize.TabIndex = 24;
            this.txtPointSize.TextChanged += new System.EventHandler(this.txtPointSize_TextChanged);
            this.txtPointSize.Leave += new System.EventHandler(this.txtPointSize_Leave);
            // 
            // txtRight
            // 
            this.txtRight.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRight.Location = new System.Drawing.Point(70, 210);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(71, 20);
            this.txtRight.TabIndex = 18;
            this.txtRight.Leave += new System.EventHandler(this.txtRight_Leave);
            // 
            // txtTop
            // 
            this.txtTop.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTop.Location = new System.Drawing.Point(195, 166);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(71, 20);
            this.txtTop.TabIndex = 25;
            this.txtTop.Leave += new System.EventHandler(this.txtTop_Leave);
            // 
            // txtBottom
            // 
            this.txtBottom.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBottom.Location = new System.Drawing.Point(195, 214);
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(71, 20);
            this.txtBottom.TabIndex = 26;
            this.txtBottom.Leave += new System.EventHandler(this.txtBottom_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::PageCalculator.Properties.Resources.cal;
            this.pictureBox1.Location = new System.Drawing.Point(-97, -75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(118)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.btn_Calculate);
            this.panel1.Controls.Add(this.txtBottom);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.txtTop);
            this.panel1.Controls.Add(this.lblPointSize);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Controls.Add(this.lbl_Bottom);
            this.panel1.Controls.Add(this.lbl_Top);
            this.panel1.Controls.Add(this.txtLeft);
            this.panel1.Controls.Add(this.txtRight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_Spacing);
            this.panel1.Controls.Add(this.txtPointSize);
            this.panel1.Controls.Add(this.lbl_Spacing);
            this.panel1.Controls.Add(this.lbl_margin);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.lbl_Left);
            this.panel1.Controls.Add(this.lbl_Right);
            this.panel1.Controls.Add(this.lbl_width);
            this.panel1.Controls.Add(this.lbl_length);
            this.panel1.Location = new System.Drawing.Point(278, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 391);
            this.panel1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char-Line-Culator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_Right;
        private System.Windows.Forms.Label lbl_Left;
        private System.Windows.Forms.Label lbl_Bottom;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_margin;
        private System.Windows.Forms.Label lbl_Spacing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.ComboBox comboBox_Spacing;
        private System.Windows.Forms.Label lblPointSize;
        private System.Windows.Forms.TextBox txtPointSize;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.TextBox txtBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

