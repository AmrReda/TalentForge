using TalentForge.Domain.Common;
namespace TalentForge.Domain.ValueObjects;

public class Address : ValueObject
{
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string PostCode { get; set; }
    public string Country { get; set; }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
         yield return Address1;
         yield return Address2;
         yield return City;
         yield return PostCode;
         yield return Country;
    }
}
