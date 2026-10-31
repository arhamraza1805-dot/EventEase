using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<EventModel> _events = new()
    {
        new EventModel { Id = 1, Name = "Tech Summit 2025", Date = DateTime.Now.AddDays(30), Location = "San Francisco", Description = "Annual technology conference", Capacity = 500, RegisteredCount = 120 },
        new EventModel { Id = 2, Name = "Design Workshop", Date = DateTime.Now.AddDays(14), Location = "New York", Description = "Hands-on UX design workshop", Capacity = 50, RegisteredCount = 45 },
        new EventModel { Id = 3, Name = "AI Conference", Date = DateTime.Now.AddDays(60), Location = "Austin", Description = "Deep dive into modern AI", Capacity = 300, RegisteredCount = 80 }
    };

    public List<EventModel> GetEvents() => _events;

    public EventModel? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

    public void Register(int eventId)
    {
        var ev = GetEventById(eventId);
        if (ev != null && ev.RegisteredCount < ev.Capacity)
        {
            ev.RegisteredCount++;
        }
    }
}