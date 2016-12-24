namespace MiYABiS.Study.インタフェースの扱い.CS
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(216, 63);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(54, 23);
            this.Button4.TabIndex = 13;
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Visible = false;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(148, 63);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(54, 23);
            this.Button3.TabIndex = 12;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Visible = false;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(80, 63);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(54, 23);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "-";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 63);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(54, 23);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "+";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(12, 92);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(260, 19);
            this.txtAns.TabIndex = 9;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(12, 38);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(260, 19);
            this.txtValue2.TabIndex = 8;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(12, 13);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(260, 19);
            this.txtValue1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtAns;
        internal System.Windows.Forms.TextBox txtValue2;
        internal System.Windows.Forms.TextBox txtValue1;
    }
}

