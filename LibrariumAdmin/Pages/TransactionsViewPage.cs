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
using static System.Reflection.Metadata.BlobBuilder;

namespace LibrariumAdmin.Pages
{
    public partial class TransactionsViewPage : UserControl, INavigable, IPageParameter
    {
        private NavigationManager? navigationManager;
        private int patronId;
        public TransactionsViewPage()
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
                    PatronIDValue.Text = patron.PatronID.ToString();
                    NameValue.Text = patron.FirstName + " " + patron.LastName;
                    EmailValue.Text = patron.Email;
                    PhoneNumberValue.Text = patron.PhoneNumber;
                }

                List<BookModel>? books = TransactionBackend.ViewTransactionBooks(patronId);
                if (books != null)
                {
                    TransactionBooksDataGridView.Rows.Clear();
                    foreach (var book in books)
                    {
                        TransactionBooksDataGridView.Rows.Add(book.Thumbnail, book.Title, book.BookID, book.Status);
                    }
                }

                TransactionHeaderModel? transaction = TransactionBackend.GetTransactionHeaderById(patronId);
                if (transaction != null)
                {
                    TransactionIDValue.Text = transaction.TransactionHeaderID.ToString();
                    TransactionDateValue.Text = transaction.CreatedAt;
                }
            }
        }
    }
}
