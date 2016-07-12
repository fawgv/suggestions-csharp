namespace DaData.Client.Model
{
    public class PartyStateData {
        public string actuality_date    { get; set; }
        public string registration_date { get; set; }
        public string liquidation_date  { get; set; }
        public PartyStatus status       { get; set; }
    }
}