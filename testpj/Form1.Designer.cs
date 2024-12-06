namespace testpj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.btnPP = new System.Windows.Forms.Button();
            this.txtOP = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnOP = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 99;
            this.label3.Text = "Output Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 99;
            this.label2.Text = "Input Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 99;
            this.label1.Text = "Python Path";
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(12, 40);
            this.txtPP.Name = "txtPP";
            this.txtPP.ReadOnly = true;
            this.txtPP.Size = new System.Drawing.Size(325, 21);
            this.txtPP.TabIndex = 3;
            // 
            // btnPP
            // 
            this.btnPP.Image = ((System.Drawing.Image)(resources.GetObject("btnPP.Image")));
            this.btnPP.Location = new System.Drawing.Point(343, 40);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(33, 23);
            this.btnPP.TabIndex = 0;
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // txtOP
            // 
            this.txtOP.Location = new System.Drawing.Point(12, 132);
            this.txtOP.Name = "txtOP";
            this.txtOP.ReadOnly = true;
            this.txtOP.Size = new System.Drawing.Size(325, 21);
            this.txtOP.TabIndex = 5;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 86);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(325, 21);
            this.txtIP.TabIndex = 4;
            // 
            // btnOP
            // 
            this.btnOP.Image = ((System.Drawing.Image)(resources.GetObject("btnOP.Image")));
            this.btnOP.Location = new System.Drawing.Point(343, 132);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(33, 23);
            this.btnOP.TabIndex = 2;
            this.btnOP.UseVisualStyleBackColor = true;
            this.btnOP.Click += new System.EventHandler(this.btnOP_Click);
            // 
            // btnIP
            // 
            this.btnIP.Image = ((System.Drawing.Image)(resources.GetObject("btnIP.Image")));
            this.btnIP.Location = new System.Drawing.Point(343, 84);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(33, 23);
            this.btnIP.TabIndex = 1;
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.txtOP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnOP);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Analyze Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.TextBox txtOP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnOP;
        private System.Windows.Forms.Button btnIP;
    }
}

