using Cenito.iSnip.ViewModels.Interface;
using GalaSoft.MvvmLight;

namespace Cenito.iSnip.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        public MainViewModel()
        {
            Title = "iSnip";
        }

        public string Title { get; private set; }
    }
}