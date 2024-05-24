using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mobiilirakendus.Data;
using Mobiilirakendus.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Mobiilirakendus.ViewModels
{
    public partial class AsjadViewModel : ObservableObject
    {
        private readonly DatabaseContext _databaseContext;

        public ObservableCollection<Asjad> Products { get; } = new();

        [ObservableProperty]
        private Asjad selectedProduct;

        public AsjadViewModel()
        {
            _databaseContext = new DatabaseContext();
            LoadProductsCommand = new AsyncRelayCommand(LoadProductsAsync);
            AddProductCommand = new AsyncRelayCommand(AddProductAsync);
            DeleteProductCommand = new AsyncRelayCommand(DeleteProductAsync);

            SelectedProduct = new Asjad();
        }

        public IAsyncRelayCommand LoadProductsCommand { get; }
        public IAsyncRelayCommand AddProductCommand { get; }
        public IAsyncRelayCommand DeleteProductCommand { get; }

        private async Task LoadProductsAsync()
        {
            var products = await _databaseContext.GetAllProductsAsync();
            Products.Clear();
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }

        private async Task AddProductAsync()
        {
            if (SelectedProduct == null || string.IsNullOrWhiteSpace(SelectedProduct.Name))
            {
                Console.WriteLine("SelectedProduct is null or invalid");
                return;
            }

            await _databaseContext.SaveProductAsync(SelectedProduct);
            await LoadProductsAsync();
            SelectedProduct = new Asjad();
        }

        private async Task DeleteProductAsync()
        {
            if (SelectedProduct == null) return;
            await _databaseContext.DeleteProductAsync(SelectedProduct);
            await LoadProductsAsync();
        }
    }
}
