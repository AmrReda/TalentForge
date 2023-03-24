using TalentForge.Domain.Common;
using TalentForge.Domain.Enums;
using TalentForge.Domain.Events;
using TalentForge.Domain.ValueObjects;

namespace TalentForge.Domain.Entities;

public class Employee : BaseAuditableEntity
{
    public int Id { get; set; }

    public string? FirstName { get; set; }
    
    public string? MiddleName { get; set; }
    
    public string? LastName { get; set; }

    public DateTime DateOfBirth { get; set; }
    
    public string? Note { get; set; }

    public Gender Gender { get; set; }
    
    public Address Address { get; set; }

    private bool _active;
    public bool Active
    {
        get => _active;
        set
        {
            if (value == true && _active == false)
            {
                AddDomainEvent(new EmployeeProfileActivatedEvent(this));
            }

            _active = value;
        }
    }
}
