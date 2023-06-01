using UnityEngine;

using DG.Tweening;

namespace HeroTales
{
    public class Popup : MonoBehaviour
    {
        [HideInInspector] public BaseScreen parentScene;

        public void Close()
        {
            OnPopupClosedActions();

            if (parentScene != null)
            {
                parentScene.OnPopupClosed(this);
            }

            Destroy(gameObject);
        }

        public virtual void OnPopupClosedActions()
        {
            DOTween.KillAll();
        }
    }
}
