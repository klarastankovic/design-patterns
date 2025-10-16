using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Search
{
    public interface ISearchParams
    {
        String Term { get; }
        Sort Criteria { get; }
        int MinRating { get; }
        double MinPrice { get; }
        double MaxPrice { get; }
        String Display();
    }

    public enum Sort { Relevance, PriceLowToHigh, PriceHighToLow }
}
