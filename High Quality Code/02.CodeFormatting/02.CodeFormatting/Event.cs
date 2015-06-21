using System;
using System.Text;

public class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;

    public Event(DateTime date, string title, string location)
    {
        this.date = date;
        this.title = title;
        this.location = location;
    }

    public int CompareTo(object otherEvent)
    {
        Event other = otherEvent as Event;
        int compareByDate = this.date.CompareTo(other.date);
        int compareByTitle = this.title.CompareTo(other.title);

        int compareByLocation = this.location.CompareTo(other.location);
        if (compareByDate == 0)
        {
            if (compareByTitle == 0)
            {
                return compareByLocation;
            }
            else
            {
                return compareByTitle;
            }
        }
        else
        {
            return compareByDate;
        }
    }

    public override string ToString()
    {
        StringBuilder eventToString = new StringBuilder();
        eventToString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
        eventToString.Append(" | " + this.title);

        if (this.location != null && this.location != string.Empty)
        {
            eventToString.Append(" | " + this.location);
        }

        return eventToString.ToString();
    }
}
