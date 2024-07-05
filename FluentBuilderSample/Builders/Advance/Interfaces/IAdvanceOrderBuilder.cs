using FluentBuilderSample.Models;

namespace FluentBuilderSample.Builders.Advance.Interfaces
{
    public interface IOrderNumberBuilder
    {
        IOrderCreatedOnBuilder WithNumber(int number);
    }

    public interface IOrderCreatedOnBuilder
    {
        IOrderShippingAddressBuilder WithCreatedOn(DateOnly createdOn);
    }

    public interface IOrderShippingAddressBuilder
    {
        IOrderBuilder WithShippingAddress(Address address);
        IOrderBuilder WithShippingAddress(Action<IAddressCountryBuilder> builder);
    }

    public interface IOrderBuilder : IFluentBuilder<Order>
    {
        Order Build();
    }
}
