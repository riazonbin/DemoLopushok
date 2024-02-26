using LopushokDemo.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LopushokDemo.Pages
{
    /// <summary>
    /// Interaction logic for ProductsListPage.xaml
    /// </summary>
    public partial class ProductsListPage : Page
    {
        private List<Product> _products = new List<Product>();
        private Func<Product, object> _sortingQuery = x => x.Name;
        private Predicate<Product> _filterQuery = x => true;

        public ProductsListPage()
        {
            InitializeComponent();
            _products = App.Connection.Product.ToList();
            lvProducts.ItemsSource = _products;

            var filters = new List<ProductType> { new ProductType { Name = "Все типы" } };
            filters.AddRange(App.Connection.ProductType.ToList());
            cbFilter.ItemsSource = filters;
            cbFilter.SelectedIndex = 0;

            var sorts = new List<string> {
            "Без сортировки",
             "Наименование", "Номер производственного цеха ",
            "Минимальная стоимость для агента"};
            cbSort.ItemsSource = sorts;
            cbSort.SelectedIndex = 0;

            cbSortOrders.ItemsSource = new List<string> { "По убыванию", "По возрастанию" };
            cbSortOrders.SelectedIndex = 0;
        }

        private void ReloadData()
        {
            _products = App.Connection.Product
            .ToList()
            .Where(x => _filterQuery(x))
                .OrderBy(x => _sortingQuery(x))
                .ToList();
            SearchData();
        }

        private void SearchData()
        {
            lvProducts.ItemsSource = _products
                .Where(x => string.Join(" ", x.Name).ToLower().Contains(tbSearch.Text.ToLower()));
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchData();
        }

        private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
