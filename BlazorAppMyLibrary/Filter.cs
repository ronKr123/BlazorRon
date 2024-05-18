using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorAppMyLibrary
{
    public class Filter
    {
       public string BookNameTxt { get; set; }
       public int GenreBookCode { get; set; }
       public int WriterBookCode { get; set; }

       public string BuildFilter()
       {
            string query = "SELECT * FROM bookTbl WHERE";

            if (!string.IsNullOrEmpty(BookNameTxt))
            {
                query += $" bookName LIKE '{BookNameTxt}%' AND";
            }

            if(GenreBookCode != 0)
            {
                query += $" genreCode = {GenreBookCode} AND";
            }

            if(WriterBookCode != 0)
            {
                query += $" writerCode = {WriterBookCode} ";
            }

            if(query.EndsWith(" AND") || query.EndsWith(" WHERE"))
            {
                query = query.Remove(query.Length - 4);
            }

            return query;
       }


    }
}
