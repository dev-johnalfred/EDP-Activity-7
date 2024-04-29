using LibrariumAdmin.Backend;
using LibrariumAdmin.Helpers;
using LibrariumAdmin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrariumAdmin.Pages
{
    public partial class PatronsEditPage : UserControl, INavigable, IPageParameter
    {
        private NavigationManager? navigationManager;

        private int patronId;
        public PatronsEditPage()
        {
            InitializeComponent();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public void SetParameter(object? parameter)
        {
            if (parameter is int id)
            {
                patronId = id;
                PatronModel? patron = PatronBackend.GetPatronById(patronId);
                if (patron != null)
                {
                    FirstNameTextBox.Text = patron.FirstName;
                    LastNameTextBox.Text = patron.LastName;
                    EmailTextBox.Text = patron.Email;
                    PhoneNumberTextBox.Text = patron.PhoneNumber;

                    if (patron.Avatar != null && patron.Avatar.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(patron.Avatar))
                        {
                            Image image = Image.FromStream(ms);
                            PatronPictureAvatar.Image = image;
                        }
                    }
                }
            }
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
                    PatronPictureAvatar.Image.Save(ms, PatronPictureAvatar.Image.RawFormat);
                    avatar = ms.ToArray();
                }
            }

            PatronModel updatePatron = new()
            {
                PatronID = patronId,
                Avatar = avatar,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email,
            };

            PatronBackend.UpdatePatron(updatePatron);
            MessageBox.Show("Patron updated successfully!");

            ClearInput();

            navigationManager?.NavigateToPage("ListPatrons");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
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
