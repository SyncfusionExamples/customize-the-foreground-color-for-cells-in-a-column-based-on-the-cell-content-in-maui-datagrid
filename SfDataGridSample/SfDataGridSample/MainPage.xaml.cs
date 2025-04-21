using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void datagrid_CellLongPress(object sender, DataGridCellLongPressEventArgs e)
        {
            viewModel.Employees.Remove((Employee)e.RowData);
        }
    }
}
