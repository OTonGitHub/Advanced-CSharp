namespace CLibrary;
public class AnotherPersonModel 
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    public AnotherPersonModel(string? fname, string? lname, string address, string city)
    {
        Name = fname + " " + lname ?? "-";
        Address = address;
        City = city;
    }
}
