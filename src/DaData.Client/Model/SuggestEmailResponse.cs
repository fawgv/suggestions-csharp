using System.Collections.Generic;

namespace DaData.Client.Model
{
    public class SuggestEmailResponse {
        public class Suggestions: Suggestion {
            public EmailData data { get; set; }
        }
        public List<Suggestions> suggestionss { get; set; }
    }
}