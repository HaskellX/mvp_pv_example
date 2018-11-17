using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugushev.MVP
{
    interface ISearchView : IView
    {
        string SearchCriteria { get; }
        IEnumerable<string> Results { set; }
        event Action OnSearch;
    }
}
