using System.Drawing.Printing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppNotePad
{
    public partial class FormNP : Form
    {
        Stack<Repeat> undo = new Stack<Repeat>();
        Stack<Repeat> redo = new Stack<Repeat>();

        public string filename = "";
        public bool isFileChanged;
        public FormNP()
        {
            InitializeComponent();
           
            undo.Push(new Repeat(tBMain.Text, tBMain.Font, tBMain.BackColor, tBMain.SelectionStart));
            isUndeRedo();
        }

        public void isUndeRedo()
        {
            tsBtnCancel.Enabled = undo.Count > 1;
            menuItemUndo.Enabled = undo.Count > 1;
            btnRedo.Enabled = redo.Count > 0;
            menuItemRedo.Enabled = redo.Count > 0;
        }

        private void menuItemTransfer_Click(object sender, EventArgs e)
        {
            if(menuItemTransfer.Checked) tBMain.WordWrap = true;
            else tBMain.WordWrap = false;
        }

        private void tsmItemStatusBar_Click(object sender, EventArgs e)
        {
            if(tsmItemStatusBar.Checked) statusStrip.Visible = true;
            else statusStrip.Visible = false;
        }

        private void ToolStripPanel_Click(object sender, EventArgs e)
        {
            if (ToolStripPanel.Checked) tSPanel.Visible = true;
            else tSPanel.Visible = false;
        }

        private void tsBtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tБлокнот разработан студентом Академии \"TOP\"\n\tгруппа СПД111 - Андреев Е.В.", "О программе",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void menuItemPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Печать документа";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog  
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void textBoxFind_Click(object sender, EventArgs e)
        {
            textBoxFind.Text = "";
        }

        private void menuItemFeedBack_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItemPageSettings_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings =
                   new System.Drawing.Printing.PageSettings();
            pageSetupDialog.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog.ShowNetwork = false;
            DialogResult result = pageSetupDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
            object[] results = new object[]{
            pageSetupDialog.PageSettings.Margins,
            pageSetupDialog.PageSettings.PaperSize,
            pageSetupDialog.PageSettings.Landscape,
            pageSetupDialog.PrinterSettings.PrinterName,
            pageSetupDialog.PrinterSettings.PrintRange};
            }
        }

        
        private void tsBtnCreate_Click(object sender, EventArgs e)
        {
            SavedUnSavedFile();
            tBMain.Text = "";
            filename = "";
            isFileChanged= false;
            UpdateTextWithTitle();
        }

        private void tsBtnOpen_Click(object sender, EventArgs e)
        {
            SavedUnSavedFile();
            openFileDialog1.Filter = "Все файлы (*.*)|*.*|TXT файлы (*.txt)|*.txt";
            openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    tBMain.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!!!", "Ошибка открытия файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateTextWithTitle();
        }

        public void SaveFile(string _filename)
        {
            if(_filename == "")
            {
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.Filter = "Все файлы (*.*)|*.*|TXT файлы (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                    
                    try
                    {
                        StreamWriter sw = new StreamWriter(_filename);
                        sw.Write(tBMain.Text);
                        filename = _filename;
                        isFileChanged = false;
                        sw.Close();
                        UpdateTextWithTitle();
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить файл!!!", "Ошибка сохранения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else return;
            }

           
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
           SaveFile(filename);
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFile("");
        }

        private void tBMain_TextChanged(object sender, EventArgs e)
        {
            if(undo.Peek() != null && undo.Peek().Text != tBMain.Text)
                undo.Push(new Repeat(tBMain.Text, tBMain.Font, tBMain.BackColor, tBMain.SelectionStart));
            isUndeRedo();
            if (!isFileChanged)
            {
                if (this.Text[0] != '*')
                {
                    isFileChanged = true;
                    this.Text = "*" + this.Text;
                }
            }
            tSSLPos.Text = $"Стр {tBMain.GetLineFromCharIndex(tBMain.SelectionStart) + 1}," +
                $" стлб {tBMain.SelectionStart - tBMain.GetFirstCharIndexOfCurrentLine() +1}";
            
        }

        public void UpdateTextWithTitle()
        {
            if(filename!= "")
                this.Text = $"{filename.Remove(0, filename.LastIndexOf("\\") + 1)} - Блокнот";
            else
                this.Text = $"Безымянный - Блокнот";
        }
        public void SavedUnSavedFile()
        {
            if(isFileChanged)
            {
                DialogResult result = MessageBox.Show($"Вы хотите сохранить изменения в файле?", "Блокнот",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question,
                                                      MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            SavedUnSavedFile();
            this.Close();
        }

        private void FormNP_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavedUnSavedFile();
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
          
        }

        private void menuItemDT_Click(object sender, EventArgs e)
        {
            DateTimeText();
        }

        public void CopyText()
        {
            if(tBMain.SelectionLength>0)
                Clipboard.SetText(tBMain.SelectedText);
        }
        public void CutText()
        {
            if (tBMain.SelectionLength > 0)
            {
                Clipboard.SetText(tBMain.SelectedText);
                tBMain.Text = tBMain.Text.Remove(tBMain.SelectionStart, tBMain.SelectionLength);
            }
        }

        public void DelText()
        {
            if (tBMain.SelectionLength > 0)
            {
                tBMain.SelectedText = "";
            }
        }

        public void PasteText()
        {
            tBMain.Text = tBMain.Text.Substring(0, tBMain.SelectionStart) + 
                          Clipboard.GetText() + 
                          tBMain.Text.Substring(tBMain.SelectionStart, tBMain.Text.Length - tBMain.SelectionStart);
        }
         public void SelectAllText()
        {
            tBMain.SelectAll();
        }

        public void DateTimeText()        {
            DateTime dt = DateTime.Now;
            tBMain.Text = tBMain.Text.Substring(0, tBMain.SelectionStart) +
                          dt.ToString() +
                          tBMain.Text.Substring(tBMain.SelectionStart, tBMain.Text.Length - tBMain.SelectionStart);
        }
        
        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void menuItemCut_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void menuItemInsert_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void menuItemDel_Click(object sender, EventArgs e)
        {
            DelText();
        }

        private void menuItemSelectAll_Click(object sender, EventArgs e)
        {
            SelectAllText();
        }

        private void menuItemFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = tBMain.Font;
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tBMain.Font = fontDialog1.Font;
                tBMain.ForeColor = fontDialog1.Color;
            }
        }

        private void FormThemeLight_Click(object sender, EventArgs e)
        {
            if(FormThemeDark.Checked) 
                FormThemeDark.Checked = false; 
            tBMain.ForeColor = Color.Black;
            tBMain.BackColor = Color.White;
            menuStrip.BackColor = Color.WhiteSmoke;
            menuStrip.ForeColor = Color.Black;
            tSPanel.ForeColor = Color.Black;
            tSPanel.BackColor = Color.WhiteSmoke;
            statusStrip.BackColor = Color.WhiteSmoke;
            statusStrip.ForeColor = Color.Black;
        }

        private void FormThemeDark_Click(object sender, EventArgs e)
        {
            if (FormThemeLight.Checked)
                FormThemeLight.Checked = false;
            tBMain.ForeColor = Color.White;
            tBMain.BackColor = Color.DarkGray;
            menuStrip.BackColor = Color.DarkGray;
            menuStrip.ForeColor = Color.White;
            tSPanel.BackColor = Color.DarkGray;
            tSPanel.ForeColor = Color.White;
            statusStrip.BackColor = Color.DarkGray;
            statusStrip.ForeColor = Color.White;
            //foreach(var item in tsmItemFile.)
            //{
            //   item.ForeColor = Color.White;
            //    item.BackColor = Color.DarkGray;
            //}
        }

        private void menuItemUndo_Click(object sender, EventArgs e)
        {
            if(undo.Count > 0)
            {
                tBMain.Font = undo.Peek().fontColor;
                tBMain.BackColor = undo.Peek().backColor;
                tBMain.Text = undo.Peek().Text;
                tBMain.SelectionStart = undo.Peek().curPos;
                redo.Push(undo.Pop());
                isUndeRedo();
            }
        }

        private void menuItemRedo_Click(object sender, EventArgs e)
        {
            if (redo.Count > 0)
            {
                var curPos = tBMain.SelectionStart;
                tBMain.Font = redo.Peek().fontColor;
                tBMain.BackColor = redo.Peek().backColor;
                tBMain.Text = redo.Peek().Text;
                tBMain.SelectionStart = redo.Peek().curPos;
                undo.Push(redo.Pop());
                isUndeRedo();
            }
        }

        private void menuItemScaleMax_Click(object sender, EventArgs e)
        {
            
        }
    }
}