using TalentForge.Domain.Common;
using TalentForge.Domain.Entities;

namespace TalentForge.Domain.Events;

public class EmployeeCreatedEvent : BaseEvent
{
    public EmployeeCreatedEvent(Employee employee)
    {
        Employee = employee;
    }

    public Employee Employee { get; }
}
