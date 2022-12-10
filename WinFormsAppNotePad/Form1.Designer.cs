namespace WinFormsAppNotePad
{
    partial class FormNP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNP));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemPageSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormThemeLight = new System.Windows.Forms.ToolStripMenuItem();
            this.FormThemeDark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScaleMax = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScaleMin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScaleRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFeedBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tSSLPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.tBMain = new System.Windows.Forms.TextBox();
            this.tSPanel = new System.Windows.Forms.ToolStrip();
            this.tsBtnCreate = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.textBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtn = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFeedback = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemFile,
            this.tsmEdit,
            this.tsmFormat,
            this.tsmView,
            this.tsmHelp});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1154, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmItemFile
            // 
            this.tsmItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreate,
            this.menuItemNewWindow,
            this.menuItemOpen,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.toolStripSeparator1,
            this.menuItemPageSettings,
            this.menuItemPrint,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.tsmItemFile.Name = "tsmItemFile";
            this.tsmItemFile.Size = new System.Drawing.Size(52, 22);
            this.tsmItemFile.Text = "Файл";
            // 
            // menuItemCreate
            // 
            this.menuItemCreate.Image = global::WinFormsAppNotePad.Properties.Resources.New;
            this.menuItemCreate.Name = "menuItemCreate";
            this.menuItemCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemCreate.Size = new System.Drawing.Size(260, 22);
            this.menuItemCreate.Text = "Создать";
            this.menuItemCreate.Click += new System.EventHandler(this.tsBtnCreate_Click);
            // 
            // menuItemNewWindow
            // 
            this.menuItemNewWindow.Image = global::WinFormsAppNotePad.Properties.Resources.Export;
            this.menuItemNewWindow.Name = "menuItemNewWindow";
            this.menuItemNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuItemNewWindow.Size = new System.Drawing.Size(260, 22);
            this.menuItemNewWindow.Text = "Новое окно";
            this.menuItemNewWindow.Click += new System.EventHandler(this.menuItemNewWindow_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Image = global::WinFormsAppNotePad.Properties.Resources.Open;
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpen.Size = new System.Drawing.Size(260, 22);
            this.menuItemOpen.Text = "Открыть...";
            this.menuItemOpen.Click += new System.EventHandler(this.tsBtnOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Image = global::WinFormsAppNotePad.Properties.Resources.Save;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(260, 22);
            this.menuItemSave.Text = "Сохранить";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Image = global::WinFormsAppNotePad.Properties.Resources.Save_as;
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(260, 22);
            this.menuItemSaveAs.Text = "Сохранить как...";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // menuItemPageSettings
            // 
            this.menuItemPageSettings.Image = global::WinFormsAppNotePad.Properties.Resources.Page_setup;
            this.menuItemPageSettings.Name = "menuItemPageSettings";
            this.menuItemPageSettings.Size = new System.Drawing.Size(260, 22);
            this.menuItemPageSettings.Text = "Параментры страницы";
            this.menuItemPageSettings.Click += new System.EventHandler(this.menuItemPageSettings_Click);
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Image = global::WinFormsAppNotePad.Properties.Resources.Print;
            this.menuItemPrint.Name = "menuItemPrint";
            this.menuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuItemPrint.Size = new System.Drawing.Size(260, 22);
            this.menuItemPrint.Text = "Печать";
            this.menuItemPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::WinFormsAppNotePad.Properties.Resources.Exit;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(260, 22);
            this.menuItemExit.Text = "Выход";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUndo,
            this.menuItemRedo,
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemInsert,
            this.menuItemDel,
            this.toolStripSeparator3,
            this.menuItemFind,
            this.menuItemFindNext,
            this.menuItemChange,
            this.menuItemGo,
            this.toolStripSeparator4,
            this.menuItemSelectAll,
            this.menuItemDT});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(68, 22);
            this.tsmEdit.Text = "Правка";
            // 
            // menuItemUndo
            // 
            this.menuItemUndo.Image = global::WinFormsAppNotePad.Properties.Resources.Undo;
            this.menuItemUndo.Name = "menuItemUndo";
            this.menuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItemUndo.Size = new System.Drawing.Size(228, 22);
            this.menuItemUndo.Text = "Отменить";
            // 
            // menuItemRedo
            // 
            this.menuItemRedo.Image = global::WinFormsAppNotePad.Properties.Resources.Redo;
            this.menuItemRedo.Name = "menuItemRedo";
            this.menuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuItemRedo.Size = new System.Drawing.Size(228, 22);
            this.menuItemRedo.Text = "Повтор";
            // 
            // menuItemCut
            // 
            this.menuItemCut.Image = global::WinFormsAppNotePad.Properties.Resources.Cut;
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemCut.Size = new System.Drawing.Size(228, 22);
            this.menuItemCut.Text = "Вырезать";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Image = global::WinFormsAppNotePad.Properties.Resources.Copy;
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemCopy.Size = new System.Drawing.Size(228, 22);
            this.menuItemCopy.Text = "Копировать";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemInsert
            // 
            this.menuItemInsert.Image = global::WinFormsAppNotePad.Properties.Resources.Paste;
            this.menuItemInsert.Name = "menuItemInsert";
            this.menuItemInsert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemInsert.Size = new System.Drawing.Size(228, 22);
            this.menuItemInsert.Text = "Вставить";
            this.menuItemInsert.Click += new System.EventHandler(this.menuItemInsert_Click);
            // 
            // menuItemDel
            // 
            this.menuItemDel.Image = global::WinFormsAppNotePad.Properties.Resources.Delete;
            this.menuItemDel.Name = "menuItemDel";
            this.menuItemDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDel.Size = new System.Drawing.Size(228, 22);
            this.menuItemDel.Text = "Удалить";
            this.menuItemDel.Click += new System.EventHandler(this.menuItemDel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // menuItemFind
            // 
            this.menuItemFind.Image = global::WinFormsAppNotePad.Properties.Resources.Find;
            this.menuItemFind.Name = "menuItemFind";
            this.menuItemFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuItemFind.Size = new System.Drawing.Size(228, 22);
            this.menuItemFind.Text = "Найти...";
            // 
            // menuItemFindNext
            // 
            this.menuItemFindNext.Image = global::WinFormsAppNotePad.Properties.Resources.Find_next;
            this.menuItemFindNext.Name = "menuItemFindNext";
            this.menuItemFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuItemFindNext.Size = new System.Drawing.Size(228, 22);
            this.menuItemFindNext.Text = "Найти далее";
            // 
            // menuItemChange
            // 
            this.menuItemChange.Image = global::WinFormsAppNotePad.Properties.Resources.Replace;
            this.menuItemChange.Name = "menuItemChange";
            this.menuItemChange.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuItemChange.Size = new System.Drawing.Size(228, 22);
            this.menuItemChange.Text = "Заменить";
            // 
            // menuItemGo
            // 
            this.menuItemGo.Image = global::WinFormsAppNotePad.Properties.Resources.Right;
            this.menuItemGo.Name = "menuItemGo";
            this.menuItemGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuItemGo.Size = new System.Drawing.Size(228, 22);
            this.menuItemGo.Text = "Перейти";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(225, 6);
            // 
            // menuItemSelectAll
            // 
            this.menuItemSelectAll.Name = "menuItemSelectAll";
            this.menuItemSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuItemSelectAll.Size = new System.Drawing.Size(228, 22);
            this.menuItemSelectAll.Text = "Выделить все";
            this.menuItemSelectAll.Click += new System.EventHandler(this.menuItemSelectAll_Click);
            // 
            // menuItemDT
            // 
            this.menuItemDT.Name = "menuItemDT";
            this.menuItemDT.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuItemDT.Size = new System.Drawing.Size(228, 22);
            this.menuItemDT.Text = "Время и дата";
            this.menuItemDT.Click += new System.EventHandler(this.menuItemDT_Click);
            // 
            // tsmFormat
            // 
            this.tsmFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTransfer,
            this.menuItemFont,
            this.темаToolStripMenuItem});
            this.tsmFormat.Name = "tsmFormat";
            this.tsmFormat.Size = new System.Drawing.Size(68, 22);
            this.tsmFormat.Text = "Формат";
            // 
            // menuItemTransfer
            // 
            this.menuItemTransfer.CheckOnClick = true;
            this.menuItemTransfer.Name = "menuItemTransfer";
            this.menuItemTransfer.Size = new System.Drawing.Size(212, 22);
            this.menuItemTransfer.Text = "Перенос по словам";
            this.menuItemTransfer.Click += new System.EventHandler(this.menuItemTransfer_Click);
            // 
            // menuItemFont
            // 
            this.menuItemFont.Name = "menuItemFont";
            this.menuItemFont.Size = new System.Drawing.Size(212, 22);
            this.menuItemFont.Text = "Шрифт...";
            this.menuItemFont.Click += new System.EventHandler(this.menuItemFont_Click);
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormThemeLight,
            this.FormThemeDark});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // FormThemeLight
            // 
            this.FormThemeLight.Checked = true;
            this.FormThemeLight.CheckOnClick = true;
            this.FormThemeLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormThemeLight.Name = "FormThemeLight";
            this.FormThemeLight.Size = new System.Drawing.Size(132, 22);
            this.FormThemeLight.Text = "Светлая";
            this.FormThemeLight.Click += new System.EventHandler(this.FormThemeLight_Click);
            // 
            // FormThemeDark
            // 
            this.FormThemeDark.CheckOnClick = true;
            this.FormThemeDark.Name = "FormThemeDark";
            this.FormThemeDark.Size = new System.Drawing.Size(132, 22);
            this.FormThemeDark.Text = "Темная";
            this.FormThemeDark.Click += new System.EventHandler(this.FormThemeDark_Click);
            // 
            // tsmView
            // 
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemScale,
            this.tsmItemStatusBar,
            this.ToolStripPanel});
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(44, 22);
            this.tsmView.Text = "Вид";
            // 
            // menuItemScale
            // 
            this.menuItemScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemScaleMax,
            this.menuItemScaleMin,
            this.menuItemScaleRestore});
            this.menuItemScale.Name = "menuItemScale";
            this.menuItemScale.Size = new System.Drawing.Size(228, 22);
            this.menuItemScale.Text = "Масштаб";
            // 
            // menuItemScaleMax
            // 
            this.menuItemScaleMax.Name = "menuItemScaleMax";
            this.menuItemScaleMax.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.menuItemScaleMax.Size = new System.Drawing.Size(396, 22);
            this.menuItemScaleMax.Text = "Увеличить";
            // 
            // menuItemScaleMin
            // 
            this.menuItemScaleMin.Name = "menuItemScaleMin";
            this.menuItemScaleMin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.menuItemScaleMin.Size = new System.Drawing.Size(396, 22);
            this.menuItemScaleMin.Text = "Уменьшить";
            // 
            // menuItemScaleRestore
            // 
            this.menuItemScaleRestore.Name = "menuItemScaleRestore";
            this.menuItemScaleRestore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.menuItemScaleRestore.Size = new System.Drawing.Size(396, 22);
            this.menuItemScaleRestore.Text = "Восстановить масштаб по умолчанию";
            // 
            // tsmItemStatusBar
            // 
            this.tsmItemStatusBar.Checked = true;
            this.tsmItemStatusBar.CheckOnClick = true;
            this.tsmItemStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmItemStatusBar.Name = "tsmItemStatusBar";
            this.tsmItemStatusBar.Size = new System.Drawing.Size(228, 22);
            this.tsmItemStatusBar.Text = "Строка состояния";
            this.tsmItemStatusBar.Click += new System.EventHandler(this.tsmItemStatusBar_Click);
            // 
            // ToolStripPanel
            // 
            this.ToolStripPanel.Checked = true;
            this.ToolStripPanel.CheckOnClick = true;
            this.ToolStripPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripPanel.Name = "ToolStripPanel";
            this.ToolStripPanel.Size = new System.Drawing.Size(228, 22);
            this.ToolStripPanel.Text = "Панель инструментов";
            this.ToolStripPanel.Click += new System.EventHandler(this.ToolStripPanel_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelp,
            this.menuItemFeedBack,
            this.menuItemAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(76, 22);
            this.tsmHelp.Text = "Справка";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Image = global::WinFormsAppNotePad.Properties.Resources.Help;
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(220, 22);
            this.menuItemHelp.Text = "Посмотреть справку";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // menuItemFeedBack
            // 
            this.menuItemFeedBack.Image = global::WinFormsAppNotePad.Properties.Resources.Send_by_email;
            this.menuItemFeedBack.Name = "menuItemFeedBack";
            this.menuItemFeedBack.Size = new System.Drawing.Size(220, 22);
            this.menuItemFeedBack.Text = "Отправить отзыв";
            this.menuItemFeedBack.Click += new System.EventHandler(this.menuItemFeedBack_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Image = global::WinFormsAppNotePad.Properties.Resources.About;
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(220, 22);
            this.menuItemAbout.Text = "О программе";
            this.menuItemAbout.Click += new System.EventHandler(this.tsBtnAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLPos,
            this.tSSLScale});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1154, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tSSLPos
            // 
            this.tSSLPos.AutoSize = false;
            this.tSSLPos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSSLPos.Name = "tSSLPos";
            this.tSSLPos.Size = new System.Drawing.Size(150, 17);
            this.tSSLPos.Text = "Стр 1, стлб 1";
            // 
            // tSSLScale
            // 
            this.tSSLScale.AutoSize = false;
            this.tSSLScale.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSSLScale.Name = "tSSLScale";
            this.tSSLScale.Size = new System.Drawing.Size(55, 17);
            this.tSSLScale.Text = "100%";
            // 
            // tBMain
            // 
            this.tBMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBMain.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBMain.Location = new System.Drawing.Point(0, 26);
            this.tBMain.Multiline = true;
            this.tBMain.Name = "tBMain";
            this.tBMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tBMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBMain.Size = new System.Drawing.Size(1154, 513);
            this.tBMain.TabIndex = 1;
            this.tBMain.WordWrap = false;
            this.tBMain.TextChanged += new System.EventHandler(this.tBMain_TextChanged);
            // 
            // tSPanel
            // 
            this.tSPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tSPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCreate,
            this.tsBtnOpen,
            this.tsBtnSave,
            this.tsBtnSaveAs,
            this.tsBtnPrint,
            this.toolStripSeparator5,
            this.tsBtnCancel,
            this.btnRedo,
            this.tsBtnCut,
            this.tsBtnCopy,
            this.tsBtnPaste,
            this.tsBtnDel,
            this.textBoxFind,
            this.tsBtn,
            this.tsBtnFindNext,
            this.toolStripSeparator6,
            this.tsBtnHelp,
            this.tsBtnFeedback,
            this.tsBtnAbout});
            this.tSPanel.Location = new System.Drawing.Point(0, 26);
            this.tSPanel.Name = "tSPanel";
            this.tSPanel.Size = new System.Drawing.Size(1154, 25);
            this.tSPanel.Stretch = true;
            this.tSPanel.TabIndex = 2;
            this.tSPanel.Text = "toolStrip1";
            // 
            // tsBtnCreate
            // 
            this.tsBtnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCreate.Image = global::WinFormsAppNotePad.Properties.Resources.New;
            this.tsBtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCreate.Name = "tsBtnCreate";
            this.tsBtnCreate.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCreate.Text = "Создать";
            this.tsBtnCreate.Click += new System.EventHandler(this.tsBtnCreate_Click);
            // 
            // tsBtnOpen
            // 
            this.tsBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOpen.Image = global::WinFormsAppNotePad.Properties.Resources.Open;
            this.tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpen.Name = "tsBtnOpen";
            this.tsBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsBtnOpen.Text = "Открыть...";
            this.tsBtnOpen.Click += new System.EventHandler(this.tsBtnOpen_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = global::WinFormsAppNotePad.Properties.Resources.Save;
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Сохранить";
            this.tsBtnSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // tsBtnSaveAs
            // 
            this.tsBtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSaveAs.Image = global::WinFormsAppNotePad.Properties.Resources.Save_as;
            this.tsBtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveAs.Name = "tsBtnSaveAs";
            this.tsBtnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSaveAs.Text = "Сохранить как...";
            this.tsBtnSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // tsBtnPrint
            // 
            this.tsBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrint.Image = global::WinFormsAppNotePad.Properties.Resources.Print;
            this.tsBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrint.Name = "tsBtnPrint";
            this.tsBtnPrint.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrint.Text = "Печать";
            this.tsBtnPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = global::WinFormsAppNotePad.Properties.Resources.Undo;
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Отменить";
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::WinFormsAppNotePad.Properties.Resources.Redo;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "Повтор";
            // 
            // tsBtnCut
            // 
            this.tsBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCut.Image = global::WinFormsAppNotePad.Properties.Resources.Cut;
            this.tsBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCut.Name = "tsBtnCut";
            this.tsBtnCut.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCut.Text = "Вырезать";
            this.tsBtnCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // tsBtnCopy
            // 
            this.tsBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCopy.Image = global::WinFormsAppNotePad.Properties.Resources.Copy;
            this.tsBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCopy.Name = "tsBtnCopy";
            this.tsBtnCopy.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCopy.Text = "Копировать";
            this.tsBtnCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // tsBtnPaste
            // 
            this.tsBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPaste.Image = global::WinFormsAppNotePad.Properties.Resources.Paste;
            this.tsBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPaste.Name = "tsBtnPaste";
            this.tsBtnPaste.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPaste.Text = "Вставить";
            this.tsBtnPaste.Click += new System.EventHandler(this.menuItemInsert_Click);
            // 
            // tsBtnDel
            // 
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDel.Image = global::WinFormsAppNotePad.Properties.Resources.Delete;
            this.tsBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDel.Text = "Удалить";
            this.tsBtnDel.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(75, 25);
            this.textBoxFind.Text = "Найти...";
            this.textBoxFind.ToolTipText = "Найти...";
            this.textBoxFind.Click += new System.EventHandler(this.textBoxFind_Click);
            // 
            // tsBtn
            // 
            this.tsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn.Image = global::WinFormsAppNotePad.Properties.Resources.Find;
            this.tsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn.Name = "tsBtn";
            this.tsBtn.Size = new System.Drawing.Size(23, 22);
            this.tsBtn.Text = "Найти..";
            // 
            // tsBtnFindNext
            // 
            this.tsBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFindNext.Image = global::WinFormsAppNotePad.Properties.Resources.Find_next;
            this.tsBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFindNext.Name = "tsBtnFindNext";
            this.tsBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFindNext.Text = "Найти далее";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnHelp
            // 
            this.tsBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHelp.Image = global::WinFormsAppNotePad.Properties.Resources.Help;
            this.tsBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHelp.Name = "tsBtnHelp";
            this.tsBtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsBtnHelp.Text = "Посмотреть справку";
            // 
            // tsBtnFeedback
            // 
            this.tsBtnFeedback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFeedback.Image = global::WinFormsAppNotePad.Properties.Resources.Send_by_email;
            this.tsBtnFeedback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFeedback.Name = "tsBtnFeedback";
            this.tsBtnFeedback.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFeedback.Text = "Отправить отзыв";
            // 
            // tsBtnAbout
            // 
            this.tsBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAbout.Image = global::WinFormsAppNotePad.Properties.Resources.About;
            this.tsBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAbout.Name = "tsBtnAbout";
            this.tsBtnAbout.Size = new System.Drawing.Size(23, 22);
            this.tsBtnAbout.Text = "О программе";
            this.tsBtnAbout.Click += new System.EventHandler(this.tsBtnAbout_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormNP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1154, 561);
            this.Controls.Add(this.tSPanel);
            this.Controls.Add(this.tBMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormNP";
            this.Text = "Безымянный - Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNP_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tSPanel.ResumeLayout(false);
            this.tSPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem tsmItemFile;
        private ToolStripMenuItem menuItemCreate;
        private ToolStripMenuItem menuItemNewWindow;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemSave;
        private ToolStripMenuItem menuItemSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuItemPageSettings;
        private ToolStripMenuItem menuItemPrint;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuItemExit;
        private ToolStripMenuItem tsmEdit;
        private ToolStripMenuItem menuItemUndo;
        private ToolStripMenuItem menuItemCut;
        private ToolStripMenuItem menuItemCopy;
        private ToolStripMenuItem menuItemInsert;
        private ToolStripMenuItem menuItemDel;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuItemFind;
        private ToolStripMenuItem menuItemFindNext;
        private ToolStripMenuItem menuItemChange;
        private ToolStripMenuItem menuItemGo;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menuItemSelectAll;
        private ToolStripMenuItem menuItemDT;
        private ToolStripMenuItem tsmFormat;
        private ToolStripMenuItem menuItemTransfer;
        private ToolStripMenuItem menuItemFont;
        private ToolStripMenuItem tsmView;
        private ToolStripMenuItem menuItemScale;
        private ToolStripMenuItem menuItemScaleMax;
        private ToolStripMenuItem menuItemScaleMin;
        private ToolStripMenuItem menuItemScaleRestore;
        private ToolStripMenuItem tsmHelp;
        private ToolStripMenuItem tsmItemStatusBar;
        private ToolStripMenuItem menuItemHelp;
        private ToolStripMenuItem menuItemFeedBack;
        private ToolStripMenuItem menuItemAbout;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tSSLPos;
        private ToolStripStatusLabel tSSLScale;
        private TextBox tBMain;
        private ToolStripMenuItem ToolStripPanel;
        private ToolStrip tSPanel;
        private ToolStripButton tsBtnCreate;
        private ToolStripButton tsBtnOpen;
        private ToolStripButton tsBtnSave;
        private ToolStripButton tsBtnSaveAs;
        private ToolStripButton tsBtnPrint;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsBtnCancel;
        private ToolStripButton tsBtnCut;
        private ToolStripButton tsBtnCopy;
        private ToolStripButton tsBtnPaste;
        private ToolStripButton tsBtnDel;
        private ToolStripButton tsBtn;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsBtnHelp;
        private ToolStripButton tsBtnFeedback;
        private ToolStripTextBox textBoxFind;
        private ToolStripButton tsBtnFindNext;
        private ToolStripButton tsBtnAbout;
        private PrintDialog printDialog;
        private PrintDialog printDialog1;
        private PageSetupDialog pageSetupDialog;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem темаToolStripMenuItem;
        private ToolStripMenuItem FormThemeLight;
        private ToolStripMenuItem FormThemeDark;
        private ToolStripMenuItem menuItemRedo;
        private ToolStripButton btnRedo;
    }
}