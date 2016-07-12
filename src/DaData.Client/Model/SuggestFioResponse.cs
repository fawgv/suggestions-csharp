using System.Collections.Generic;

namespace DaData.Client.Model
{
    public class SuggestFioResponse {
        public class Suggestions: Suggestion {
            public FioData data { get; set; }
        }
        public List<Suggestions> suggestionss { get; set; }
    }
}