//----------------------------------------------------
// <copyright file="IInputReader.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Input reader interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The Input Reader interface.
    /// </summary>
    public interface IInputReader
    {
        /// <summary>
        /// The Read line.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>
        /// </returns>
        string ReadLine();
    }
}
