


You can also use the required modifier on a property and allow callers to use an object initializer to set the initial value of the property:

C#
public class Person
{
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
}
The addition of the required keyword mandates that callers must set those properties as part of a new expression:

C#
var p1 = new Person(); // Error! Required properties not set
var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };
