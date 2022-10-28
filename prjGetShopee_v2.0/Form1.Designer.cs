
namespace prjGetShopee_v2._0
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetPanasonic = new System.Windows.Forms.Button();
            this.btnGetSmallTpye = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetPanasonic
            // 
            this.btnGetPanasonic.Location = new System.Drawing.Point(104, 215);
            this.btnGetPanasonic.Name = "btnGetPanasonic";
            this.btnGetPanasonic.Size = new System.Drawing.Size(97, 42);
            this.btnGetPanasonic.TabIndex = 0;
            this.btnGetPanasonic.Text = "GetPanasonic";
            this.btnGetPanasonic.UseVisualStyleBackColor = true;
            this.btnGetPanasonic.Click += new System.EventHandler(this.btnGetPanasonic_Click);
            // 
            // btnGetSmallTpye
            // 
            this.btnGetSmallTpye.Location = new System.Drawing.Point(104, 286);
            this.btnGetSmallTpye.Name = "btnGetSmallTpye";
            this.btnGetSmallTpye.Size = new System.Drawing.Size(97, 48);
            this.btnGetSmallTpye.TabIndex = 1;
            this.btnGetSmallTpye.Text = "GetSmallTpye";
            this.btnGetSmallTpye.UseVisualStyleBackColor = true;
            this.btnGetSmallTpye.Click += new System.EventHandler(this.btnGetSmallTpye_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(240, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1035, 424);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGetSmallTpye);
            this.Controls.Add(this.btnGetPanasonic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetPanasonic;
        private System.Windows.Forms.Button btnGetSmallTpye;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

