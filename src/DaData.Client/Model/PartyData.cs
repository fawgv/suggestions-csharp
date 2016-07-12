namespace DaData.Client.Model
{
    public class PartyData {
        public SuggestAddressResponse.Suggestions address { get; set; }
        public string branch_count              { get; set; }
        public PartyBranchType branch_type      { get; set; }
        public string inn                       { get; set; }
        public string kpp                       { get; set; }
        public PartyManagementData management   { get; set; }
        public PartyNameData name               { get; set; }
        public string ogrn                      { get; set; }
        public string okpo                      { get; set; }
        public string okved                     { get; set; }
        public PartyOpfData opf                 { get; set; }
        public PartyStateData state             { get; set; }
        public PartyType type                   { get; set; }
    }
}