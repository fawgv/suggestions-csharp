using RestSharp;

namespace DaData.Client.Model
{
    public sealed class ContentType {
        readonly string name;
        readonly DataFormat format;

        public string Name {
            get { return this.name; }
        }

        public DataFormat Format {
            get { return this.format; }
        }

        public static readonly ContentType JSON = new ContentType("application/json", DataFormat.Json);
        public static readonly ContentType XML = new ContentType("application/xml", DataFormat.Xml);

        private ContentType(string name, DataFormat format) {
            this.name = name;
            this.format = format;
        }

        public override string ToString () {
            return name;
        }
    }
}