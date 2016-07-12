using System;
using System.Linq;
using NUnit.Framework;

namespace DaData.Client.Tests {

    [TestFixture]
    public class SuggestionsClientTest {

        public SuggestClient Api { get; set; }

        [SetUp]
        public void SetUp() {
            var token = "a1b4e47afc9b5f4fcbaf330b243c3ffed6551bac";            
            this.Api = new SuggestClient(token);
        }

        [Test]
        public void SuggestAddressTest() {
            var query = "москва турчанинов 6";
            var response = Api.QueryAddress(query);
            Assert.AreEqual("119034", response.suggestionss[0].data.postal_code);
            Console.WriteLine(string.Join("\n", response.suggestionss));
        }

        [Test]
        public void SuggestBankTest() {
            var query = "сбербанк";
            var response = Api.QueryBank(query);
            Assert.AreEqual("044525225", response.suggestionss[0].data.bic);
            Console.WriteLine(string.Join("\n", response.suggestionss));
        }

        [Test]
        public void SuggestEmailTest() {
            var query = "anton@m";
            var response = Api.QueryEmail(query);
            Assert.AreEqual("anton@mail.ru", response.suggestionss[0].value);
            Console.WriteLine(string.Join("\n", response.suggestionss));
        }

        [Test]
        public void SuggestFioTest() {
            var query = "викт";
            var response = Api.QueryFio(query);
            Assert.AreEqual("Виктор", response.suggestionss[0].data.name);
            Console.WriteLine(string.Join("\n", response.suggestionss));
        }

        [Test]
        public void SuggestPartyTest() {
            var query = "сбербанк";
            var response = Api.QueryParty(query);
            Assert.IsNotEmpty(response.suggestionss);
            var first = response.suggestionss.First();
            Assert.IsNotNull(first.data.address);
            Assert.IsNotNull(first.data.address.value);
            Assert.AreEqual("7707083893", first.data.inn);
            Console.WriteLine(string.Join("\n", response.suggestionss));
        }

    }
}

