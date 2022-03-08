
namespace ClockApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clockLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SetMinutesTextBox = new System.Windows.Forms.TextBox();
            this.SetHourTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetButton2 = new System.Windows.Forms.Button();
            this.SetMinutesAlarmTxtBox2 = new System.Windows.Forms.TextBox();
            this.SetHourAlarmTxtBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.SetMinutesAlarmTxtBox = new System.Windows.Forms.TextBox();
            this.SetHoursAlarmTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clockLabel);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.SetMinutesTextBox);
            this.groupBox1.Controls.Add(this.SetHourTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(331, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock";
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(124, 120);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(82, 31);
            this.clockLabel.TabIndex = 5;
            this.clockLabel.Text = "00:00";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(130, 169);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SetMinutesTextBox
            // 
            this.SetMinutesTextBox.Location = new System.Drawing.Point(95, 89);
            this.SetMinutesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetMinutesTextBox.MaxLength = 2;
            this.SetMinutesTextBox.Name = "SetMinutesTextBox";
            this.SetMinutesTextBox.Size = new System.Drawing.Size(144, 20);
            this.SetMinutesTextBox.TabIndex = 3;
            this.SetMinutesTextBox.Text = "00";
            // 
            // SetHourTextBox
            // 
            this.SetHourTextBox.Location = new System.Drawing.Point(94, 37);
            this.SetHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetHourTextBox.MaxLength = 2;
            this.SetHourTextBox.Name = "SetHourTextBox";
            this.SetHourTextBox.Size = new System.Drawing.Size(144, 20);
            this.SetHourTextBox.TabIndex = 2;
            this.SetHourTextBox.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Hours:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetButton2);
            this.groupBox2.Controls.Add(this.SetMinutesAlarmTxtBox2);
            this.groupBox2.Controls.Add(this.SetHourAlarmTxtBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SetButton);
            this.groupBox2.Controls.Add(this.SetMinutesAlarmTxtBox);
            this.groupBox2.Controls.Add(this.SetHoursAlarmTxtBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(331, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarm";
            // 
            // SetButton2
            // 
            this.SetButton2.Location = new System.Drawing.Point(214, 133);
            this.SetButton2.Margin = new System.Windows.Forms.Padding(2);
            this.SetButton2.Name = "SetButton2";
            this.SetButton2.Size = new System.Drawing.Size(56, 23);
            this.SetButton2.TabIndex = 12;
            this.SetButton2.Text = "Set";
            this.SetButton2.UseVisualStyleBackColor = true;
            this.SetButton2.Click += new System.EventHandler(this.SetButton2_Click);
            // 
            // SetMinutesAlarmTxtBox2
            // 
            this.SetMinutesAlarmTxtBox2.Location = new System.Drawing.Point(160, 133);
            this.SetMinutesAlarmTxtBox2.Margin = new System.Windows.Forms.Padding(2);
            this.SetMinutesAlarmTxtBox2.MaxLength = 2;
            this.SetMinutesAlarmTxtBox2.Name = "SetMinutesAlarmTxtBox2";
            this.SetMinutesAlarmTxtBox2.Size = new System.Drawing.Size(23, 20);
            this.SetMinutesAlarmTxtBox2.TabIndex = 11;
            this.SetMinutesAlarmTxtBox2.Text = "00";
            // 
            // SetHourAlarmTxtBox2
            // 
            this.SetHourAlarmTxtBox2.Location = new System.Drawing.Point(118, 133);
            this.SetHourAlarmTxtBox2.Margin = new System.Windows.Forms.Padding(2);
            this.SetHourAlarmTxtBox2.MaxLength = 2;
            this.SetHourAlarmTxtBox2.Name = "SetHourAlarmTxtBox2";
            this.SetHourAlarmTxtBox2.Size = new System.Drawing.Size(23, 20);
            this.SetHourAlarmTxtBox2.TabIndex = 10;
            this.SetHourAlarmTxtBox2.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Set alarm 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alarm 2 is off";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alarm 1 is off";
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(214, 48);
            this.SetButton.Margin = new System.Windows.Forms.Padding(2);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(56, 23);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // SetMinutesAlarmTxtBox
            // 
            this.SetMinutesAlarmTxtBox.Location = new System.Drawing.Point(160, 48);
            this.SetMinutesAlarmTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetMinutesAlarmTxtBox.MaxLength = 2;
            this.SetMinutesAlarmTxtBox.Name = "SetMinutesAlarmTxtBox";
            this.SetMinutesAlarmTxtBox.Size = new System.Drawing.Size(23, 20);
            this.SetMinutesAlarmTxtBox.TabIndex = 3;
            this.SetMinutesAlarmTxtBox.Text = "00";
            // 
            // SetHoursAlarmTxtBox
            // 
            this.SetHoursAlarmTxtBox.Location = new System.Drawing.Point(118, 48);
            this.SetHoursAlarmTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetHoursAlarmTxtBox.MaxLength = 2;
            this.SetHoursAlarmTxtBox.Name = "SetHoursAlarmTxtBox";
            this.SetHoursAlarmTxtBox.Size = new System.Drawing.Size(23, 20);
            this.SetHoursAlarmTxtBox.TabIndex = 2;
            this.SetHoursAlarmTxtBox.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Set alarm 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(386, 467);
            this.Name = "Form1";
            this.Text = "ClockApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox SetMinutesTextBox;
        private System.Windows.Forms.TextBox SetHourTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox SetMinutesAlarmTxtBox;
        private System.Windows.Forms.TextBox SetHoursAlarmTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SetButton2;
        private System.Windows.Forms.TextBox SetMinutesAlarmTxtBox2;
        private System.Windows.Forms.TextBox SetHourAlarmTxtBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

