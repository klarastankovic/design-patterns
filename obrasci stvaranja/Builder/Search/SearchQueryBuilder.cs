using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Search
{
    public class SearchQueryBuilder : IBuilder
    {
        String query = String.Empty;
        Sort criteria = Sort.Relevance;
        double minPrice = 0.0;
        double maxPrice = double.MaxValue;
        int rating = 1;
        public ISearchParams Build()
        {
            return new SearchParams(query, criteria, rating, minPrice, maxPrice);
        }
        public IBuilder SetSearchTerm(String term) { this.query = term; return this; }
        public IBuilder SetSortCriteria(Sort criteria) { this.criteria = criteria; return this; }
        public IBuilder SetRating(int rating) { this.rating = rating; return this; }
        public IBuilder SetMinPrice(double priceMin) { this.minPrice = priceMin; return this; }
        public IBuilder SetMaxPrice(double priceMax) { this.maxPrice = priceMax; return this; }
    }
}
