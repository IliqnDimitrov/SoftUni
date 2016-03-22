//----------------------------------------------------
// <copyright file="IUnitProducer.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Unit producer interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    using Models.EventHandlers;

    /// <summary>
    /// The Unit producer interface.
    /// </summary>
    public interface IUnitProducer
    {
        /// <summary>
        /// The On Unit Produced.
        /// </summary>
        event UnitProducedEventHandler OnUnitProduced;
    }
}
