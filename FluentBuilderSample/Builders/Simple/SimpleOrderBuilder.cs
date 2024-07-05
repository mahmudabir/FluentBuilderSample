using FluentBuilderSample.Models;

namespace FluentBuilderSample.Builders.Simple
{
    public class SimpleOrderBuilder
    {
        private int _number;
        private DateOnly _createdOn;
        private Address _address;
        private readonly SimpleAddressBuilder _addressBuilder = SimpleAddressBuilder.Empty();


        public static SimpleOrderBuilder Empty() => new();

        private SimpleOrderBuilder()
        {
        }

        public SimpleOrderBuilder WithNumber(int number)
        {
            _number = number;
            return this;
        }

        public SimpleOrderBuilder WithCreatedOn(DateOnly createdOn)
        {
            _createdOn = createdOn;
            return this;
        }

        public SimpleOrderBuilder WithShippingAddress(Address address)
        {
            _address = address;
            return this;
        }

        public SimpleOrderBuilder WithShippingAddress(Action<SimpleAddressBuilder> builder)
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
                ShippingAddress = _address ?? _addressBuilder.Build()
            };
        }

    }
}
