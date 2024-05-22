using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mobiilirakendus.Data;
using Mobiilirakendus.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Mobiilirakendus.ViewModels
{
    public class AsjadViewModel : ObservableObject
    {
        private readonly DatabaseContext _databaseContext;
        public ObservableCollection<Asjad> Asjads { get; } = new();

        [ObservableProperty]
        private Asjad _selectedAsjad;
    }
}
