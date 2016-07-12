using System.Collections.Generic;

namespace DaData.Client.Model
{    
    public class AddressData : Suggestion
    {
        public string postal_code { get; set; }
        public string country { get; set; }
        public string region_with_type { get; set; }
        public string region_type { get; set; }
        public string region_type_full { get; set; }
        public string region { get; set; }
        public string area_with_type { get; set; }
        public string area_type { get; set; }
        public string area_type_full { get; set; }
        public string area { get; set; }
        public string city_with_type { get; set; }
        public string city_type { get; set; }
        public string city_type_full { get; set; }
        public string city { get; set; }
        public string settlement_with_type { get; set; }
        public string settlement_type { get; set; }
        public string settlement_type_full { get; set; }
        public string settlement { get; set; }
        public string city_district { get; set; }
        public string street_with_type { get; set; }
        public string street_type { get; set; }
        public string street_type_full { get; set; }
        public string street { get; set; }
        public string house_type { get; set; }
        public string house_type_full { get; set; }
        public string house { get; set; }
        public string block_type { get; set; }
        public string block_type_full { get; set; }
        public string block { get; set; }
        public string flat_type { get; set; }
        public string flat_type_full { get; set; }
        public string flat { get; set; }
        public string postal_box { get; set; }
        public string fias_id { get; set; }
        public string fias_level { get; set; }
        public string kladr_id { get; set; }
        public string capital_marker { get; set; }
        public string okato { get; set; }
        public string oktmo { get; set; }
        public string tax_office { get; set; }
        public string geo_lat { get; set; }
        public string geo_lon { get; set; }
        public string qc_geo { get; set; }
    }
}