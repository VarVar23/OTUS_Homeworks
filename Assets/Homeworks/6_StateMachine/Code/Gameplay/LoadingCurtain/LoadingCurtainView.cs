using UnityEngine;

namespace StateMachine
{
    public class LoadingCurtainView : MonoBehaviour
    {
        [field: SerializeField] public CanvasGroup CanvasGroup { get; private set; }

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}