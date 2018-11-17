using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugushev.MVP
{
    class SearchPresenter
    {
        ISearchView searchView;
        IModel model;

        public SearchPresenter (ISearchView view, IModel model)
        {
            this.searchView = view;
            this.model = model;
            searchView.OnSearch += Login;
        }

        public void Show()
        {
            searchView.Show();
        }

        private void Login()
        {
            IEnumerable<string> result = model.GetResults(searchView.SearchCriteria);
            searchView.Results = result.ToArray();
        }
    }
}
