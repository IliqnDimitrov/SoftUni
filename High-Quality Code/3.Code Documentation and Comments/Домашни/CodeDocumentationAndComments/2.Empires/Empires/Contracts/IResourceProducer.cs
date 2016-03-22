//----------------------------------------------------
// <copyright file="IResourceProducer.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Resource producer interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    using Models.EventHandlers;

    /// <summary>
    /// Resource Producer interface.
    /// </summary>
    public interface IResourceProducer
    {
        /// <summary>
        /// The On Resource produced.
        /// </summary>
        event ResourceProducedEventHandler OnResourceProduced;
    }
}
