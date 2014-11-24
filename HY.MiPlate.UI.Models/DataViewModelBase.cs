using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.MiPlate.UI.Models
{
    public class DataViewModelBase
    {
        public bool IsSuccessful { get; set; }
        public string ResponseMessage  { get; set; }
        public int TotailRecords { get; set; }
        public string View { get; set; }
    }

    public class DataViewModelBase<TSubModel> : DataViewModelBase
    {
        public TSubModel Data { get; set; }
        public IEnumerable<TSubModel> DataList { get; set; }
    }
}
