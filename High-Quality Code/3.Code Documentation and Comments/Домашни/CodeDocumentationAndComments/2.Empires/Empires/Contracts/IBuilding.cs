//----------------------------------------------------
// <copyright file="IBuilding.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Building interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The Building interface.
    /// </summary>
    public interface IBuilding : IUnitProducer, IResourceProducer, IUpdateable
    {
    }
}
