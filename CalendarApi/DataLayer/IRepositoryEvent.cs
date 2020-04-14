using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DataLayer
{
    public interface IRepositoryEvent
    {
        bool SaveEvent(Event events);
        bool UpdateEvent(int id,Event events);

        bool DeleteEvent(int id);

        Event GetEvent(int id);
        List<Event> GetEvents();

        List<Event> GetDayEvents(Day day);
    }
}
