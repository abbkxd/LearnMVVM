using LearnMVVM.Model;
using LearnMVVM.MVVM;
using System.Collections.ObjectModel;

namespace LearnMVVM.ViewModel
{
    internal class MainWindowViewModel:ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item() {
                Name = "Item1",
                SerialNumber="S001",
                Quantity=1
            });
            Items.Add(new Item()
            {
                Name = "Item2",
                SerialNumber = "S002",
                Quantity = 4
            });
            Items.Add(new Item()
            {
                Name = "Item3",
                SerialNumber = "S003",
                Quantity = 6
            });
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                OnPropertyChanged();
            }
        }


    }
}
