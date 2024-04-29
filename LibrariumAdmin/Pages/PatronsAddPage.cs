using Krypton.Toolkit;
using LibrariumAdmin.Backend;
using LibrariumAdmin.Helpers;
using LibrariumAdmin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrariumAdmin.Pages
{
    public partial class PatronsAddPage : UserControl, INavigable
    {
        private NavigationManager? navigationManager;

        public PatronsAddPage()
        {
            InitializeComponent();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        private void ClearInput()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            EmailTextBox.Clear();
            PatronPictureAvatar.Image = null;
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            byte[]? avatar = null;
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;
            string email = EmailTextBox.Text;

            if (PatronPictureAvatar.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert the image to a byte array
                    PatronPictureAvatar.Image.Save(ms, PatronPictureAvatar.Image.RawFormat);
                    avatar = ms.ToArray();
                }
            }

            PatronModel newPatron = new()
            {
                Avatar = avatar,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email,
            };

            PatronBackend.AddPatron(newPatron);
            MessageBox.Show("Patron registered successful!");

            ClearInput();

            navigationManager?.NavigateToPage("ListPatrons");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearInput();
            navigationManager?.NavigateToPage("ListPatrons");
        }

        private void UploadAvatarButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PatronPictureAvatar.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void RemoveAvatarButton_Click(object sender, EventArgs e)
        {
            PatronPictureAvatar.Image = null;
        }


    }
}
