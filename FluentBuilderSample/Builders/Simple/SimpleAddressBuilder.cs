using FluentBuilderSample.Models;

namespace FluentBuilderSample.Builders.Simple
{

    public class SimpleAddressBuilder
    {
        private string _street;
        private string _city;
        private string _zip;
        private string? _state;
        private string _country;

        public static SimpleAddressBuilder Empty() => new();

        private SimpleAddressBuilder()
        {
        }

        public SimpleAddressBuilder WithStreet(string street)
        {
            _street = street;
            return this;
        }

        public SimpleAddressBuilder WithCity(string city)
        {
            _city = city;
            return this;
        }

        public SimpleAddressBuilder WithZip(string zip)
        {
            _zip = zip;
            return this;
        }

        public SimpleAddressBuilder WithState(string state)
        {
            _state = state;
            return this;
        }

        public SimpleAddressBuilder WithCountry(string country)
        {
            _country = country;
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
