using System;

namespace ConsoleApp20
{
    public record Book(string Title, double Price);

    public record Address(string City, string Country);

    public record Employee(string Name, Address Address);
}