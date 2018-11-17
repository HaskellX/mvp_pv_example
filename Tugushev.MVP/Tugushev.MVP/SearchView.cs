using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugushev.MVP
{
    public partial class SearchView : Form, ISearchView
    {
        public string SearchCriteria => this.searchCriteriaTextBox.Text;
        public IEnumerable<string> Results
        {
            set
            {
                this.dataGridView.DataSource = value.Select(x => new { Value = x }).ToList();
            }
        }
        public event Action OnSearch;

        public SearchView()
        {
            InitializeComponent();
        }

        private void searchButtonClick(object sender, EventArgs e)
        {
            OnSearch();
        }

        public new void Show()
        {
            Application.Run(this);
        }
    }
}
