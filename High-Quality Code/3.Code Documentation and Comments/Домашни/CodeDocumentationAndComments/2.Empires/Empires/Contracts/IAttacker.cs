//----------------------------------------------------
// <copyright file="IAttacker.cs" company="ilqka">
//  ilqka. All rights reserved.
// </copyright>
// <summary>
// The Attacker interface.
// </summary>
// ---------------------------------------------------- 

namespace Empires.Contracts
{
    /// <summary>
    /// The Attacker interface.
    /// </summary>
    public interface IAttacker
    {
        /// <summary>
        /// Gets Attack Damage.
        /// </summary>
        int AttackDamage { get; }
    }
}
