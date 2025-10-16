using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Search
{
    public class SearchParams : ISearchParams
    {
        String term;
        Sort criteria;
        int minRating;
        double minPrice, maxPrice;
        public string Term { get { return term; } private set {  term = value; } }
        public Sort Criteria { get { return criteria; } private set { criteria = value; } }
        public int MinRating { get { return minRating; } private set { minRating = value; } }
        public double MinPrice { get { return minPrice; } private set { minPrice = value; } }
        public double MaxPrice { get { return maxPrice; } private set { maxPrice = value; } }
        public SearchParams(string term, Sort criteria, int minRating, double minPrice, double maxPrice)
        {
            Term = term;
            Criteria = criteria;
            MinRating = minRating;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
        }
        public string Display()
        {
            return String.Format("Search for {0} in products where rating {1} and" +
                "min. price > {2} and max. price < {3} order the results by {4}", Term, MinRating, MinPrice, MaxPrice, Criteria);
        }
    }
}
