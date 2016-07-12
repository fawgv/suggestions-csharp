namespace DaData.Client.Model
{
    public class SuggestQuery {
        public string query { get; set; }
        public SuggestQuery(string query) {
            this.query = query;
        }
    }
}