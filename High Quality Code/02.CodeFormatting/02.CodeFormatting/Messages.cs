using System.Text;

public static class Messages
{ 
    public static void EventAdded()
    {
        EventManager.Output.Append("Event added\n");
    }

    public static void EventDeleted(int deletedEventsCount)
    {
        if (deletedEventsCount == 0)
        {
            NoEventsFound();
        }
        else
        {
            EventManager.Output.AppendFormat("{0} events deleted\n", deletedEventsCount);
        }
    }

    public static void NoEventsFound()
    {
        EventManager.Output.Append("No events found\n");
    }

    public static void PrintEvent(Event eventToPrint)
    {
        if (eventToPrint != null)
        {
            EventManager.Output.Append(eventToPrint + "\n");
        }
    }
}