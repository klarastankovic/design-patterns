using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Search
{
    public static class SearchTester
    {
        public static void Search()
        {
            IBuilder builder = new SearchQueryBuilder();
            SearchDirector director = new SearchDirector(builder);
            // Using builder
            ISearchParams parameters = builder.SetSearchTerm("tablet").SetRating(5)
                .SetSortCriteria(Sort.PriceHighToLow).Build();
            // Using director
            ISearchParams defaults = director.DefaultSearchParameters("tablet");
            Console.WriteLine(parameters.Display());
            Console.WriteLine(defaults.Display());
        }
    }
}
