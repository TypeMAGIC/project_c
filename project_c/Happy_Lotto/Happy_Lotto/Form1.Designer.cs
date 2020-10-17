namespace Happy_Lotto
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.R1 = new System.Windows.Forms.RichTextBox();
            this.R6 = new System.Windows.Forms.RichTextBox();
            this.R5 = new System.Windows.Forms.RichTextBox();
            this.R4 = new System.Windows.Forms.RichTextBox();
            this.R3 = new System.Windows.Forms.RichTextBox();
            this.R2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("궁서", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(277, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "로또 번호 뽑기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(67, 12);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(99, 96);
            this.R1.TabIndex = 1;
            this.R1.Text = "";
            // 
            // R6
            // 
            this.R6.Location = new System.Drawing.Point(592, 12);
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(99, 96);
            this.R6.TabIndex = 2;
            this.R6.Text = "";
            // 
            // R5
            // 
            this.R5.Location = new System.Drawing.Point(487, 12);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(99, 96);
            this.R5.TabIndex = 3;
            this.R5.Text = "";
            // 
            // R4
            // 
            this.R4.Location = new System.Drawing.Point(382, 12);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(99, 96);
            this.R4.TabIndex = 4;
            this.R4.Text = "";
            // 
            // R3
            // 
            this.R3.Location = new System.Drawing.Point(277, 12);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(99, 96);
            this.R3.TabIndex = 5;
            this.R3.Text = "";
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(172, 12);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(99, 96);
            this.R2.TabIndex = 6;
            this.R2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R4);
            this.Controls.Add(this.R5);
            this.Controls.Add(this.R6);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox R1;
        private System.Windows.Forms.RichTextBox R6;
        private System.Windows.Forms.RichTextBox R5;
        private System.Windows.Forms.RichTextBox R4;
        private System.Windows.Forms.RichTextBox R3;
        private System.Windows.Forms.RichTextBox R2;
    }
}

