using TalentForge.Domain.Common;
using TalentForge.Domain.Entities;

namespace TalentForge.Domain.Events;

public class EmployeemDeletedEvent : BaseEvent
{
    public EmployeemDeletedEvent(Employee employee)
    {
        Employee = employee;
    }

    public Employee Employee { get; }
}
