using FluentBuilderSample.Builders.Advance.Interfaces;
using FluentBuilderSample.Models;

namespace FluentBuilderSample.Builders.Advance
{
    public class AdvanceOrderBuilder : IOrderNumberBuilder, IOrderCreatedOnBuilder, IOrderShippingAddressBuilder, IOrderBuilder
    {
        private int _number;
        private DateOnly _createdOn;
        private Address _address;
        private readonly IAddressCountryBuilder _addressBuilder = AdvanceAddressBuilder.Empty();

        private AdvanceOrderBuilder()
        {
        }

        public static IOrderNumberBuilder Empty() => new AdvanceOrderBuilder();

        public IOrderCreatedOnBuilder WithNumber(int number)
        {
            _number = number;
            return this;
        }

        public IOrderShippingAddressBuilder WithCreatedOn(DateOnly createdOn)
        {
            _createdOn = createdOn;
            return this;
        }

        public IOrderBuilder WithShippingAddress(Address address)
        {
            _address = address;
            return this;
        }

        public IOrderBuilder WithShippingAddress(Action<IAddressCountryBuilder> builder)
        {
            builder(_addressBuilder);
            return this;
        }

        public Order Build()
        {
            return new Order
            {
                Number = _number,
                CreatedOn = _createdOn,
                ShippingAddress = _address ?? (_addressBuilder as IAddressBuilder)?.Build()
            };
        }

    }
}
