namespace CohesionAndCoupling.Utils
{
    using System;

    /// <summary>
    /// Class that holds file operation
    /// </summary>
    static class FlieUtils
    {
        /// <summary>
        /// The method return file extension,
        /// if there is no file extension
        /// returns empty string
        /// </summary>
        /// <param name="fileName">string represents file name</param>
        /// <returns>file extension only</returns>
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("File is null.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// The method returns file name
        /// </summary>
        /// <param name="fileName">string represents file name</param>
        /// <returns>File name without extension</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("File is null.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}