namespace DaData.Client.Model
{
    public class BankData {
        public SuggestAddressResponse.Suggestions address              { get; set; }
        public string bic                       { get; set; }
        public string correspondent_account     { get; set; }
        public BankNameData name                { get; set; }
        public string okpo                      { get; set; }
        public BankOpfData opf                  { get; set; }
        public string phone                     { get; set; }
        public string registration_number       { get; set; }
        public string rkc                       { get; set; }
        public PartyStateData state             { get; set; }
        public string swift                     { get; set; }
    }
}