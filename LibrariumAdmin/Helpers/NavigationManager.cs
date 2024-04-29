namespace LibrariumAdmin.Helpers
{
    public class NavigationManager
    {
        private readonly Panel slotPanel;
        private readonly Dictionary<string, Control> pages = new Dictionary<string, Control>();

        public NavigationManager(Panel slotPanel)
        {
            this.slotPanel = slotPanel;
        }

        public void AddPage(string pageName, Control pageControl)
        {
            pages.TryAdd(pageName, pageControl);
        }

        public void NavigateToPage(string pageName, object? parameter = null)
        {
            if (pages.TryGetValue(pageName, out Control? value))
            {
                Control page = value;
                slotPanel.Controls.Clear();
                slotPanel.Controls.Add(page);

                if (page is INavigable navigablePage)
                {
                    navigablePage.InitializeNavigation(this);
                }

                if (page is IUpdatableDataGrid updatableDataGridPage)
                {
                    updatableDataGridPage.UpdateDataGrid();
                }

                // Pass the parameter to the page if it implements the IPageParameter interface
                if (page is IPageParameter pageWithParameter)
                {
                    pageWithParameter.SetParameter(parameter);
                }
            }
        }

        public void UpdateCurrentPage()
        {
            if (slotPanel.Controls.Count > 0 && slotPanel.Controls[0] is IUpdatableDataGrid updatableDataGridPage)
            {
                updatableDataGridPage.UpdateDataGrid();
            }
        }
    }

    public interface INavigable
    {
        void InitializeNavigation(NavigationManager navigationManager);
    }

    public interface IUpdatableDataGrid
    {
        void UpdateDataGrid();
    }

    public interface IPageParameter
    {
        void SetParameter(object? parameter);
    }
}
