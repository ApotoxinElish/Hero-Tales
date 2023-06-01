using Mirror;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HeroTales
{
    /// <summary>
    /// This type represents a game player and, as a multiplayer-aware entity, it is derived from
    /// NetworkBehaviour.
    /// </summary>
    public class Player : NetworkBehaviour
    {
        /// <summary>
        /// True if this player is the current active player in the game; false otherwise. 'Active' meaning
        /// the current game turn is his turn.
        /// </summary>
        public bool isActivePlayer;

        /// <summary>
        /// True if this player is controlled by a human; false otherwise (AI).
        /// </summary>
        public bool isHuman;

        protected virtual void Awake()
        {
        }

        protected virtual void Start()
        {
        }
    }
}