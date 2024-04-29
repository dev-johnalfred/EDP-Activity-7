using Krypton.Toolkit;
using LibrariumAdmin.Helpers;
using LibrariumAdmin.Pages;

namespace LibrariumAdmin.Forms
{
    public partial class DashboardForm : KryptonForm
    {
        readonly NavigationManager navigationManager;
        public DashboardForm()
        {
            InitializeComponent();
            navigationManager = new NavigationManager(SlotFlowLayoutPanel);

            // Overview Page
            navigationManager.AddPage("Home", new OverviewPage());

            // Books Pages
            navigationManager.AddPage("ListBooks", new BooksListPage());
            navigationManager.AddPage("AddBooks", new BooksAddPage());
            navigationManager.AddPage("EditBooks", new BooksEditPage());

            // Patrons Page
            navigationManager.AddPage("ListPatrons", new PatronsListPage());
            navigationManager.AddPage("AddPatrons", new PatronsAddPage());
            navigationManager.AddPage("EditPatrons", new PatronsEditPage());

            // Transactions Page
            navigationManager.AddPage("ListTransactions", new TransactionsListPage());
            navigationManager.AddPage("ViewTransactions", new TransactionsViewPage());

            // Borrow Book Page
            navigationManager.AddPage("ListBorrowBooks", new BorrowBookListPage());

            // Bag Page
            navigationManager.AddPage("ListBagBooks", new BagBooksListPage());

            // Default Page
            navigationManager.NavigateToPage("Home");
        }

        private void OverviewNavButton_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateToPage("Home");
        }

        private void BooksNavButton_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateToPage("ListBooks");
        }

        private void PatronsNavButton_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateToPage("ListPatrons");
        }

        private void TransactionsNavButton_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateToPage("ListTransactions");
        }
    }
}
