using LibrariumAdmin.Backend;
using LibrariumAdmin.Helpers;
using LibrariumAdmin.Models;
using LibrariumAdmin.Widgets;
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
    public partial class PatronsListPage : UserControl, INavigable, IUpdatableDataGrid
    {
        private NavigationManager? navigationManager;
        public PatronsListPage()
        {
            InitializeComponent();
            LoadPatrons();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        private void LoadPatrons()
        {
            List<PatronModel> patrons = PatronBackend.GetPatrons();

            PatronsDataGridView.Rows.Clear();

            foreach (var patron in patrons)
            {
                PatronsDataGridView.Rows.Add(patron.Avatar, patron.PatronID, patron.FirstName + " " + patron.LastName, patron.Email, patron.PhoneNumber);
            }
        }

        public void UpdateDataGrid()
        {
            LoadPatrons();
        }

        private void AddPatronButton_Click(object sender, EventArgs e)
        {
            navigationManager?.NavigateToPage("AddPatrons");
        }

        private void PatronsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var cellRect = PatronsDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                IconButton EditButton = new IconButton(Properties.Resources.EditIcon);
                EditButton.Size = new Size(48, 48);
                var centerXEdit = cellRect.X + 5;
                var centerYEdit = cellRect.Y + cellRect.Height / 2 - EditButton.Height / 2;
                EditButton.Location = new Point(centerXEdit, centerYEdit);
                EditButton.Click += (s, ev) =>
                {
                    var patronId = (int)PatronsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    navigationManager?.NavigateToPage("EditPatrons", patronId);
                };

                IconButton DeleteButton = new IconButton(Properties.Resources.DeleteIcon);
                DeleteButton.Size = new Size(48, 48);
                var centerXDelete = centerXEdit + EditButton.Width + 5; // Adjust this value as needed for spacing
                var centerYDelete = cellRect.Y + cellRect.Height / 2 - DeleteButton.Height / 2;
                DeleteButton.Location = new Point(centerXDelete, centerYDelete);
                DeleteButton.Click += (s, ev) =>
                {
                    var patronId = (int)PatronsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    if (MessageBox.Show("Are you sure you want to delete this patron?", "Delete Patron", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PatronBackend.DeletePatron(patronId);
                        navigationManager?.NavigateToPage("ListPatrons");
                    }
                };

                PatronsDataGridView.Controls.Add(EditButton);
                PatronsDataGridView.Controls.Add(DeleteButton);
            }
        }

        private void RemoveButtons()
        {
            // Remove all edit and delete buttons
            foreach (Control control in PatronsDataGridView.Controls.OfType<IconButton>().ToList())
            {
                PatronsDataGridView.Controls.Remove(control);
                control.Dispose(); // Dispose to release resources
            }
        }

        private void PatronsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RemoveButtons();

        }
    }
}
