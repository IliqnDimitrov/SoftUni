﻿// <copyright file="StringExtensions.cs" company="ilqka">
// ilqka.com.All rights reserved.
// </copyright>
// <summary>
// The string extensions.
// </summary>
// -------------------------------------------------------------------- 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// The class provides string extension methods.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Converts string to hash array.
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>
    /// Hash string
    /// </returns>
    public static string ToMd5Hash(this string input)
    {
        var md5Hash = MD5.Create();

        // Convert the input to byte array
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        // Create a new StringBuilder to collect the bytes
        // and create a string.
        var builder = new StringBuilder();

        // Loop through each byte of the hashed data 
        // and format each one as a hexadecimal string.
        for (int i = 0; i < data.Length; i++)
        {
            builder.Append(data[i].ToString("x2"));
        }

        return builder.ToString();
    }

    /// <summary>
    /// Checks if the string value is a boolean
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>Returns true if string value is boolean true and false if string value is false or not boolean value</returns>
    public static bool ToBoolean(this string input)
    {
        var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
        return stringTrueValues.Contains(input.ToLower());
    }

    /// <summary>
    /// Try Parse string to short
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>variable of type short if string can be parse</returns>
    public static short ToShort(this string input)
    {
        short shortValue;
        short.TryParse(input, out shortValue);
        return shortValue;
    }

    /// <summary>
    /// Try parse string to integer
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>Returns variable of type integer if string can be parse</returns>
    public static int ToInteger(this string input)
    {
        int integerValue;
        int.TryParse(input, out integerValue);
        return integerValue;
    }

    /// <summary>
    /// Try parse string to long
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>Returns variable of type long if string can be parse</returns>
    public static long ToLong(this string input)
    {
        long longValue;
        long.TryParse(input, out longValue);
        return longValue;
    }

    /// <summary>
    /// The method try parse string to Date time
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>Returns variable of type date time if string can be parse</returns>
    public static DateTime ToDateTime(this string input)
    {
        DateTime dateTimeValue;
        DateTime.TryParse(input, out dateTimeValue);
        return dateTimeValue;
    }

    /// <summary>
    /// Method capitalizes the first letter of the string
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <returns>Returns string with capitalize first letter</returns>
    public static string CapitalizeFirstLetter(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        return
            input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
            input.Substring(1, input.Length - 1);
    }

    /// <summary>
    /// Method returns a substring between two strings
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="startString">The starting point of substring</param>
    /// <param name="endString">The ending point of substring</param>
    /// <param name="startFrom">Start from</param>
    /// <returns>Returns substring between two strings</returns>
    public static string GetStringBetween(
        this string input, string startString, string endString, int startFrom = 0)
    {
        input = input.Substring(startFrom);
        startFrom = 0;
        if (!input.Contains(startString) || !input.Contains(endString))
        {
            return string.Empty;
        }

        var startPosition =
            input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
        if (startPosition == -1)
        {
            return string.Empty;
        }

        var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
        if (endPosition == -1)
        {
            return string.Empty;
        }

        return input.Substring(startPosition, endPosition - startPosition);
    }

    /// <summary>
    /// The method convert cyrillic text to latin text
    /// </summary>
    /// <param name="input">The Text</param>
    /// <returns>Returns convert cyrillic text to latin text</returns>
    public static string ConvertCyrillicToLatinLetters(this string input)
    {
        var bulgarianLetters = new[]
        {
            "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
            "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
        };
        var latinRepresentationsOfBulgarianLetters = new[]
        {
            "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
            "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
            "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
        };
        for (var i = 0; i < bulgarianLetters.Length; i++)
        {
            input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
            input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
        }

        return input;
    }

    /// <summary>
    /// The method convert latin text to cyrillic text.
    /// </summary>
    /// <param name="input">The Text</param>
    /// <returns>Returns convert latin text to cyrillic text</returns>
    public static string ConvertLatinToCyrillicKeyboard(this string input)
    {
        var latinLetters = new[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        var bulgarianRepresentationOfLatinKeyboard = new[]
        {
            "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
            "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
            "в", "ь", "ъ", "з"
        };

        for (int i = 0; i < latinLetters.Length; i++)
        {
            input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
            input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
        }

        return input;
    }

    /// <summary>
    /// The method replaces invalid symbols with empty string
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>Returns a valid user name in string format</returns>
    public static string ToValidUsername(this string input)
    {
        input = input.ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
    }
    
    /// <summary>
    /// The method replaces empty space with '-' and replace invalid symbols  with empty string
    /// </summary>
    /// <param name="input">The input</param>
    /// <returns>Returns a valid fail name in string format</returns>
    public static string ToValidLatinFileName(this string input)
    {
        input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
    }
    
    /// <summary>
    /// The method get the first characters of the string
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="charsCount">Number of characters to be get</param>
    /// <returns>returns the first characters</returns>
    public static string GetFirstCharacters(this string input, int charsCount)
    {
        return input.Substring(0, Math.Min(input.Length, charsCount));
    }

    /// <summary>
    /// The method gets the extension of a string with filename
    /// </summary>
    /// <param name="fileName">The FileName</param>
    /// <returns>
    /// Returns the file extension or empty string if the fileName string IsNullOrWhiteSpace or has no extension
    /// </returns>
    public static string GetFileExtension(this string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return string.Empty;
        }

        string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
        if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
        {
            return string.Empty;
        }

        return fileParts.Last().Trim().ToLower();
    }

    /// <summary>
    /// Method gets the content type of a file extension
    /// </summary>
    /// <param name="fileExtension">The File Extension</param>
    /// <returns>
    /// Returns the content type if known it or "application/octet-stream" if don't know it
    /// </returns>
    public static string ToContentType(this string fileExtension)
    {
        var fileExtensionToContentType = new Dictionary<string, string>
        {
            { "jpg", "image/jpeg" },
            { "jpeg", "image/jpeg" },
            { "png", "image/x-png" },
            { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
            { "doc", "application/msword" },
            { "pdf", "application/pdf" },
            { "txt", "text/plain" },
            { "rtf", "application/rtf" }
        };
        if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
        {
            return fileExtensionToContentType[fileExtension.Trim()];
        }

        return "application/octet-stream";
    }

    /// <summary>
    /// Method converts a sting to byte array
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>Returns a byte array of the sting</returns>
    public static byte[] ToByteArray(this string input)
    {
        var bytesArray = new byte[input.Length * sizeof(char)];
        Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
        return bytesArray;
    }
}
