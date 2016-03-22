// <copyright file="EventHandler.cs" company="company">
// product
// Copyright (c) 2004-2010
// by company ( http://www.example.com )
// </copyright>

using System;

/// <summary>
/// This class hold events.
/// </summary>
public class EventHandler
{
    /// <summary>
    /// this field sort by title events.
    /// </summary>
    private MultiDictionary<string, Event> sortByTitle = new MultiDictionary<string, Event>(true);

    /// <summary>
    /// this field sort by dade events.
    /// </summary>
    private OrderedBag<Event> sortByDate = new OrderedBag<Event>();

    /// <summary>
    /// This method add events.
    /// </summary>
    /// <param name="date">the data</param>
    /// <param name="title">the title</param>
    /// <param name="location">the location</param>
    public void AddEvent(DateTime date, string title, string location)
    {
        Event newEvent = new Event(date, title, location);

        this.sortByTitle.Add(title.ToLower(), newEvent);
        this.sortByDate.Add(newEvent);
        Event.Program.Messages.EventAdded();
    }

    /// <summary>
    /// This method check and remove events.
    /// </summary>
    /// <param name="titleToDelete">title to delete.</param>
    public void DeleteEvents(string titleToDelete)
    {
        string title = titleToDelete.ToLower();

        int removed = 0;

        foreach (var eventToRemove in this.sortByTitle[title])
        {
            removed++;
            this.sortByDate.Remove(eventToRemove);
        }

        this.sortByTitle.Remove(title);

        Event.Program.Messages.EventDeleted(removed);
    }

    /// <summary>
    /// This is list with events.
    /// </summary>
    /// <param name="date">Date of events</param>
    /// <param name="count">Count of events</param>
    public void ListEvents(DateTime date, int count)
    {
        OrderedBag<Event.Event>.View eventsToShow = this.sortByDate.RangeFrom(new Event.Event(date, string.Empty, string.Empty), true);

        int showed = 0;

        foreach (var eventToShow in eventsToShow)
        {
            if (showed == count)
            {
                break;
            }

            Event.Program.Messages.PrintEvent(eventToShow);

            showed++;
        }

        if (showed == 0)
        {
            Event.Program.Messages.NoEventsFound();
        }
    }
}