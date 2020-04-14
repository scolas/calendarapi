using Calendar.Models;
using System.Collections.Generic;

namespace Calendar.BusinessLayer
{
    public interface IBussinessEvent
    {
        Event getEvent(int day, int month, int year);
        List<Event> events();

        bool SaveEvent(Event events);

        bool CreateEvent(Event e);

        bool UpdateEvent(int id,Event events);

        bool DeleteEvent(int id);

        List<Event> GetDayEvents(Day day);
    }
}