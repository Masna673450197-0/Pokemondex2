namespace pokemondeks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            PTB1 = new PictureBox();
            lblType = new Label();
            lblStatus = new Label();
            lblName = new Label();
            lblHP = new Label();
            lblDefense = new Label();
            lblAttack = new Label();
            lblSpecialAttack = new Label();
            lblSpecialDefense = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            lblSpeed = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)PTB1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 26);
            button1.Name = "button1";
            button1.Size = new Size(243, 54);
            button1.TabIndex = 0;
            button1.Text = "Pikachu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 104);
            button2.Name = "button2";
            button2.Size = new Size(243, 54);
            button2.TabIndex = 1;
            button2.Text = "Snorlax";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(58, 184);
            button3.Name = "button3";
            button3.Size = new Size(243, 54);
            button3.TabIndex = 2;
            button3.Text = "Lizardon";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(58, 271);
            button4.Name = "button4";
            button4.Size = new Size(243, 54);
            button4.TabIndex = 3;
            button4.Text = "Lizardo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(58, 358);
            button5.Name = "button5";
            button5.Size = new Size(243, 54);
            button5.TabIndex = 4;
            button5.Text = "Hitokage";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(58, 451);
            button6.Name = "button6";
            button6.Size = new Size(243, 54);
            button6.TabIndex = 5;
            button6.Text = "Kameil";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // PTB1
            // 
            PTB1.Location = new Point(614, 67);
            PTB1.Name = "PTB1";
            PTB1.Size = new Size(380, 251);
            PTB1.SizeMode = PictureBoxSizeMode.StretchImage;
            PTB1.TabIndex = 6;
            PTB1.TabStop = false;
            PTB1.Visible = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(779, 333);
            lblType.Name = "lblType";
            lblType.Size = new Size(41, 20);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            lblType.Visible = false;
            lblType.Click += label1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(909, 333);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(85, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Basic status";
            lblStatus.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(614, 333);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            lblName.Visible = false;
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.Location = new Point(909, 369);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(28, 20);
            lblHP.TabIndex = 10;
            lblHP.Text = "HP";
            lblHP.Visible = false;
            // 
            // lblDefense
            // 
            lblDefense.AutoSize = true;
            lblDefense.Location = new Point(909, 389);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(35, 20);
            lblDefense.TabIndex = 11;
            lblDefense.Text = "DEF";
            lblDefense.Visible = false;
            // 
            // lblAttack
            // 
            lblAttack.AutoSize = true;
            lblAttack.Location = new Point(909, 409);
            lblAttack.Name = "lblAttack";
            lblAttack.Size = new Size(36, 20);
            lblAttack.TabIndex = 12;
            lblAttack.Text = "ATK";
            lblAttack.Visible = false;
            // 
            // lblSpecialAttack
            // 
            lblSpecialAttack.AutoSize = true;
            lblSpecialAttack.Location = new Point(909, 429);
            lblSpecialAttack.Name = "lblSpecialAttack";
            lblSpecialAttack.Size = new Size(44, 20);
            lblSpecialAttack.TabIndex = 13;
            lblSpecialAttack.Text = "SATK";
            lblSpecialAttack.Visible = false;
            // 
            // lblSpecialDefense
            // 
            lblSpecialDefense.AutoSize = true;
            lblSpecialDefense.Location = new Point(909, 445);
            lblSpecialDefense.Name = "lblSpecialDefense";
            lblSpecialDefense.Size = new Size(43, 20);
            lblSpecialDefense.TabIndex = 14;
            lblSpecialDefense.Text = "SDEF";
            lblSpecialDefense.Visible = false;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(909, 465);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(54, 20);
            lblHeight.TabIndex = 15;
            lblHeight.Text = "Hieght";
            lblHeight.Visible = false;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(909, 485);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(57, 20);
            lblWeight.TabIndex = 16;
            lblWeight.Text = "Weight";
            lblWeight.Visible = false;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(909, 505);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(51, 20);
            lblSpeed.TabIndex = 17;
            lblSpeed.Text = "Speed";
            lblSpeed.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(909, 525);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(43, 20);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total";
            lblTotal.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 567);
            Controls.Add(lblTotal);
            Controls.Add(lblSpeed);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblSpecialDefense);
            Controls.Add(lblSpecialAttack);
            Controls.Add(lblAttack);
            Controls.Add(lblDefense);
            Controls.Add(lblHP);
            Controls.Add(lblName);
            Controls.Add(lblStatus);
            Controls.Add(lblType);
            Controls.Add(PTB1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PTB1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox PTB1;
        private Label lblType;
        private Label lblStatus;
        private Label lblName;
        private Label lblHP;
        private Label lblDefense;
        private Label lblAttack;
        private Label lblSpecialAttack;
        private Label lblSpecialDefense;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblSpeed;
        private Label lblTotal;
    }
}
