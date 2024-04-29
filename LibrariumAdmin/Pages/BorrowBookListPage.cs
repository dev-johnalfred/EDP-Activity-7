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
    public partial class BorrowBookListPage : UserControl, INavigable, IPageParameter, IUpdatableDataGrid
    {
        private NavigationManager? navigationManager;
        private int patronId;
        public BorrowBookListPage()
        {
            InitializeComponent();
            LoadBooks();
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
            }
        }

        private void LoadBooks()
        {
            List<BookModel> books = BookBackend.GetBooks();

            BooksDataGridView.Rows.Clear();

            if (books != null)
            {
                foreach (var book in books)
                {
                    BooksDataGridView.Rows.Add(book.Thumbnail, book.Title, book.Author, book.Publisher, book.BookID, book.ISBN, book.Status);
                }
            }
        }

        public void UpdateDataGrid()
        {
            LoadBooks();
        }

        private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                var cellRect = BooksDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                IconButton AddToBagButton = new IconButton(Properties.Resources.PlusIcon);
                AddToBagButton.Size = new Size(48, 48);
                var centerXEdit = cellRect.X + 5;
                var centerYEdit = cellRect.Y + cellRect.Height / 2 - AddToBagButton.Height / 2;
                AddToBagButton.Location = new Point(centerXEdit, centerYEdit);
                AddToBagButton.Click += (s, ev) =>
                {
                    var bookId = (int)BooksDataGridView.Rows[e.RowIndex].Cells[4].Value;
                    BagBackend.AddBookToBag(patronId, bookId);
                };

                BooksDataGridView.Controls.Add(AddToBagButton);
            }
        }

        private void CheckBagButton_Click_1(object sender, EventArgs e)
        {
            navigationManager?.NavigateToPage("ListBagBooks", patronId);
        }
    }
}
