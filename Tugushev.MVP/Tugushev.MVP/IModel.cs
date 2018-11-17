using System.Collections.Generic;

namespace Tugushev.MVP
{
    internal interface IModel
    {
        IEnumerable<string> GetResults(string searchCriteria);
    }
}