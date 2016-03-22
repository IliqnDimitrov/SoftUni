// <copyright file="Program.cs" company="company">
// product
// Copyright (c) 2004-2010
// by company ( http://www.example.com )
// </copyright>

using System;
using System.Text;

/// <summary>
/// Just program.
/// </summary>
public class Program
{
    /// <summary>
    /// this field build output message
    /// </summary>
    private static StringBuilder output = new StringBuilder();

    /// <summary>
    /// this field holds events.
    /// </summary>
    private static System.EventHandler events = new System.EventHandler();

    /// <summary>
    /// This method execute next command
    /// </summary>
    /// <returns>return true or false</returns>
    public static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();
        if (command[0] == 'A')
        {
            AddEvent(command);
            return true;
        }

        if (command[0] == 'D')
        {
            DeleteEvents(command);
            return true;
        }

        if (command[0] == 'L')
        {
            ListEvents(command);
            return true;
        }

        if (command[0] == 'E')
        {
            return false;
        }

        return false;
    }

    /// <summary>
    /// This method sort events.
    /// </summary>
    /// <param name="command">command execute</param>
    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');

        DateTime date = GetDate(command, "ListEvents");

        string countString = command.Substring(pipeIndex + 1);

        int count = int.Parse(countString);

        events.ListEvents(date, count);
    }

    /// <summary>
    /// This method delete events.
    /// </summary>
    /// <param name="command">Parameter description for s goes here</param>
    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);
        events.DeleteEvents(title);
    }

    /// <summary>
    /// This method add events.
    /// </summary>
    /// <param name="command">this is command</param>
    private static void AddEvent(string command)
    {
        DateTime date;
        string title;
        string location;

        GetParameters(command, "AddEvent", out date, out title, out location);

        events.AddEvent(date, title, location);
    }

    /// <summary>
    /// this method get parameters.
    /// </summary>
    /// <param name="commandForExecution">this is Command for execution</param>
    /// <param name="commandType">this is Command for type</param>
    /// <param name="dateAndTime">this is Date and time</param>
    /// <param name="eventTitle">this is event title</param>
    /// <param name="eventLocation">this is event location</param>
    private static void GetParameters(
        string commandForExecution,
        string commandType,
        out DateTime dateAndTime,
        out string eventTitle,
        out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);

        int firstPipeIndex = commandForExecution.IndexOf('|');
        int lastPipeIndex = commandForExecution.LastIndexOf('|');

        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = string.Empty;
        }
        else
        {
            eventTitle = commandForExecution.Substring(
                                                      firstPipeIndex + 1,
                                                      lastPipeIndex - firstPipeIndex - 1)
                                                      .Trim();

            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }

    /// <summary>
    /// This method get date.
    /// </summary>
    /// <param name="command">This is command</param>
    /// <param name="commandType">This is type of command</param>
    /// <returns>dateTime of commandType</returns>
    private static DateTime GetDate(string command, string commandType)
    {
        DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

        return date;
    }
}