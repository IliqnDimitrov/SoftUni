//----------------------------------------------------
// <copyright file="IUnitFactory.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Unit factory interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The Unit factory interface.
    /// </summary>
    public interface IUnitFactory
    {
        /// <summary>
        /// The create unit.
        /// </summary>
        /// <param name="unitType">
        /// The unit type.
        /// </param>
        /// <returns>
        /// The <see cref="IUnit"/>.
        /// </returns>
        IUnit CreateUnit(string unitType);
    }
}
