using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Search
{
    public class SearchDirector
    {
        IBuilder builder;
        public SearchDirector(IBuilder builder) { this.builder = builder; }
        public void SetBuilder(IBuilder builder) { this.builder = builder; }
        public ISearchParams DefaultSearchParameters(String term)
        {
            return builder.SetSearchTerm(term).SetRating(3)
                .SetMinPrice(0.0).SetMaxPrice(1000.0)
                .SetSortCriteria(Sort.Relevance).Build();
        }
    }
}
