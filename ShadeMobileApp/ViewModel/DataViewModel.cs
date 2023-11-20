using ShadeMobileApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadeMobileApp.ViewModel
{
    public class DataViewModel
    {
        public ObservableCollection<DataModel> Data { get; set; }

        public DataViewModel()
        {
            Data = new ObservableCollection<DataModel>()
        {
            new DataModel("Days", 50),
            new DataModel("Days", 10),
        };
        }

    }
}
