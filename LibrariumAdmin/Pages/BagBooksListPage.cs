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
    public partial class BagBooksListPage : UserControl, INavigable, IPageParameter
    {
        private NavigationManager? navigationManager;
        private int patronId;
        public BagBooksListPage()
        {
            InitializeComponent();
        }
        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public void SetParameter(object? parameter)
        {
            if (parameter is int patronId)
            {
                this.patronId = patronId;

                List<BookModel>? books = BagBackend.CheckBooksInBag(patronId);
                BooksDataGridView.Rows.Clear();
                foreach (var book in books)
                {
                    BooksDataGridView.Rows.Add(book.Thumbnail, book.Title, book.Author, book.Publisher, book.BookID, book.ISBN, book.Status);
                }
            }
        }

        private void ConfirmTransactionButton_Click(object sender, EventArgs e)
        {
            List<BookModel>? books = BagBackend.CheckBooksInBag(patronId);
            TransactionBackend.ConfirmTransaction(patronId, books);

            // Show a message box indicating that the transaction was successful
            MessageBox.Show("Transaction successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BagBackend.ClearBag(patronId);
            BooksDataGridView.Rows.Clear();
            navigationManager?.NavigateToPage("ListTransactions");
        }

    }
}
