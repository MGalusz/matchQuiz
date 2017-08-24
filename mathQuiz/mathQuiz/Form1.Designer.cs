namespace mathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeFeltTextBox = new System.Windows.Forms.Label();
            this.plusSing = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.equalSing1 = new System.Windows.Forms.Label();
            this.equalSing2 = new System.Windows.Forms.Label();
            this.minusRightabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.minus = new System.Windows.Forms.Label();
            this.equalSing3 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.multiplySign = new System.Windows.Forms.Label();
            this.equalSing4 = new System.Windows.Forms.Label();
            this.difisionRightLabel = new System.Windows.Forms.Label();
            this.difisionLeftLabel = new System.Windows.Forms.Label();
            this.difision = new System.Windows.Forms.NumericUpDown();
            this.difisionSign = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difision)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeFeltTextBox
            // 
            this.timeFeltTextBox.AutoSize = true;
            this.timeFeltTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeFeltTextBox.Location = new System.Drawing.Point(142, 13);
            this.timeFeltTextBox.Name = "timeFeltTextBox";
            this.timeFeltTextBox.Size = new System.Drawing.Size(102, 26);
            this.timeFeltTextBox.TabIndex = 1;
            this.timeFeltTextBox.Text = "Time Left";
            // 
            // plusSing
            // 
            this.plusSing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusSing.Location = new System.Drawing.Point(78, 78);
            this.plusSing.Name = "plusSing";
            this.plusSing.Size = new System.Drawing.Size(60, 50);
            this.plusSing.TabIndex = 3;
            this.plusSing.Text = "+";
            this.plusSing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum.Location = new System.Drawing.Point(283, 88);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(60, 32);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.answerEnder);
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusLeftLabel.Location = new System.Drawing.Point(12, 78);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 7;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusRightLabel.Location = new System.Drawing.Point(142, 78);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 8;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSing1
            // 
            this.equalSing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalSing1.Location = new System.Drawing.Point(217, 78);
            this.equalSing1.Name = "equalSing1";
            this.equalSing1.Size = new System.Drawing.Size(60, 50);
            this.equalSing1.TabIndex = 9;
            this.equalSing1.Text = "=";
            this.equalSing1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSing2
            // 
            this.equalSing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalSing2.Location = new System.Drawing.Point(217, 137);
            this.equalSing2.Name = "equalSing2";
            this.equalSing2.Size = new System.Drawing.Size(60, 50);
            this.equalSing2.TabIndex = 14;
            this.equalSing2.Text = "=";
            this.equalSing2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightabel
            // 
            this.minusRightabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusRightabel.Location = new System.Drawing.Point(142, 137);
            this.minusRightabel.Name = "minusRightabel";
            this.minusRightabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightabel.TabIndex = 13;
            this.minusRightabel.Text = "?";
            this.minusRightabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusLeftLabel.Location = new System.Drawing.Point(12, 137);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 12;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difference.Location = new System.Drawing.Point(283, 147);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(60, 32);
            this.difference.TabIndex = 3;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.Location = new System.Drawing.Point(78, 137);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 50);
            this.minus.TabIndex = 10;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSing3
            // 
            this.equalSing3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalSing3.Location = new System.Drawing.Point(217, 198);
            this.equalSing3.Name = "equalSing3";
            this.equalSing3.Size = new System.Drawing.Size(60, 50);
            this.equalSing3.TabIndex = 19;
            this.equalSing3.Text = "=";
            this.equalSing3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel.Location = new System.Drawing.Point(142, 198);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 18;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel.Location = new System.Drawing.Point(12, 198);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 17;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.product.Location = new System.Drawing.Point(283, 208);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(60, 32);
            this.product.TabIndex = 4;
            // 
            // multiplySign
            // 
            this.multiplySign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplySign.Location = new System.Drawing.Point(78, 198);
            this.multiplySign.Name = "multiplySign";
            this.multiplySign.Size = new System.Drawing.Size(60, 50);
            this.multiplySign.TabIndex = 15;
            this.multiplySign.Text = "x";
            this.multiplySign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSing4
            // 
            this.equalSing4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalSing4.Location = new System.Drawing.Point(217, 260);
            this.equalSing4.Name = "equalSing4";
            this.equalSing4.Size = new System.Drawing.Size(60, 50);
            this.equalSing4.TabIndex = 24;
            this.equalSing4.Text = "=";
            this.equalSing4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difisionRightLabel
            // 
            this.difisionRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difisionRightLabel.Location = new System.Drawing.Point(142, 260);
            this.difisionRightLabel.Name = "difisionRightLabel";
            this.difisionRightLabel.Size = new System.Drawing.Size(60, 50);
            this.difisionRightLabel.TabIndex = 23;
            this.difisionRightLabel.Text = "?";
            this.difisionRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difisionLeftLabel
            // 
            this.difisionLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difisionLeftLabel.Location = new System.Drawing.Point(12, 260);
            this.difisionLeftLabel.Name = "difisionLeftLabel";
            this.difisionLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.difisionLeftLabel.TabIndex = 22;
            this.difisionLeftLabel.Text = "?";
            this.difisionLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difision
            // 
            this.difision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difision.Location = new System.Drawing.Point(283, 270);
            this.difision.Name = "difision";
            this.difision.Size = new System.Drawing.Size(60, 32);
            this.difision.TabIndex = 5;
            // 
            // difisionSign
            // 
            this.difisionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difisionSign.Location = new System.Drawing.Point(78, 260);
            this.difisionSign.Name = "difisionSign";
            this.difisionSign.Size = new System.Drawing.Size(60, 50);
            this.difisionSign.TabIndex = 20;
            this.difisionSign.Text = "÷";
            this.difisionSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(106, 313);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(237, 37);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start  the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.equalSing4);
            this.Controls.Add(this.difisionRightLabel);
            this.Controls.Add(this.difisionLeftLabel);
            this.Controls.Add(this.difision);
            this.Controls.Add(this.difisionSign);
            this.Controls.Add(this.equalSing3);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.multiplySign);
            this.Controls.Add(this.equalSing2);
            this.Controls.Add(this.minusRightabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.equalSing1);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusSing);
            this.Controls.Add(this.timeFeltTextBox);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Match Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeFeltTextBox;
        private System.Windows.Forms.Label plusSing;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label equalSing1;
        private System.Windows.Forms.Label equalSing2;
        private System.Windows.Forms.Label minusRightabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label equalSing3;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label multiplySign;
        private System.Windows.Forms.Label equalSing4;
        private System.Windows.Forms.Label difisionRightLabel;
        private System.Windows.Forms.Label difisionLeftLabel;
        private System.Windows.Forms.NumericUpDown difision;
        private System.Windows.Forms.Label difisionSign;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

