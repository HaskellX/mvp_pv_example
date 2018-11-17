using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugushev.MVP
{
    class Model : IModel
    {
        List<string> ls;

        public Model()
        {
            ls = new List<string>();
            AddMockValues();
        }

        private void AddMockValues()
        {
            ls.Add("Москва");
            ls.Add("Ачинск");
            ls.Add("Апатиты");
            ls.Add("Самара");
            ls.Add("Казань");
            ls.Add("Санкт-Петербург");
            ls.Add("Якутск");
            ls.Add("Архангельск");
            ls.Add("Мурманск");
            ls.Add("Хабаровск");
            ls.Add("Комсомольск-на-Амуре");
            ls.Add("Екатеринбург");
        }

        public IEnumerable<string> GetResults(string searchCriteria)
        {
            return ls.Where(x => x.Contains(searchCriteria)).ToArray();
        }
    }
}
