using LearnMVVM.Model;
using LearnMVVM.MVVM;
using System.Collections.ObjectModel;

namespace LearnMVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => SaveItem(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                OnPropertyChanged();
            }
        }
        public void AddItem()
        {
            Items.Add(new Item
            { Name = "S001",
            SerialNumber = "XXXX",
            Quantity = 0
            });

        }

        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }

        private void SaveItem()
        {
            //Save
        }
        private bool CanSave()
        {
            return true;
            //bool value
        }

    }
}
