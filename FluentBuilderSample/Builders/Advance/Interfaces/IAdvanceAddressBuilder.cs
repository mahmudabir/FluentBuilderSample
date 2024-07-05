using FluentBuilderSample.Models;

namespace FluentBuilderSample.Builders.Advance.Interfaces
{
    public interface IAddressCountryBuilder
    {
        IAddressStateBuilder WithCountry(string country);
    }

    public interface IAddressStateBuilder
    {
        IAddressCityBuilder WithState(string state = null);
    }

    public interface IAddressCityBuilder
    {
        IAddressZipBuilder WithCity(string city);
    }

    public interface IAddressZipBuilder
    {
        IAddressStreetBuilder WithZip(string zip);
    }

    public interface IAddressStreetBuilder
    {
        IAddressBuilder WithStreet(string street);
    }

    public interface IAddressBuilder : IFluentBuilder<Address>
    {
        Address Build();
    }
}
