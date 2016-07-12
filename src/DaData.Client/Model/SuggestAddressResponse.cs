using System.Collections.Generic;

namespace DaData.Client.Model
{
    public class SuggestAddressResponse
    {
        public class Suggestions : Suggestion
        {
            public AddressData data { get; set; }
        }
        public List<Suggestions> suggestionss { get; set; }
    }    
}