using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace HeroTales
{
    public class PopupChat : MonoBehaviour
    {
        public ScrollRect scrollView;
        public GameObject scrollViewContent;
        public GameObject textLinePrefab;
        public TMP_InputField inputField;
        public Color playerTextColor = new Color(66 / 256.0f, 137 / 256.0f, 166 / 256.0f);
        public Color opponentTextColor = new Color(183 / 256.0f, 86 / 256.0f, 93 / 256.0f);

        private static readonly int maxChatMessageLength = 50;

        private CanvasGroup canvasGroup;

        public bool isVisible { get; private set; }

        private void Awake()
        {
            Assert.IsNotNull(scrollView);
            Assert.IsNotNull(scrollViewContent);
            Assert.IsNotNull(textLinePrefab);
            Assert.IsNotNull(inputField);

            canvasGroup = GetComponent<CanvasGroup>();
        }

        void Start()
        {
            inputField.ActivateInputField();
        }

        public void Show()
        {
            isVisible = true;
            canvasGroup.alpha = 1;
        }

        public void Hide()
        {
            isVisible = false;
            canvasGroup.alpha = 0;
        }
    }
}
