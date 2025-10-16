using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Search
{
    public interface IBuilder
    {
        ISearchParams Build();
        IBuilder SetSearchTerm(String term);
        IBuilder SetSortCriteria(Sort criteria);
        IBuilder SetRating(int rating);
        IBuilder SetMaxPrice(double priceMax);
        IBuilder SetMinPrice(double priceMin);
    }
}
