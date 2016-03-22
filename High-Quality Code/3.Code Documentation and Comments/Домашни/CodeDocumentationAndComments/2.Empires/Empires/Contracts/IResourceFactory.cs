//----------------------------------------------------
// <copyright file="IResourceFactory.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Resource factory interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    using Enums;

    /// <summary>
    /// Resource Factory interface.
    /// </summary>
    public interface IResourceFactory
    {
        /// <summary>
        /// The create resource
        /// </summary>
        /// <param name="resourceType">
        /// The resource type.
        /// </param>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// The <see cref="IResource"/>.
        /// </returns>
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
