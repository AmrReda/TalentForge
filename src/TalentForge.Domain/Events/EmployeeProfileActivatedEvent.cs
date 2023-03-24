using TalentForge.Domain.Common;
using TalentForge.Domain.Entities;

namespace TalentForge.Domain.Events;

public class EmployeeProfileActivatedEvent : BaseEvent
{
    public EmployeeProfileActivatedEvent(Employee employee)
    {
        Employee = employee;
    }

    public Employee Employee { get; }
}
