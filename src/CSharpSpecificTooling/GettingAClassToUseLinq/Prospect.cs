namespace GettingAClassToUseLinq;

public class Prospect
{
    public Prospect(string name, Guid prospectID)
    {
        Name = name;
        ProspectID = prospectID;
    }

    public string Name { get; set; }

    public Guid ProspectID { get; set; }
}
