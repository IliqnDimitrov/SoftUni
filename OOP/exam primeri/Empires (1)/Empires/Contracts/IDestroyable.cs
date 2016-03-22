//----------------------------------------------------
// <copyright file="IDestroyable.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Destroyable interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The Destroyable interface.
    /// </summary>
    public interface IDestroyable
    {
        // Added public setter

        /// <summary>
        /// Gets or sets the Health
        /// </summary>
        int Health { get; set; }
    }
}
