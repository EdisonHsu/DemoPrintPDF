
namespace DemoPrintPDF
{
    partial class MainForm
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
            this.btnUseAdobe = new System.Windows.Forms.Button();
            this.btnUseRawPrint = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnCheckPrinter = new System.Windows.Forms.Button();
            this.txtPrinter = new System.Windows.Forms.TextBox();
            this.btnUseSpirePdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUseAdobe
            // 
            this.btnUseAdobe.Enabled = false;
            this.btnUseAdobe.Location = new System.Drawing.Point(107, 88);
            this.btnUseAdobe.Name = "btnUseAdobe";
            this.btnUseAdobe.Size = new System.Drawing.Size(123, 41);
            this.btnUseAdobe.TabIndex = 0;
            this.btnUseAdobe.Text = "使用 Adob​​e Acrobat";
            this.btnUseAdobe.UseVisualStyleBackColor = true;
            this.btnUseAdobe.Click += new System.EventHandler(this.btnUseAdobe_Click);
            // 
            // btnUseRawPrint
            // 
            this.btnUseRawPrint.Enabled = false;
            this.btnUseRawPrint.Location = new System.Drawing.Point(326, 88);
            this.btnUseRawPrint.Name = "btnUseRawPrint";
            this.btnUseRawPrint.Size = new System.Drawing.Size(123, 41);
            this.btnUseRawPrint.TabIndex = 1;
            this.btnUseRawPrint.Text = "使用 RawPrint";
            this.btnUseRawPrint.UseVisualStyleBackColor = true;
            this.btnUseRawPrint.Click += new System.EventHandler(this.btnUseRawPrint_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMessage.Location = new System.Drawing.Point(0, 285);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(800, 165);
            this.txtMessage.TabIndex = 2;
            // 
            // btnCheckPrinter
            // 
            this.btnCheckPrinter.Location = new System.Drawing.Point(12, 194);
            this.btnCheckPrinter.Name = "btnCheckPrinter";
            this.btnCheckPrinter.Size = new System.Drawing.Size(123, 41);
            this.btnCheckPrinter.TabIndex = 3;
            this.btnCheckPrinter.Text = "檢查Printer";
            this.btnCheckPrinter.UseVisualStyleBackColor = true;
            this.btnCheckPrinter.Click += new System.EventHandler(this.btnCheckPrinter_Click);
            // 
            // txtPrinter
            // 
            this.txtPrinter.Location = new System.Drawing.Point(12, 249);
            this.txtPrinter.Name = "txtPrinter";
            this.txtPrinter.Size = new System.Drawing.Size(776, 22);
            this.txtPrinter.TabIndex = 4;
            // 
            // btnUseSpirePdf
            // 
            this.btnUseSpirePdf.Location = new System.Drawing.Point(558, 88);
            this.btnUseSpirePdf.Name = "btnUseSpirePdf";
            this.btnUseSpirePdf.Size = new System.Drawing.Size(123, 41);
            this.btnUseSpirePdf.TabIndex = 5;
            this.btnUseSpirePdf.Text = "使用 Spire.Pdf";
            this.btnUseSpirePdf.UseVisualStyleBackColor = true;
            this.btnUseSpirePdf.Click += new System.EventHandler(this.btnUseSpirePdf_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUseSpirePdf);
            this.Controls.Add(this.txtPrinter);
            this.Controls.Add(this.btnCheckPrinter);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnUseRawPrint);
            this.Controls.Add(this.btnUseAdobe);
            this.Name = "MainForm";
            this.Text = "PrintPDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUseAdobe;
        private System.Windows.Forms.Button btnUseRawPrint;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnCheckPrinter;
        private System.Windows.Forms.TextBox txtPrinter;
        private System.Windows.Forms.Button btnUseSpirePdf;
    }
}

