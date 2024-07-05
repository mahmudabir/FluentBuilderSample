using FluentBuilderSample.Builders.Advance;
using FluentBuilderSample.Builders.Simple;

using System.Text.Json;

Console.WriteLine("Fluent Builder Pattern\n");

DateOnly createdOn = DateOnly.FromDateTime(DateTime.Now);

#region Simple Builder

var address1 = SimpleAddressBuilder.Empty()
        .WithStreet("123 Main St")
        .WithCity("Seattle")
        .WithZip("98101")
        .WithState("WA")
        .WithCountry("USA")
        .Build();


var order1 = SimpleOrderBuilder.Empty()
    .WithNumber(1)
    .WithCreatedOn(createdOn)
    .WithShippingAddress(address1)
    .Build();

Console.WriteLine(JsonSerializer.Serialize(order1));
Console.WriteLine();

//Nested Builder
var order2 = SimpleOrderBuilder.Empty()
    .WithNumber(2)
    .WithCreatedOn(createdOn)
    .WithShippingAddress(builder => builder
        .WithStreet("123 Main St")
        .WithCity("Seattle")
        .WithZip("98101")
        .WithState("WA")
        .WithCountry("USA"))
    .Build();

Console.WriteLine(JsonSerializer.Serialize(order2));
Console.WriteLine();

#endregion Simple Builder

#region Advance Builder

var address3 = AdvanceAddressBuilder.Empty()
    .WithCountry("USA")
    .WithState()
    .WithCity("Seattle")
    .WithZip("98101")
    .WithStreet("123 Main St")
    .Build();

var order3 = AdvanceOrderBuilder.Empty()
    .WithNumber(3)
    .WithCreatedOn(createdOn)
    .WithShippingAddress(address3)
    .Build();

Console.WriteLine(JsonSerializer.Serialize(order3));
Console.WriteLine();

//Nested Builder
var order4 = AdvanceOrderBuilder.Empty()
    .WithNumber(4)
    .WithCreatedOn(createdOn)
    .WithShippingAddress(builder => builder
        .WithCountry("USA")
        .WithState()
        .WithCity("Seattle")
        .WithZip("98101")
        .WithStreet("123 Main St"))
    .Build();

Console.WriteLine(JsonSerializer.Serialize(order4));
Console.WriteLine();

#endregion Advance Builder