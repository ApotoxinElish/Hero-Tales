using System.Collections.Generic;

namespace HeroTales
{
    /// <summary>
    /// This class provides general networking utilities.
    /// </summary>
    public static class NetworkingUtils
    {
        /// <summary>
        /// Returns the human local player for this client.
        /// </summary>
        /// <returns>The human local player for this client.</returns>
        public static Player GetHumanLocalPlayer()
        {
            Player localPlayer = null;
            /*foreach (var pc in NetworkManager.singleton.client.connection.playerControllers)
            {
                var player = pc.gameObject.GetComponent<Player>();
                if (player.isLocalPlayer && player.isHuman)
                {
                    localPlayer = player;
                    break;
                }
            }*/
            return localPlayer;
        }
    }
}
