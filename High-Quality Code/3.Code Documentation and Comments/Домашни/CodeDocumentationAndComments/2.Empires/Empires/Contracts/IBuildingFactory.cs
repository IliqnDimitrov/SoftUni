//----------------------------------------------------
// <copyright file="IBuildingFactory.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Building interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The Building factory interface.
    /// </summary>
    public interface IBuildingFactory
    {
        /// <summary>
        /// The Create Building.
        /// </summary>
        /// <param name="buildingType">
        /// The Building Type.
        /// </param>
        /// <param name="unitFactory">
        /// The Unit Factory
        /// </param>
        /// <param name="resourceFactory">
        /// The Resource Factory
        /// </param>
        /// <returns>
        /// The <see cref="IBuilding"/>.
        /// </returns>
        IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory);
    }
}
