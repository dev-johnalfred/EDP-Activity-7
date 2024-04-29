namespace LibrariumAdmin.Forms
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LoginButton = new Krypton.Toolkit.KryptonButton();
            LibrariumCustomPalleteBase = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            ForgotPasswordLabel = new Krypton.Toolkit.KryptonLabel();
            AdminUsernameTextBox = new Krypton.Toolkit.KryptonTextBox();
            PasswordTextBox = new Krypton.Toolkit.KryptonTextBox();
            BrandNameLabel = new Krypton.Toolkit.KryptonLabel();
            BrandLogoPictureBox = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)BrandLogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            LoginButton.Location = new Point(378, 365);
            LoginButton.Name = "LoginButton";
            LoginButton.Palette = LibrariumCustomPalleteBase;
            LoginButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            LoginButton.Size = new Size(112, 50);
            LoginButton.TabIndex = 2;
            LoginButton.Values.Text = "Login";
            LoginButton.Click += LoginButton_Click;
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
            LibrariumCustomPalleteBase.CueHintText.Color1 = Color.DimGray;
            LibrariumCustomPalleteBase.CueHintText.CueHintText = "Test";
            LibrariumCustomPalleteBase.CueHintText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.CueHintText.Padding = new Padding(4);
            LibrariumCustomPalleteBase.CueHintText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Back.Color1 = Color.White;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = Color.DarkGray;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.Color2 = Color.DarkGray;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 8F;
            LibrariumCustomPalleteBase.InputControlStyles.InputControlCustom1.StateCommon.Content.Padding = new Padding(8);
            LibrariumCustomPalleteBase.LabelStyles.LabelCustom1.StateNormal.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrariumCustomPalleteBase.ThemeName = "";
            LibrariumCustomPalleteBase.UseKryptonFileDialogs = true;
            // 
            // ForgotPasswordLabel
            // 
            ForgotPasswordLabel.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            ForgotPasswordLabel.Location = new Point(59, 380);
            ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            ForgotPasswordLabel.Palette = LibrariumCustomPalleteBase;
            ForgotPasswordLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ForgotPasswordLabel.Size = new Size(159, 25);
            ForgotPasswordLabel.StateCommon.ShortText.Color1 = Color.Gray;
            ForgotPasswordLabel.TabIndex = 3;
            ForgotPasswordLabel.Values.Text = "Forgot Password?";
            // 
            // AdminUsernameTextBox
            // 
            AdminUsernameTextBox.CueHint.Color1 = Color.DimGray;
            AdminUsernameTextBox.CueHint.CueHintText = "Admin Username";
            AdminUsernameTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            AdminUsernameTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            AdminUsernameTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            AdminUsernameTextBox.Location = new Point(59, 192);
            AdminUsernameTextBox.Name = "AdminUsernameTextBox";
            AdminUsernameTextBox.Palette = LibrariumCustomPalleteBase;
            AdminUsernameTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            AdminUsernameTextBox.Size = new Size(431, 45);
            AdminUsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.CueHint.Color1 = Color.DimGray;
            PasswordTextBox.CueHint.CueHintText = "Password";
            PasswordTextBox.CueHint.Font = new Font("Century Gothic", 10F);
            PasswordTextBox.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            PasswordTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            PasswordTextBox.Location = new Point(59, 275);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Palette = LibrariumCustomPalleteBase;
            PasswordTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(431, 45);
            PasswordTextBox.TabIndex = 1;
            // 
            // BrandNameLabel
            // 
            BrandNameLabel.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            BrandNameLabel.Location = new Point(110, 81);
            BrandNameLabel.Name = "BrandNameLabel";
            BrandNameLabel.Palette = LibrariumCustomPalleteBase;
            BrandNameLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            BrandNameLabel.Size = new Size(137, 38);
            BrandNameLabel.StateCommon.ShortText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandNameLabel.TabIndex = 5;
            BrandNameLabel.Values.Text = "Librarium";
            // 
            // BrandLogoPictureBox
            // 
            BrandLogoPictureBox.Image = Properties.Resources.LibrariumLogo;
            BrandLogoPictureBox.Location = new Point(59, 74);
            BrandLogoPictureBox.Name = "BrandLogoPictureBox";
            BrandLogoPictureBox.Size = new Size(48, 48);
            BrandLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BrandLogoPictureBox.TabIndex = 6;
            BrandLogoPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 479);
            Controls.Add(BrandLogoPictureBox);
            Controls.Add(BrandNameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(AdminUsernameTextBox);
            Controls.Add(ForgotPasswordLabel);
            Controls.Add(LoginButton);
            MaximizeBox = false;
            Name = "LoginForm";
            Palette = LibrariumCustomPalleteBase;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)BrandLogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonButton LoginButton;
        private Krypton.Toolkit.KryptonCustomPaletteBase LibrariumCustomPalleteBase;
        private Krypton.Toolkit.KryptonLabel ForgotPasswordLabel;
        private Krypton.Toolkit.KryptonTextBox AdminUsernameTextBox;
        private Krypton.Toolkit.KryptonTextBox PasswordTextBox;
        private Krypton.Toolkit.KryptonLabel BrandNameLabel;
        private Krypton.Toolkit.KryptonPictureBox BrandLogoPictureBox;
    }
}