namespace MainNameSpace;
public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    public PersonModel(string? fname, string? lname, string address, string city)
    {
        FirstName = fname ?? "";
        LastName = lname ?? "";
        Address = address;
        City = city;
    }
}
