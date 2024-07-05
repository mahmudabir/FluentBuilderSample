using FluentBuilderSample.Builders.Advance.Interfaces;
using FluentBuilderSample.Models;

namespace FluentBuilderSample.Builders.Advance
{
    public class AdvanceAddressBuilder : IAddressCountryBuilder, IAddressStateBuilder, IAddressCityBuilder, IAddressZipBuilder, IAddressStreetBuilder, IAddressBuilder
    {
        private string _street;
        private string _city;
        private string _zip;
        private string? _state;
        private string _country;

        private AdvanceAddressBuilder()
        {
        }

        public static IAddressCountryBuilder Empty() => new AdvanceAddressBuilder();

        public IAddressStateBuilder WithCountry(string country)
        {
            _country = country;
            return this;
        }

        public IAddressCityBuilder WithState(string state = null)
        {
            _state = state;
            return this;
        }

        public IAddressZipBuilder WithCity(string city)
        {
            _city = city;
            return this;
        }


        public IAddressStreetBuilder WithZip(string zip)
        {
            _zip = zip;
            return this;
        }


        public IAddressBuilder WithStreet(string street)
        {
            _street = street;
            return this;
        }

        public Address Build()
        {
            return new Address
            {
                Street = _street,
                City = _city,
                Zip = _zip,
                State = _state ?? "N/A",
                Country = _country
            };
        }

    }
}
