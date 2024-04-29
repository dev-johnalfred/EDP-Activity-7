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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrariumAdmin.Pages
{
    public partial class TransactionsListPage : UserControl, INavigable
    {
        private NavigationManager? navigationManager;

        public TransactionsListPage()
        {
            InitializeComponent();
            LoadTransactions();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        private void LoadTransactions()
        {
            List<TransactionViewModel> transactions = TransactionBackend.GetTransactions();

            TransactionsDataGridView.Rows.Clear();

            foreach (var transaction in transactions)
            {
                TransactionsDataGridView.Rows.Add(transaction.TransactionHeaderID, transaction.Avatar, transaction.FirstName + " " + transaction.LastName, transaction.PatronID, transaction.CreatedAt);
            }
        }

        private void NewTransactionButton_Click(object sender, EventArgs e)
        {
            // Prompt the user to enter the PatronID
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter PatronID:", "Enter PatronID", "");

            // Check if the user entered a PatronID
            if (!string.IsNullOrEmpty(input))
            {
                // Convert the input to an integer (assuming PatronID is an integer)
                if (int.TryParse(input, out int patronID))
                {
                    // Use the PatronBackend to find the patron
                    var patron = PatronBackend.FindPatronById(patronID);

                    // Check if the patron is found
                    if (patron != null)
                    {
                        // Patron found, you can proceed with your transaction logic
                        // For example, display the patron's information in a MessageBox
                        MessageBox.Show($"Patron Found!\nName: {patron.FirstName} {patron.LastName}\nID: {patron.PatronID}");
                        BagBackend.AddNewBag(patronID);
                        navigationManager?.NavigateToPage("ListBorrowBooks", patronID);
                    }
                    else
                    {
                        MessageBox.Show("Patron not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid PatronID. Please enter a valid integer.");
                }
            }
            else
            {
                MessageBox.Show("No PatronID entered. Please enter a PatronID.");
            }
        }

        private void TransactionsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var cellRect = TransactionsDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                IconButton EyeButton = new IconButton(Properties.Resources.EyeIcon);
                EyeButton.Size = new Size(48, 48);
                var centerXEdit = cellRect.X + 5;
                var centerYEdit = cellRect.Y + cellRect.Height / 2 - EyeButton.Height / 2;
                EyeButton.Location = new Point(centerXEdit, centerYEdit);
                EyeButton.Click += (s, ev) =>
                {
                    var patronId = (int)TransactionsDataGridView.Rows[e.RowIndex].Cells[3].Value;
                    navigationManager?.NavigateToPage("ViewTransactions", patronId);
                };

                TransactionsDataGridView.Controls.Add(EyeButton);
            }
        }
    }
}
