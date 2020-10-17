namespace Simple_calculator
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.result_box = new System.Windows.Forms.RichTextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Squared = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("굴림", 30.00002F);
            this.button7.Location = new System.Drawing.Point(12, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("굴림", 30F);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(88, 92);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("굴림", 30F);
            this.button9.Location = new System.Drawing.Point(164, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("굴림", 30F);
            this.button4.Location = new System.Drawing.Point(12, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("굴림", 30F);
            this.button5.Location = new System.Drawing.Point(88, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("굴림", 30F);
            this.button6.Location = new System.Drawing.Point(164, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("굴림", 30F);
            this.button1.Location = new System.Drawing.Point(12, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("굴림", 30F);
            this.button2.Location = new System.Drawing.Point(88, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("굴림", 30F);
            this.button3.Location = new System.Drawing.Point(164, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Salmon;
            this.Plus.Font = new System.Drawing.Font("굴림", 30F);
            this.Plus.Location = new System.Drawing.Point(240, 92);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(135, 70);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Salmon;
            this.Minus.Font = new System.Drawing.Font("굴림", 30F);
            this.Minus.Location = new System.Drawing.Point(240, 168);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(135, 70);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiple
            // 
            this.Multiple.BackColor = System.Drawing.Color.Salmon;
            this.Multiple.Font = new System.Drawing.Font("굴림", 30F);
            this.Multiple.Location = new System.Drawing.Point(240, 244);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(135, 70);
            this.Multiple.TabIndex = 12;
            this.Multiple.Text = "×";
            this.Multiple.UseVisualStyleBackColor = false;
            this.Multiple.Click += new System.EventHandler(this.Multiple_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Salmon;
            this.Division.Font = new System.Drawing.Font("굴림", 30F);
            this.Division.Location = new System.Drawing.Point(240, 319);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(135, 70);
            this.Division.TabIndex = 13;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // equal_button
            // 
            this.equal_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.equal_button.Font = new System.Drawing.Font("굴림", 30F);
            this.equal_button.Location = new System.Drawing.Point(381, 92);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(70, 146);
            this.equal_button.TabIndex = 14;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = false;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // result_box
            // 
            this.result_box.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_box.Location = new System.Drawing.Point(15, 12);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(426, 75);
            this.result_box.TabIndex = 15;
            this.result_box.Text = "\n";
            this.result_box.TextChanged += new System.EventHandler(this.result_box_TextChanged);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button0.Font = new System.Drawing.Font("굴림", 30F);
            this.button0.Location = new System.Drawing.Point(88, 320);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 70);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("굴림", 30F);
            this.Clear.Location = new System.Drawing.Point(12, 320);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(70, 70);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("굴림", 18F);
            this.Delete.Location = new System.Drawing.Point(164, 320);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(70, 70);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Del";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Squared
            // 
            this.Squared.BackColor = System.Drawing.Color.Cyan;
            this.Squared.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Squared.Location = new System.Drawing.Point(381, 244);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(70, 143);
            this.Squared.TabIndex = 19;
            this.Squared.Text = "x²";
            this.Squared.UseVisualStyleBackColor = false;
            this.Squared.Click += new System.EventHandler(this.Squared_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(457, 399);
            this.Controls.Add(this.Squared);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiple;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.RichTextBox result_box;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Squared;
    }
}

