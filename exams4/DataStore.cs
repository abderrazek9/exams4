using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace exams4
{
    public class DataStore
    {
        private static readonly Lazy<DataStore> lazy = new Lazy<DataStore>(() => new DataStore());
        public static DataStore Instance { get { return lazy.Value; } }

        public ObservableCollection<ItemModel> Items { get; private set; }

        private DataStore()
        {
            Items = new ObservableCollection<ItemModel>();
        }
    }
}

