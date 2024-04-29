using Org.BouncyCastle.Asn1.Ocsp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace LibrariumAdmin.Pages
{
    partial class BooksListPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BooksSearchTextBox = new Krypton.Toolkit.KryptonTextBox();
            LibrariumCustomPalleteBase = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            BrandLogoPictureBox = new Krypton.Toolkit.KryptonPictureBox();
            PageTitleLabel = new Krypton.Toolkit.KryptonLabel();
            ExportButton = new Krypton.Toolkit.KryptonButton();
            AddBookButton = new Krypton.Toolkit.KryptonButton();
            BooksDataGridView = new DataGridView();
            ThumbnailColumn = new DataGridViewImageColumn();
            TitleColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            PublisherColumn = new DataGridViewTextBoxColumn();
            BookIDColumn = new DataGridViewTextBoxColumn();
            ISBNColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            ActionsColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)BrandLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BooksDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BooksSearchTextBox
            // 
            BooksSearchTextBox.CueHint.Color1 = Color.DimGray;
            BooksSearchTextBox.CueHint.CueHintText = "Search";
            BooksSearchTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            BooksSearchTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            BooksSearchTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            BooksSearchTextBox.Location = new Point(610, 34);
            BooksSearchTextBox.Name = "BooksSearchTextBox";
            BooksSearchTextBox.Palette = LibrariumCustomPalleteBase;
            BooksSearchTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            BooksSearchTextBox.Size = new Size(468, 45);
            BooksSearchTextBox.TabIndex = 10;
            // 
            // LibrariumCustomPalleteBase
            // 
            LibrariumCustomPalleteBase.BaseFont = new Font("Century Gothic", 10F);
            LibrariumCustomPalleteBase.BaseFontSize = 10F;
            LibrariumCustomPalleteBase.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Back.Color1 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Back.Color2 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Border.Rounding = 8F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 8F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Back.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Back.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Border.Rounding = 8F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Content.ShortText.Color1 = Color.Gray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Content.ShortText.Color2 = Color.Gray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateNormal.Content.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Border.Rounding = 8F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Back.Color2 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Border.Rounding = 12F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.Padding = new Padding(20, -1, -1, -1);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.ShortText.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.ShortText.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Back.Color1 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Back.Color2 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Border.Rounding = 12F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.Padding = new Padding(20, -1, -1, -1);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Back.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Back.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Border.Rounding = 12F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.Padding = new Padding(20, -1, -1, -1);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Color1 = Color.Gray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Color2 = Color.Gray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.Color1 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.Color2 = Color.DodgerBlue;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Border.Rounding = 12F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.Padding = new Padding(20, -1, -1, -1);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.ShortText.Color1 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.ShortText.Color2 = Color.White;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.ShortText.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.Color1 = Color.LightGray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.Color2 = Color.LightGray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Border.Rounding = 12F;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.Padding = new Padding(20, -1, -1, -1);
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Color1 = Color.Gray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Color2 = Color.Gray;
            LibrariumCustomPalleteBase.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.CueHintText.Color1 = Color.DimGray;
            LibrariumCustomPalleteBase.CueHintText.CueHintText = "Test";
            LibrariumCustomPalleteBase.CueHintText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.CueHintText.Padding = new Padding(4);
            LibrariumCustomPalleteBase.CueHintText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.Background.Color1 = Color.Azure;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = Color.Azure;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = Color.Transparent;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.DataCell.Border.Color2 = Color.Transparent;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.Azure;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = Color.Azure;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = Color.Transparent;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color2 = Color.Transparent;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = Color.Gray;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color2 = Color.Gray;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Padding = new Padding(8, 28, 8, 8);
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color1 = Color.Azure;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color2 = Color.Azure;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color1 = Color.Transparent;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color2 = Color.Transparent;
            LibrariumCustomPalleteBase.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            LibrariumCustomPalleteBase.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Padding = new Padding(20);
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Back.Color1 = Color.White;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = Color.DarkGray;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.Color2 = Color.DarkGray;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 8F;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Content.Padding = new Padding(8);
            LibrariumCustomPalleteBase.LabelStyles.LabelCustom1.StateNormal.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.White;
            LibrariumCustomPalleteBase.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.White;
            LibrariumCustomPalleteBase.ThemeName = "";
            LibrariumCustomPalleteBase.UseKryptonFileDialogs = true;
            // 
            // BrandLogoPictureBox
            // 
            BrandLogoPictureBox.Image = Properties.Resources.LibrariumLogo;
            BrandLogoPictureBox.Location = new Point(31, 34);
            BrandLogoPictureBox.Name = "BrandLogoPictureBox";
            BrandLogoPictureBox.Size = new Size(36, 36);
            BrandLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BrandLogoPictureBox.TabIndex = 14;
            BrandLogoPictureBox.TabStop = false;
            // 
            // PageTitleLabel
            // 
            PageTitleLabel.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            PageTitleLabel.Location = new Point(73, 34);
            PageTitleLabel.Name = "PageTitleLabel";
            PageTitleLabel.Size = new Size(93, 38);
            PageTitleLabel.StateCommon.ShortText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageTitleLabel.TabIndex = 13;
            PageTitleLabel.Values.Text = "Books";
            // 
            // ExportButton
            // 
            ExportButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            ExportButton.Location = new Point(1269, 34);
            ExportButton.Name = "ExportButton";
            ExportButton.Palette = LibrariumCustomPalleteBase;
            ExportButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ExportButton.Size = new Size(154, 45);
            ExportButton.TabIndex = 12;
            ExportButton.Values.Text = "Export";
            // 
            // AddBookButton
            // 
            AddBookButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            AddBookButton.Location = new Point(1097, 34);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Palette = LibrariumCustomPalleteBase;
            AddBookButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            AddBookButton.Size = new Size(154, 45);
            AddBookButton.TabIndex = 11;
            AddBookButton.Values.Text = "Add Book";
            AddBookButton.Click += AddBookButton_Click;
            // 
            // BooksDataGridView
            // 
            BooksDataGridView.AllowUserToAddRows = false;
            BooksDataGridView.AllowUserToDeleteRows = false;
            BooksDataGridView.AllowUserToResizeRows = false;
            BooksDataGridView.BackgroundColor = Color.FromArgb(238, 244, 253);
            BooksDataGridView.BorderStyle = BorderStyle.None;
            BooksDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            BooksDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 244, 253);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BooksDataGridView.ColumnHeadersHeight = 29;
            BooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { ThumbnailColumn, TitleColumn, AuthorColumn, PublisherColumn, BookIDColumn, ISBNColumn, StatusColumn, ActionsColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BooksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            BooksDataGridView.EnableHeadersVisualStyles = false;
            BooksDataGridView.GridColor = Color.FromArgb(238, 244, 253);
            BooksDataGridView.Location = new Point(23, 17);
            BooksDataGridView.MultiSelect = false;
            BooksDataGridView.Name = "BooksDataGridView";
            BooksDataGridView.ReadOnly = true;
            BooksDataGridView.RowHeadersVisible = false;
            BooksDataGridView.RowHeadersWidth = 51;
            BooksDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BooksDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(238, 244, 253);
            BooksDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BooksDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(38, 46, 83);
            BooksDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 20, 0, 20);
            BooksDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 244, 253);
            BooksDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 46, 83);
            BooksDataGridView.RowTemplate.Height = 100;
            BooksDataGridView.Size = new Size(1367, 703);
            BooksDataGridView.TabIndex = 4;
            BooksDataGridView.CellFormatting += BooksDataGridView_CellFormatting;
            BooksDataGridView.RowsRemoved += BooksDataGridView_RowsRemoved;
            // 
            // ThumbnailColumn
            // 
            ThumbnailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ThumbnailColumn.FillWeight = 40F;
            ThumbnailColumn.HeaderText = "Thumbnail";
            ThumbnailColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ThumbnailColumn.MinimumWidth = 6;
            ThumbnailColumn.Name = "ThumbnailColumn";
            ThumbnailColumn.ReadOnly = true;
            ThumbnailColumn.Resizable = DataGridViewTriState.False;
            ThumbnailColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TitleColumn
            // 
            TitleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TitleColumn.HeaderText = "Title";
            TitleColumn.MinimumWidth = 6;
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            // 
            // AuthorColumn
            // 
            AuthorColumn.HeaderText = "Author";
            AuthorColumn.MinimumWidth = 6;
            AuthorColumn.Name = "AuthorColumn";
            AuthorColumn.ReadOnly = true;
            AuthorColumn.Width = 125;
            // 
            // PublisherColumn
            // 
            PublisherColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PublisherColumn.HeaderText = "Publisher";
            PublisherColumn.MinimumWidth = 6;
            PublisherColumn.Name = "PublisherColumn";
            PublisherColumn.ReadOnly = true;
            // 
            // BookIDColumn
            // 
            BookIDColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BookIDColumn.HeaderText = "Book ID";
            BookIDColumn.MinimumWidth = 6;
            BookIDColumn.Name = "BookIDColumn";
            BookIDColumn.ReadOnly = true;
            // 
            // ISBNColumn
            // 
            ISBNColumn.HeaderText = "ISBN";
            ISBNColumn.MinimumWidth = 6;
            ISBNColumn.Name = "ISBNColumn";
            ISBNColumn.ReadOnly = true;
            ISBNColumn.Width = 125;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            StatusColumn.Width = 125;
            // 
            // ActionsColumn
            // 
            ActionsColumn.HeaderText = "Actions";
            ActionsColumn.MinimumWidth = 6;
            ActionsColumn.Name = "ActionsColumn";
            ActionsColumn.ReadOnly = true;
            ActionsColumn.Resizable = DataGridViewTriState.True;
            ActionsColumn.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 244, 253);
            panel1.Controls.Add(BooksDataGridView);
            panel1.Location = new Point(31, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(1393, 723);
            panel1.TabIndex = 15;
            // 
            // BooksListPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(BooksSearchTextBox);
            Controls.Add(BrandLogoPictureBox);
            Controls.Add(PageTitleLabel);
            Controls.Add(ExportButton);
            Controls.Add(AddBookButton);
            Name = "BooksListPage";
            Size = new Size(1460, 857);
            ((System.ComponentModel.ISupportInitialize)BrandLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BooksDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox BooksSearchTextBox;
        private Krypton.Toolkit.KryptonCustomPaletteBase LibrariumCustomPalleteBase;
        private Krypton.Toolkit.KryptonPictureBox BrandLogoPictureBox;
        private Krypton.Toolkit.KryptonLabel PageTitleLabel;
        private Krypton.Toolkit.KryptonButton ExportButton;
        private Krypton.Toolkit.KryptonButton AddBookButton;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Requests;
        private DataGridViewTextBoxColumn Actions;
        private DataGridView BooksDataGridView;
        private Panel panel1;
        private DataGridViewImageColumn ThumbnailColumn;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
        private DataGridViewTextBoxColumn PublisherColumn;
        private DataGridViewTextBoxColumn BookIDColumn;
        private DataGridViewTextBoxColumn ISBNColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn ActionsColumn;
    }
}
