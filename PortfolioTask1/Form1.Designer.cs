namespace PortfolioTask1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Josn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JosnOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Josn
            // 
            this.Josn.Location = new System.Drawing.Point(12, 415);
            this.Josn.Name = "Josn";
            this.Josn.Size = new System.Drawing.Size(75, 23);
            this.Josn.TabIndex = 0;
            this.Josn.Text = "Josn";
            this.Josn.UseVisualStyleBackColor = true;
            this.Josn.Click += new System.EventHandler(this.Josn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // JosnOutput
            // 
            this.JosnOutput.Location = new System.Drawing.Point(125, 417);
            this.JosnOutput.Name = "JosnOutput";
            this.JosnOutput.Size = new System.Drawing.Size(663, 21);
            this.JosnOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JosnOutput);
            this.Controls.Add(this.Josn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Josn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox JosnOutput;
    }
}

