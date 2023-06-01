using System;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using DG.Tweening;

namespace HeroTales
{
    public class BaseScreen : MonoBehaviour
    {
        public GameObject currentPopup { get; protected set; }

        [SerializeField]
        protected Canvas canvas;

        [SerializeField]
        protected CanvasGroup panelCanvasGroup;

        protected virtual void Awake()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        protected virtual void Start()
        {
        }

        protected virtual void OnDestroy()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            DOTween.KillAll();
        }

        public void OpenPopup<T>(string name, Action<T> onOpened = null, bool darkenBackground = true) where T : Popup
        {
            var prefab = Resources.Load<GameObject>(name);

            if (onOpened != null)
            {
                onOpened(currentPopup.GetComponent<T>());
            }
        }

        public void ClosePopup()
        {
            if (currentPopup != null)
            {
                Destroy(currentPopup);
                currentPopup = null;
                panelCanvasGroup.blocksRaycasts = false;
                panelCanvasGroup.GetComponent<Image>().DOKill();
                panelCanvasGroup.GetComponent<Image>().DOFade(0.0f, 0.2f);
            }
        }

        public void OnPopupClosed(Popup popup)
        {
            panelCanvasGroup.blocksRaycasts = false;
            panelCanvasGroup.GetComponent<Image>().DOKill();
            panelCanvasGroup.GetComponent<Image>().DOFade(0.0f, 0.25f);
        }
    }
}
