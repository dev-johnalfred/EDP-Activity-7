using Krypton.Toolkit;

namespace LibrariumAdmin.Widgets
{
    public partial class IconButton : KryptonButton
    {
        public IconButton()
        {
            InitializeComponent();
        }

        public IconButton(Image icon)
        {
            InitializeComponent();
            this.StateCommon.Back.Image = icon;
        }

        private void InitializeComponent()
        {
            this.StateCommon.Back.Color1 = Color.White;
            this.StateCommon.Back.Color2 = Color.White;
            this.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterMiddle;
            this.StateCommon.Border.Rounding = 8F;
            this.Text = "";
        }
    }
}
