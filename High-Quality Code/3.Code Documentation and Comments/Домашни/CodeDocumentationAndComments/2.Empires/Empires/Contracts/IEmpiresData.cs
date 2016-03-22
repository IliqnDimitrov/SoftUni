//----------------------------------------------------
// <copyright file="IEmpiresData.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Empires data interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    using System.Collections.Generic;

    using Enums;

    /// <summary>
    /// The Empires Data interface.
    /// </summary>
    public interface IEmpiresData
    {
        /// <summary>
        /// Gets The Resources.
        /// </summary>
        IDictionary<ResourceType, int> Resources { get; } 

        /// <summary>
        /// Gets The Units.
        /// </summary>
        IDictionary<string, int> Units { get; }

        /// <summary>
        /// Gets The Buildings.
        /// </summary>
        IEnumerable<IBuilding> Buildings { get; }

        /// <summary>
        /// The Add Building.
        /// </summary>
        /// <param name="building">
        /// The Building.
        /// </param>
        void AddBuilding(IBuilding building);

        /// <summary>
        /// The Add Unit.
        /// </summary>
        /// <param name="unit">
        /// the Unit.
        /// </param>
        void AddUnit(IUnit unit);
    }
}
