using System;
using Wintellect.PowerCollections;

public class EventHolder
{
    private MultiDictionary<string, Event> eventsByTitle = new MultiDictionary<string, Event>(true);
    private OrderedBag<Event> eventsByDate = new OrderedBag<Event>();

    public void AddEvent(DateTime date, string title, string location)
    {
        Event newEvent = new Event(date, title, location);
        this.eventsByTitle.Add(title.ToLower(), newEvent);
        this.eventsByDate.Add(newEvent);

        Messages.EventAdded();
    }

    public void DeleteEvents(string titleToDelete)
    {
        string title = titleToDelete.ToLower();
        int removedEventsCount = 0;

        foreach (var eventToRemove in this.eventsByTitle[title])
        {
            removedEventsCount++;
            this.eventsByDate.Remove(eventToRemove);
        }

        this.eventsByTitle.Remove(title);
        Messages.EventDeleted(removedEventsCount);
    }

    public void ListEvents(DateTime date, int count)
    {
        OrderedBag<Event>.View eventsToShow = this.eventsByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);

        int showedEvents = 0;
        foreach (var eventToShow in eventsToShow)
        {
            if (showedEvents == count)
            {
                break;
            }

            Messages.PrintEvent(eventToShow);
            showedEvents++;
        }

        if (showedEvents == 0)
        {
            Messages.NoEventsFound();
        }
    }
}