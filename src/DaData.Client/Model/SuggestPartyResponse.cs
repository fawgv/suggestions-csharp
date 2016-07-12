using System.Collections.Generic;

namespace DaData.Client.Model {
    public class SuggestPartyResponse {
        public class Suggestions: Suggestion {
            public PartyData data { get; set; }
        }
        public List<Suggestions> suggestionss { get; set; }
    }
}