//----------------------------------------------------
// <copyright file="IOutputWriter.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Output Writer interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The output writer interface.
    /// </summary>
    public interface IOutputWriter
    {
        /// <summary>
        /// The Print.
        /// </summary>
        /// <param name="message">
        /// The Message.
        /// </param>
        void Print(string message);
    }
}
