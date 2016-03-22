//----------------------------------------------------
// <copyright file="IResource.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Resource interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    using Enums;

    /// <summary>
    /// Resource interface.
    /// </summary>
    public interface IResource
    {
        /// <summary>
        /// Gets resource type.
        /// </summary>
        ResourceType ResourceType { get; }
        
        /// <summary>
        /// Gets quantity.
        /// </summary>
        int Quantity { get; }
    }
}
