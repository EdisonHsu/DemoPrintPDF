using RawPrint;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPrintPDF
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 檔案名稱(自行調整)
        /// </summary>
        private string Filename { get; set; }

        /// <summary>
        /// 檔案路徑(自行調整)
        /// </summary>
        private string Filepath { get; set; }


        public MainForm()
        {
            InitializeComponent();

            //檔案名稱(自行調整)
            Filename = "3941029510037606.pdf";

            //預設開啟執行檔的路徑(自行調整)
            Filepath = $"{System.IO.Path.GetDirectoryName(typeof(Program).Assembly.Location)}\\{Filename}";
        }

        /// <summary>
        /// 使用 Adob​​e Acrobat(程序有問題，不使用)
        /// </summary>
        private void PrintPDFWithAcrobat()
        {
            using (PrintDialog Dialog = new PrintDialog())
            {
                //Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }
            }
        }

        /// <summary>
        /// 使用 RawPrint(印表機印出會有亂碼，不使用)
        /// </summary>
        private void PrintPDF()
        {
            // 印表機名稱設定(自行調製整)
            string PrinterName = txtPrinter.Text;


            FileStream stream = new FileStream(Filepath, FileMode.Open, FileAccess.Read);
            
            IPrinter printer = new Printer();
            printer.PrintRawFile(PrinterName, Filepath);
        }

        /// <summary>
        /// 使用 SpirePdf
        /// </summary>
        private void PrintSpirePdf()
        {
            PdfDocument pfdDoc = new PdfDocument();
            pfdDoc.LoadFromFile(Filepath);

            // 印表機名稱設定(自行調製整)
            string PrinterName = txtPrinter.Text;
            pfdDoc.PrintSettings.PrinterName = PrinterName;
            //版面大小
            pfdDoc.PrintSettings.PaperSize = new System.Drawing.Printing.PaperSize("CustomSetting", 400, 600);
            // 自訂縮放 100%
            pfdDoc.PrintSettings.SelectSinglePageLayout(Spire.Pdf.Print.PdfSinglePageScalingMode.CustomScale, false, 100f);

            pfdDoc.Print();
        }

        /// <summary>
        /// 列出本機印表機
        /// </summary>
        private void CheckPrinter()
        {
            foreach (string printerName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                txtMessage.Text += $"{printerName}\r\n";
            }
        }

        private void btnCheckPrinter_Click(object sender, EventArgs e)
        {
            CheckPrinter();
        }

        private void btnUseAdobe_Click(object sender, EventArgs e)
        {
            PrintPDFWithAcrobat();
        }

        private void btnUseRawPrint_Click(object sender, EventArgs e)
        {
            PrintPDF();
        }

        private void btnUseSpirePdf_Click(object sender, EventArgs e)
        {
            PrintSpirePdf();
        }
    }
}
