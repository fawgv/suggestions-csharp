using System;
using System.Net;
using DaData.Client.Model;
using RestSharp;

namespace DaData.Client
{
    public class SuggestClient
    {
        private const string SuggestionsUrl = "{0}/suggest";
        private const string AddressResource = "address";
        private const string PartyResource = "party";
        private const string BankResource = "bank";
        private const string FioResource = "fio";
        private const string EmailResource = "email";

        private readonly RestClient _client;
        private readonly ContentType _contentType = ContentType.XML;
        private readonly string _token;

        static SuggestClient()
        {
            // use SSL v3
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
        }

        public SuggestClient(string token, string baseUrl = "https://suggestions.dadata.ru/suggestions/api/4_1/rs/")
        {
            this._token = token;
            _client = new RestClient(string.Format(SuggestionsUrl, baseUrl));            
        }

        public IWebProxy Proxy
        {
            get { return _client.Proxy; }
            set { _client.Proxy = value; }
        }

        public SuggestAddressResponse QueryAddress(string address)
        {
            var request = new RestRequest(AddressResource, Method.POST);
            var query = new SuggestQuery(address);
            return Execute<SuggestAddressResponse>(request, query, _contentType);
        }

        public SuggestBankResponse QueryBank(string bank)
        {
            var request = new RestRequest(BankResource, Method.POST);
            var query = new SuggestQuery(bank);
            return Execute<SuggestBankResponse>(request, query, _contentType);
        }

        public SuggestEmailResponse QueryEmail(string email)
        {
            var request = new RestRequest(EmailResource, Method.POST);
            var query = new SuggestQuery(email);
            return Execute<SuggestEmailResponse>(request, query, _contentType);
        }

        public SuggestFioResponse QueryFio(string fio)
        {
            var request = new RestRequest(FioResource, Method.POST);
            var query = new SuggestQuery(fio);
            return Execute<SuggestFioResponse>(request, query, _contentType);
        }

        public SuggestPartyResponse QueryParty(string party)
        {
            var request = new RestRequest(PartyResource, Method.POST);
            var query = new SuggestQuery(party);
            return Execute<SuggestPartyResponse>(request, query, _contentType);
        }

        private T Execute<T>(RestRequest request, SuggestQuery query, ContentType contentType) where T : new()
        {
            request.AddHeader("Authorization", "Token " + _token);
            request.AddHeader("Content-Type", contentType.Name);
            request.AddHeader("Accept", contentType.Name);
            request.RequestFormat = contentType.Format;
            request.XmlSerializer.ContentType = contentType.Name;
            request.AddBody(query);
            
            var response = _client.Execute<T>(request);
            
            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }
    }
}