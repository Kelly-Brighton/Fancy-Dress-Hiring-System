using System.Collections.Generic;
using System.Linq;

namespace FancyDressHiringSystem
{
    public class FilterHelper
    {
        public static string BuildQuery(List<string> genders, List<string> sizes, bool hasSearch)
        {
            string query = "SELECT * FROM Clothes WHERE 1=1";

            if (genders.Count > 0)
            {
                query += " AND Gender IN (" + string.Join(",", genders.Select(g => $"'{g}'")) + ")";
            }

            if (sizes.Count > 0)
            {
                query += " AND Size IN (" + string.Join(",", sizes.Select(s => $"'{s}'")) + ")";
            }

            if (hasSearch)
            {
                query += " AND Name LIKE @searchTerm";
            }

            query += " AND Price <= @price";

            return query;
        }
    }
}