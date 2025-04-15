//Your code here (above the PersonName class)

using System.Collections;

public class PersonName : IEnumerable<string>
{
    public string FirstName { get; }
    public string[] MiddleNames { get; }
    public string LastName { get; }

    public PersonName(string firstName, string lastName, params string[] middleNames)
    {
        FirstName = firstName;
        MiddleNames = middleNames;
        LastName = lastName;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<string> GetEnumerator()
    {
        yield return FirstName;
        foreach (string middleName in MiddleNames)
            yield return middleName;
        yield return LastName;
    }

}