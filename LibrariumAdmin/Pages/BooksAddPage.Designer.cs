namespace LibrariumAdmin.Pages
{
    partial class BooksAddPage
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
            BrandLogoPictureBox = new Krypton.Toolkit.KryptonPictureBox();
            PageTitleLabel = new Krypton.Toolkit.KryptonLabel();
            LibrariumCustomPalleteBase = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            TitleTextBox = new Krypton.Toolkit.KryptonTextBox();
            PublisherTextBox = new Krypton.Toolkit.KryptonTextBox();
            ISBNTextBox = new Krypton.Toolkit.KryptonTextBox();
            AuthorTextBox = new Krypton.Toolkit.KryptonTextBox();
            DescriptionTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            SaveBookButton = new Krypton.Toolkit.KryptonButton();
            CancelButton = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)BrandLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BrandLogoPictureBox
            // 
            BrandLogoPictureBox.Image = Properties.Resources.LibrariumLogo;
            BrandLogoPictureBox.Location = new Point(30, 43);
            BrandLogoPictureBox.Name = "BrandLogoPictureBox";
            BrandLogoPictureBox.Size = new Size(36, 36);
            BrandLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BrandLogoPictureBox.TabIndex = 10;
            BrandLogoPictureBox.TabStop = false;
            // 
            // PageTitleLabel
            // 
            PageTitleLabel.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            PageTitleLabel.Location = new Point(72, 43);
            PageTitleLabel.Name = "PageTitleLabel";
            PageTitleLabel.Size = new Size(218, 38);
            PageTitleLabel.StateCommon.ShortText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageTitleLabel.TabIndex = 9;
            PageTitleLabel.Values.Text = "Add New Book";
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
            // TitleTextBox
            // 
            TitleTextBox.CueHint.Color1 = Color.DimGray;
            TitleTextBox.CueHint.CueHintText = "Title";
            TitleTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            TitleTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TitleTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            TitleTextBox.Location = new Point(368, 115);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Palette = LibrariumCustomPalleteBase;
            TitleTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            TitleTextBox.Size = new Size(468, 45);
            TitleTextBox.TabIndex = 11;
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.CueHint.Color1 = Color.DimGray;
            PublisherTextBox.CueHint.CueHintText = "Publisher";
            PublisherTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            PublisherTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            PublisherTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            PublisherTextBox.Location = new Point(368, 197);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Palette = LibrariumCustomPalleteBase;
            PublisherTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            PublisherTextBox.Size = new Size(468, 45);
            PublisherTextBox.TabIndex = 13;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.CueHint.Color1 = Color.DimGray;
            ISBNTextBox.CueHint.CueHintText = "ISBN";
            ISBNTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            ISBNTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ISBNTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            ISBNTextBox.Location = new Point(874, 197);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Palette = LibrariumCustomPalleteBase;
            ISBNTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ISBNTextBox.Size = new Size(468, 45);
            ISBNTextBox.TabIndex = 16;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.CueHint.Color1 = Color.DimGray;
            AuthorTextBox.CueHint.CueHintText = "Author";
            AuthorTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            AuthorTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            AuthorTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            AuthorTextBox.Location = new Point(874, 115);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Palette = LibrariumCustomPalleteBase;
            AuthorTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            AuthorTextBox.Size = new Size(468, 45);
            AuthorTextBox.TabIndex = 15;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.CueHint.Color1 = Color.DimGray;
            DescriptionTextBox.CueHint.CueHintText = "Description";
            DescriptionTextBox.CueHint.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            DescriptionTextBox.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            DescriptionTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            DescriptionTextBox.Location = new Point(368, 287);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Palette = LibrariumCustomPalleteBase;
            DescriptionTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            DescriptionTextBox.Size = new Size(974, 299);
            DescriptionTextBox.TabIndex = 17;
            DescriptionTextBox.Text = "";
            // 
            // SaveBookButton
            // 
            SaveBookButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            SaveBookButton.Location = new Point(1188, 623);
            SaveBookButton.Name = "SaveBookButton";
            SaveBookButton.Palette = LibrariumCustomPalleteBase;
            SaveBookButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            SaveBookButton.Size = new Size(154, 45);
            SaveBookButton.TabIndex = 18;
            SaveBookButton.Values.Text = "Save";
            SaveBookButton.Click += SaveBookButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            CancelButton.Location = new Point(1000, 623);
            CancelButton.Name = "CancelButton";
            CancelButton.Palette = LibrariumCustomPalleteBase;
            CancelButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            CancelButton.Size = new Size(154, 45);
            CancelButton.TabIndex = 19;
            CancelButton.Values.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            kryptonPictureBox1.Location = new Point(30, 115);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(297, 397);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            kryptonPictureBox1.TabIndex = 20;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            kryptonButton1.Location = new Point(184, 541);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Palette = LibrariumCustomPalleteBase;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton1.Size = new Size(143, 45);
            kryptonButton1.TabIndex = 21;
            kryptonButton1.Values.Text = "Remove";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            kryptonButton2.Location = new Point(30, 541);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Palette = LibrariumCustomPalleteBase;
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton2.Size = new Size(133, 45);
            kryptonButton2.TabIndex = 22;
            kryptonButton2.Values.Text = "Upload";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // BooksAddPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(CancelButton);
            Controls.Add(SaveBookButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(ISBNTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(PublisherTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(BrandLogoPictureBox);
            Controls.Add(PageTitleLabel);
            Name = "BooksAddPage";
            Size = new Size(1482, 857);
            ((System.ComponentModel.ISupportInitialize)BrandLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox BrandLogoPictureBox;
        private Krypton.Toolkit.KryptonLabel PageTitleLabel;
        private Krypton.Toolkit.KryptonCustomPaletteBase LibrariumCustomPalleteBase;
        private Krypton.Toolkit.KryptonTextBox TitleTextBox;
        private Krypton.Toolkit.KryptonTextBox PublisherTextBox;
        private Krypton.Toolkit.KryptonTextBox ISBNTextBox;
        private Krypton.Toolkit.KryptonTextBox AuthorTextBox;
        private Krypton.Toolkit.KryptonRichTextBox DescriptionTextBox;
        private Krypton.Toolkit.KryptonButton SaveBookButton;
        private Krypton.Toolkit.KryptonButton CancelButton;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
