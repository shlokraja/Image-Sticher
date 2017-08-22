using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;

namespace ImageEditor
{
    public partial class ProcessFile : Form
    {
        public string physicalPath = string.Empty;
        public string sourceFilePath = string.Empty;
        public string destinationFilePath = string.Empty;
        public bool IsNoColour = false;
        RectangleF rect = new RectangleF();
        string targetPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        const int ProductsCode = 1;
        const int OriginalPrice = 2;
        const int DiscountPrice = 3;
        const int Png_1 = 4;
        const int Png_2 = 5;
        const int Png_3 = 6;
        const int Png_4 = 7;
        const int Png_5 = 8;
        const int Png_6 = 9;
        int R = 0;
        int G = 0;
        int B = 0;

        public ProcessFile()
        {
            InitializeComponent();
            editorProgress1.Minimum = 0;
            editorProgress1.Maximum = 100;
            colorDialog1.Color = Color.FromArgb(224, 224, 224);
            var borderColor = ConfigurationManager.AppSettings["BorderColourCode"];
            if (!string.IsNullOrEmpty(borderColor))
            {
                if(!borderColor.Contains("#"))
                {
                    borderColor = "#" + borderColor;
                }
                Color color = ColorTranslator.FromHtml(borderColor);
                R = Convert.ToInt16(color.R);
                G = Convert.ToInt16(color.G);
                B = Convert.ToInt16(color.B);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Excel 2010|*.xlsx|Excel|*.xls";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnClear_Click(null, null);
                    physicalPath = fileDialog.FileName;
                    txtLink.Text = physicalPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExcelData(string filePath)
        {
            try
            {
                UseWaitCursor = true;
                Cursor.Current = Cursors.WaitCursor;
                var price = string.Empty;
                var discountedPrice = string.Empty;
                var originalPrice = string.Empty;
                var fileInfo = new FileInfo(filePath);
                using (var pck = new ExcelPackage(fileInfo))// reading the Excel file
                {
                    ExcelWorkbook workBook = pck.Workbook;
                    ExcelWorksheet mySheet = workBook.Worksheets.First(); //reading the first worksheet in the excel
                    int sheetRowsCount = (int)(mySheet.Dimension.End.Row);  // Getting Total Rows Count
                    int sheetColumnsCount = (int)(mySheet.Dimension.End.Column);  // Getting Total Columns Count
                    var filesCount = 0;
                    double percentage = 0;
                    var processedCount = 0;
                    int validRowsCount = (sheetRowsCount - 1);
                    DataRow dRow;
                    DataTable tblProcessDetails = new DataTable();
                    tblProcessDetails.Columns.Add("ProductCode");
                    tblProcessDetails.Columns.Add("Status");
                    tblProcessDetails.Columns.Add("OPrice");
                    tblProcessDetails.Columns.Add("DPrice");
                    FileInfo[] strFileNames = new FileInfo[20];
                    string[] imageDimension = new string[2];
                    lblTotalRowCount.Text = " Processed 0 of " + (sheetRowsCount - 1).ToString() + " records";
                    for (int j = 2; j <= sheetRowsCount; j++)
                    {
                        dRow = tblProcessDetails.NewRow();
                        if (Directory.Exists(sourceFilePath + "\\" + mySheet.Cells[j, ProductsCode].Value.ToString() + "\\"))
                        {
                            DirectoryInfo d = new DirectoryInfo(sourceFilePath + "\\" + mySheet.Cells[j, ProductsCode].Value.ToString() + "\\");
                            strFileNames = d.GetFiles("*.png");
                            if (strFileNames.Count() <= 12)
                            {
                                filesCount = (validRowsCount) * strFileNames.Count();
                                foreach (var filename in strFileNames)
                                {
                                    processedCount++;
                                    string imageFilePath = sourceFilePath + "\\" + mySheet.Cells[j, ProductsCode].Value.ToString() + "\\" + filename;

                                    if (mySheet.Cells[j, DiscountPrice].Value != null)
                                        discountedPrice = "\u20B9" + mySheet.Cells[j, DiscountPrice].Value.ToString();
                                    else
                                        discountedPrice = string.Empty;

                                    if (mySheet.Cells[j, OriginalPrice].Value != null)
                                        originalPrice = "\u20B9" + mySheet.Cells[j, OriginalPrice].Value.ToString();
                                    else
                                        originalPrice = string.Empty;

                                    if (filename.ToString().Contains("1"))
                                    {
                                        if (mySheet.Cells[j, Png_1].Value != null)
                                            imageDimension = mySheet.Cells[j, Png_1].Value.ToString().Split(',');
                                        else
                                            imageDimension = new string[0];
                                    }
                                    else if (filename.ToString().Contains("2"))
                                    {
                                        if (mySheet.Cells[j, Png_2].Value != null)
                                            imageDimension = mySheet.Cells[j, Png_2].Value.ToString().Split(',');
                                        else
                                            imageDimension = new string[0];
                                    }
                                    else if (filename.ToString().Contains("3"))
                                    {
                                        if (mySheet.Cells[j, Png_3].Value != null)
                                            imageDimension = mySheet.Cells[j, Png_3].Value.ToString().Split(',');
                                        else
                                            imageDimension = new string[0];
                                    }
                                    else if (filename.ToString().Contains("4"))
                                    {
                                        if (mySheet.Cells[j, Png_4].Value != null)
                                            imageDimension = mySheet.Cells[j, Png_4].Value.ToString().Split(',');
                                        else
                                            imageDimension = new string[0];
                                    }
                                    else if (filename.ToString().Contains("5"))
                                    {
                                        if (mySheet.Cells[j, Png_5].Value != null)
                                            imageDimension = mySheet.Cells[j, Png_5].Value.ToString().Split(',');
                                        else
                                            imageDimension = new string[0];
                                    }
                                    else if (filename.ToString().Contains("6"))
                                    {
                                        if (mySheet.Cells[j, Png_6].Value != null)
                                            imageDimension = mySheet.Cells[j, Png_6].Value.ToString().Split(',');
                                        else
                                            imageDimension = new string[0];
                                    }
                                    else
                                    {
                                        imageDimension = new string[0];
                                    }

                                    Bitmap bitmap = DrawText(imageFilePath, originalPrice, discountedPrice, imageDimension);//load the image file

                                    if (!Directory.Exists(destinationFilePath + "\\" + mySheet.Cells[j, ProductsCode].Value.ToString() + "\\"))
                                        Directory.CreateDirectory(destinationFilePath + "\\" + mySheet.Cells[j, ProductsCode].Value.ToString() + "\\");

                                    if (bitmap != null)
                                        bitmap.Save(destinationFilePath + "\\" + mySheet.Cells[j, ProductsCode].Value.ToString() + "\\" + filename);//save the image file
                                    bitmap = null;
                                }
                                dRow["ProductCode"] = mySheet.Cells[j, ProductsCode].Value.ToString();
                                dRow["Status"] = "OK";
                                dRow["OPrice"] = originalPrice;
                                dRow["DPrice"] = discountedPrice;
                                tblProcessDetails.Rows.Add(dRow);
                                dataGridView1.DataSource = tblProcessDetails;
                                dataGridView1.Refresh();
                                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                            }
                            else
                            {
                                validRowsCount = validRowsCount - 1;
                            }
                        }
                        else
                        {
                            dRow["ProductCode"] = mySheet.Cells[j, ProductsCode].Value.ToString();
                            dRow["Status"] = "NOT OK";
                            dRow["OPrice"] = originalPrice;
                            dRow["DPrice"] = discountedPrice;
                            tblProcessDetails.Rows.Add(dRow);
                            dataGridView1.DataSource = tblProcessDetails;
                            dataGridView1.Refresh();
                            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                            if (filesCount > 0)
                            {
                                validRowsCount = validRowsCount - 1;
                                filesCount = (validRowsCount) * strFileNames.Count();
                            }
                        }
                        if (filesCount > 0)
                        {
                            percentage = Math.Round(Convert.ToDouble(processedCount) / Convert.ToDouble(filesCount), 2);
                            editorProgress1.Value = Convert.ToInt32(percentage * 100);
                        }
                        Application.DoEvents();
                        lblTotalRowCount.Text = " Processed " + (j - 1) + " of " + (sheetRowsCount - 1).ToString() + " records";
                    }
                }
                Cursor.Current = Cursors.Default;
                UseWaitCursor = false;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object."))
                {
                    MessageBox.Show("File is Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Index was out of range."))
                {
                    MessageBox.Show("File Contains Empty Cells", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Can not open the package. Package is an OLE compound document."))
                {
                    MessageBox.Show("File format is invalid. Please upload the .xlsx format", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int productCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductCode"].Value);
                string status = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Status"].Value);
                if (status == "OK")
                {
                    if (e.ColumnIndex == 0)
                    {
                        System.Diagnostics.Process.Start(txtSourceLink.Text + "\\" + productCode + "\\");
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(txtDestinationLink.Text + "\\" + productCode + "\\");
                    }
                }
            }
        }

        private Bitmap DrawText(string imageFile, string originalPrice, string discountPrice, string[] imageDimension)
        {
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFile);//load the image file
            float width = ((float)bitmap.Width);
            float height = ((float)bitmap.Height);
            float priceHeight = 0;
            float priceWidth = 0;
            int originalFontSize = 60;
            int discountFontSize = 60;
            int ellipseBorderSize = 10;
            int imageHeight = 0;
            int imageWidth = 0;
            Font originalPriceFont = null;
            Font discountPricefont = null;
            string filename = Path.GetFileName(imageFile);
            SolidBrush colourBrush = new SolidBrush(Color.FromArgb(255, 255, 255));

            if (imageDimension.Count() > 0)
            {
                imageWidth = Convert.ToInt32(imageDimension[0]);
                imageHeight = Convert.ToInt32(imageDimension[1]);
            }
            try
            {
                if (filename.Contains("1"))
                {
                    originalFontSize = 50;
                    discountFontSize = 70;
                    ellipseBorderSize = 10;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 242, 237);
                }
                else if (filename.Contains("2"))
                {
                    originalFontSize = 39;
                    discountFontSize = 54;
                    ellipseBorderSize = 10;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 186, 178);
                }
                else if (filename.Contains("3"))
                {
                    originalFontSize = 30;
                    discountFontSize = 45;
                    ellipseBorderSize = 9;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 160, 160);
                }
                else if (filename.Contains("4"))
                {
                    originalFontSize = 28;
                    discountFontSize = 40;
                    ellipseBorderSize = 7;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 127, 122);
                }
                else if (filename.Contains("5"))
                {
                    originalFontSize = 25;
                    discountFontSize = 35;
                    ellipseBorderSize = 7;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 116, 114);
                }
                else if (filename.Contains("6"))
                {
                    originalFontSize = 25;
                    discountFontSize = 35;
                    ellipseBorderSize = 7;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 116, 114);
                }
                else
                {
                    originalFontSize = 25;
                    discountFontSize = 45;
                    ellipseBorderSize = 7;
                    priceHeight = (height / 100) * imageHeight;
                    priceWidth = (width / 100) * imageWidth;
                    rect = new RectangleF(priceWidth, priceHeight, 110, 108);
                }

                Bitmap tempBitmap = new Bitmap(new Bitmap(bitmap));
                originalPriceFont = new Font("PF Fusion Sans Pro Black", originalFontSize, FontStyle.Strikeout, GraphicsUnit.Pixel);
                discountPricefont = new Font("PF Fusion Sans Pro Black", discountFontSize, FontStyle.Bold, GraphicsUnit.Pixel);
                if (string.IsNullOrEmpty(discountPrice))
                {
                    discountPrice = originalPrice;
                    originalPrice = string.Empty;
                }

                using (Graphics graphics = Graphics.FromImage(tempBitmap))
                {
                    if (!IsNoColour)
                    {
                        if (filename.Contains("sold"))
                        {
                            Pen pen = new Pen(new SolidBrush(Color.FromArgb(183, 183, 183)), ellipseBorderSize);
                            graphics.DrawEllipse(pen, rect);
                            graphics.FillEllipse(new SolidBrush(Color.White), rect);
                        }
                        else
                        {
                            Pen pen = new Pen(new SolidBrush(Color.FromArgb(R, G, B)), ellipseBorderSize);
                            graphics.DrawEllipse(pen, rect);
                            graphics.FillEllipse(colourBrush, rect);
                        }

                    }
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;
                        if (filename.Contains("sold"))
                        {
                            graphics.DrawString(discountPrice, discountPricefont, new SolidBrush(Color.FromArgb(71, 71, 71)), rect, sf); 
                            if (!string.IsNullOrEmpty(discountPrice.Trim()))
                            {
                                graphics.DrawString("\n\n" + originalPrice, originalPriceFont, new SolidBrush(Color.FromArgb(71, 71, 71)), rect, sf);
                            }
                        }
                        else
                        {
                            graphics.DrawString(discountPrice, discountPricefont, new SolidBrush(Color.FromArgb(218, 7, 7)), rect, sf);
                            if (!string.IsNullOrEmpty(discountPrice.Trim()))
                            {
                                graphics.DrawString("\n\n" + originalPrice, originalPriceFont, new SolidBrush(Color.FromArgb(1, 0, 0)), rect, sf);
                            }
                        }
                    }
                }
                return tempBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                discountPricefont = null;
                originalPriceFont = null;
                bitmap = null;
                filename = string.Empty;
                width = 0;
                height = 0;
                priceHeight = 0;
                priceWidth = 0;
                originalFontSize = 0;
                discountFontSize = 0;
                imageHeight = 0;
                imageWidth = 0;
                GC.Collect();
            }
        }

        private void btnProcessClick(object sender, EventArgs e)
        {
            if (physicalPath != string.Empty && sourceFilePath != string.Empty && destinationFilePath != string.Empty)
            {
                LoadExcelData(physicalPath);  // Loading Excel data 
            }
            else
            {
                if (physicalPath == string.Empty)
                {
                    MessageBox.Show("Please upload the Datasource Excel file !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sourceFilePath == string.Empty)
                {
                    MessageBox.Show("Please select the Source path of the files !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (destinationFilePath == string.Empty)
                {
                    MessageBox.Show("Please select the Destination path to export files !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            physicalPath = string.Empty;
            txtLink.Text = string.Empty;
            sourceFilePath = string.Empty;
            txtSourceLink.Text = string.Empty;
            destinationFilePath = string.Empty;
            txtDestinationLink.Text = string.Empty;
            editorProgress1.Value = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            lblTotalRowCount.Text = "Processed 0 of 0 records";
        }

        private void btnBrowseSourcePath(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    sourceFilePath = folderDlg.SelectedPath;
                    txtSourceLink.Text = sourceFilePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseDestinationPath(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    destinationFilePath = folderDlg.SelectedPath;
                    txtDestinationLink.Text = destinationFilePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnColorDialog(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                btnColourPicker.BackColor = colorDialog1.Color;
                chkNoColour.BackColor = colorDialog1.Color;
            }
        }

        private void chk_NoColorChecked(object sender, EventArgs e)
        {
            if (chkNoColour.Checked == true)
            {
                IsNoColour = true;
                Color customColor = Color.FromArgb(224, 224, 224);
                chkNoColour.BackColor = customColor;
                btnColourPicker.BackColor = customColor;
            }
            else
            {
                IsNoColour = false;
                chkNoColour.BackColor = colorDialog1.Color;
                btnColourPicker.BackColor = colorDialog1.Color;
            }
        }
    }
}
