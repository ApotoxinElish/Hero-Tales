using Mirror;
using UnityEngine;

namespace HeroTales
{
    /// <summary>
    /// Create a NetworkManager subclass with an automatically-managed lifetime. Having a subclass will also
    /// come in handy if we need to extend the capabilities of the vanilla NetworkManager in the future.
    /// </summary>
    public class GameNetworkManager : NetworkManager
    {
        public bool IsSinglePlayer;

        private static GameNetworkManager instance;

        public static GameNetworkManager Instance
        {
            get { return instance ?? new GameObject("GameNetworkManager").AddComponent<GameNetworkManager>(); }
        }

        public void Initialize()
        {
            if (instance != null)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;

            // UNET currently crashes on iOS if the runInBackground property is set to true.
            if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.tvOS)
            {
                runInBackground = false;
            }
        }

        private void OnEnable()
        {
            if (instance == null)
            {
                instance = this;
            }
        }
    }
}
