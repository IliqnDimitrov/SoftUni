// <copyright file="Messages.cs" company="company">
// product
// Copyright (c) 2004-2010
// by company ( http://www.example.com )
// </copyright>

/// <summary>
/// This class provide messages.
/// </summary>
public static class Messages
{
    /// <summary>
    /// This method Add events.
    /// </summary>
    public static void EventAdded()
    {
        output.Append("Event added\n");
    }

    /// <summary>
    /// This method Delete events.
    /// </summary>
    /// <param name="x">event delete</param>
    public static void EventDeleted(int x)
    {
        if (x == 0)
        {
            NoEventsFound();
        }
        else
        {
            output.AppendFormat("{0} events deleted\n", x);
        }
    }

    /// <summary>
    /// This method execute command no events found.
    /// </summary>
    public static void NoEventsFound()
    {
        output.Append("No events found\n");
    }

    /// <summary>
    /// This method print events.
    /// </summary>
    /// <param name="eventToPrint">print events</param>
    public static void PrintEvent(Event eventToPrint)
    {
        if (eventToPrint != null)
        {
            output.Append(eventToPrint + "\n");
        }
    }
}