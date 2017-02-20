using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStockQuote
{
    public class StockQuotes
    {
        public Dictionary<string, StockQuote> Quotes { get; set; }
        /// <summary>
        /// Initializes a new instance of a Stock Quotes requested based on a companys' stock names or symbols. For example
        /// Microsoft's symbol would be 'msft'
        /// </summary>
        /// <param name="Symbols">List of symbols to look up</param>
        /// <param name="FromDate">Period From Date</param>
        /// <param name="ToDate">>Period To Date</param>
        /// <param name="ResolutionOfData">Resolution of the data (Daily='d' or Weekly='w')</param>
        public StockQuotes(List<string> Symbols, DateTime FromDate, DateTime ToDate, string ResolutionOfData)
        {
            Quotes = new Dictionary<string, StockQuote>();
            GetQuotes(Symbols, FromDate, ToDate, ResolutionOfData);
        }
        /// <summary>
        /// Initializes a new instance of a Stock Quotes requested based on a companys' stock names or symbols. For example
        /// Microsoft's symbol would be 'msft'. With default parameters:
        /// From Date: 30 Days ago
        /// To Date: Today's date
        /// Resolution of Data: daily
        /// </summary>
        /// <param name="Symbols">List of symbols to look up</param>
        public StockQuotes(List<string> Symbols)
        {
            DateTime ToDate = DateTime.Today;
            DateTime FromDate = ToDate.AddDays(-30);
            string ResolutionOfData = "d";

            Quotes = new Dictionary<string, StockQuote>();
            GetQuotes(Symbols, FromDate, ToDate, ResolutionOfData);
        }
        /// <summary>
        /// Initializes a new instance of a Stock Quotes requested based on a companys' stock names or symbols. For example
        /// Microsoft's symbol would be 'msft'. With default parameters:
        /// From Date: 30 Days ago
        /// To Date: Today's date
        /// </summary>
        /// <param name="Symbols">List of symbols to look up</param>
        public StockQuotes(List<string> Symbols, string ResolutionOfData)
        {
            DateTime ToDate = DateTime.Today;
            DateTime FromDate = ToDate.AddDays(-30);

            Quotes = new Dictionary<string, StockQuote>();
            GetQuotes(Symbols, FromDate, ToDate, ResolutionOfData);
        }
        /// <summary>
        /// Initializes a new instance of a Stock Quotes requested based on a companys' stock names or symbols. For example
        /// Microsoft's symbol would be 'msft'. With default parameters:
        /// To Date: Today's date
        /// Resolution of Data: daily
        /// </summary>
        /// <param name="Symbols">List of symbols to look up</param>
        public StockQuotes(List<string> Symbols, DateTime FromDate)
        {
            DateTime ToDate = DateTime.Today;
            string ResolutionOfData = "d";

            Quotes = new Dictionary<string, StockQuote>();
            GetQuotes(Symbols, FromDate, ToDate, ResolutionOfData);
        }
        /// <summary>
        /// Initializes a new instance of a Stock Quotes requested based on a companys' stock names or symbols. For example
        /// Microsoft's symbol would be 'msft'. With default parameters:
        /// To Date: Today's date
        /// </summary>
        /// <param name="Symbols">List of symbols to look up</param>
        public StockQuotes(List<string> Symbols, DateTime FromDate, string ResolutionOfData)
        {
            DateTime ToDate = DateTime.Today;

            Quotes = new Dictionary<string, StockQuote>();
            GetQuotes(Symbols, FromDate, ToDate, ResolutionOfData);
        }

        //Get the quotes
        private void GetQuotes(List<string> Symbols, DateTime FromDate, DateTime ToDate, string ResolutionOfData)
        {
            foreach (string symbol in Symbols)
            {
                if (!Quotes.ContainsKey(symbol.Trim().ToLower()))
                    Quotes.Add(symbol.Trim().ToLower(), new StockQuote(symbol, FromDate, ToDate, ResolutionOfData));
            }
        }
    }
}
