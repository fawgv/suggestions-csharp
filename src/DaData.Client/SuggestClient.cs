using System;
using System.Net;
using RestSharp;

namespace DaData.Client {

    public class SuggestClient {
        private const string SuggestionsUrl = "{0}/suggest";
        private const string AddressResource = "address";
        private const string PartyResource = "party";
        private const string BankResource = "bank";
        private const string FioResource = "fio";
        private const string EmailResource = "email";

        private readonly RestClient _client;
        private readonly string _token;
        private readonly ContentType _contentType = ContentType.JSON;

        public SuggestClient(string token, string baseUrl) {
            _token = token;
            _client = new RestClient (string.Format (SuggestionsUrl, baseUrl));
        }

        public SuggestAddressResponse QueryAddress(string address) {
            return QueryAddress(new AddressSuggestQuery(address));
        }

        public SuggestAddressResponse QueryAddress(AddressSuggestQuery query) {
            var request = new RestRequest(AddressResource, Method.POST);
            return Execute<SuggestAddressResponse>(request, query);
        }

        public SuggestBankResponse QueryBank(string bank) {
            return QueryBank(new BankSuggestQuery(bank));
        }

        public SuggestBankResponse QueryBank(BankSuggestQuery query) {
            var request = new RestRequest(BankResource, Method.POST);
            return Execute<SuggestBankResponse>(request, query);
        }

        public SuggestEmailResponse QueryEmail(string email) {
            var request = new RestRequest(EmailResource, Method.POST);
            var query = new SuggestQuery(email);
            return Execute<SuggestEmailResponse>(request, query);
        }

        public SuggestFioResponse QueryFio(string fio) {
            return QueryFio(new FioSuggestQuery(fio));
        }

        public SuggestFioResponse QueryFio(FioSuggestQuery query) {
            var request = new RestRequest(FioResource, Method.POST);
            return Execute<SuggestFioResponse>(request, query);
        }

        public SuggestPartyResponse QueryParty(string party) {
            return QueryParty(new PartySuggestQuery(party));
        }

        public SuggestPartyResponse QueryParty(PartySuggestQuery query) {
            var request = new RestRequest(PartyResource, Method.POST);
            return Execute<SuggestPartyResponse>(request, query);
        }

        private T Execute<T>(RestRequest request, SuggestQuery query) where T : new() {
            request.AddHeader("Authorization", "Token " + _token);
            request.AddHeader("Content-Type", _contentType.Name);
            request.AddHeader("Accept", _contentType.Name);
            request.RequestFormat = _contentType.Format;
            request.AddJsonBody(query);
            var response = _client.Execute<T>(request);
            
            if (response.StatusCode != HttpStatusCode.OK)
                throw new ApplicationException("Unable to process request: " + response.StatusCode);

            if (response.ErrorException != null) {
                throw response.ErrorException;
            }
            return response.Data;
        }
    }
}