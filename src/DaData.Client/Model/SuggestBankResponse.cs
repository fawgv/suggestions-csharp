using System.Collections.Generic;

namespace DaData.Client.Model
{
    public class SuggestBankResponse {
        public class Suggestions: Suggestion {
            public BankData data { get; set; }
        }
        public List<Suggestions> suggestionss { get; set; }
    }
}