// <copyright file="Event.cs" company="company">
// product
// Copyright (c) 2004-2010
// by company ( http://www.example.com )
// </copyright>

using System;
using System.Text;

/// <summary>
/// This clas create events.
/// </summary>
public class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;

    /// <summary>
    /// This is constructor of event.
    /// </summary>
    /// <param name="date">Date of event</param>
    /// <param name="title">Title of event</param>
    /// <param name="location">Location of event</param>
    public Event(DateTime date, string title, string location)
    {
        this.date = date;
        this.title = title;
        this.location = location;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public int CompareTo(object obj)
    {
        Event other = obj as Event;

        int sortByDate = this.date.CompareTo(other.date);

        int sortByTitle = this.title.CompareTo(other.title);

        int sortByLocation;
        sortByLocation = this.location.CompareTo(other.location);

        if (sortByDate == 0)
        {
            if (sortByTitle == 0)
            {
                return sortByLocation;
            }
            else
            {
                return sortByTitle;
            }
        }
        else
        {
            return sortByDate;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
        toString.Append(" | " + this.title);

        if (this.location != null && this.location != string.Empty)
        {
            toString.Append(" | " + this.location);
        }

        return toString.ToString();
    }
}