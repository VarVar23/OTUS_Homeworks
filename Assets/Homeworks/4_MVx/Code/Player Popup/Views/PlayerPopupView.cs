using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVx
{
    public class PlayerPopupView : MonoBehaviour
    {
        [field: Header("Profile")]
        [field: SerializeField] public TMP_Text Name { get; private set; }
        [field: SerializeField] public TMP_Text Description { get; private set; }
        [field: SerializeField] public Image Icon { get; private set; }

        [field: Header("XP Bar")]
        [field: SerializeField] public Image XPImage { get; private set; }
        [field: SerializeField] public TMP_Text XPText { get; private set; }

        [field: Header("Characteristics")]
        [field: SerializeField] public Transform CharacteristicsContainer { get; private set; }
        [field: SerializeField] public TMP_Text LevelText { get; private set; }

        [field: Header("Buttons")]
        [field: SerializeField] public Button CloseButton { get; private set; }
        [field: SerializeField] public Button LevelUP { get; private set; }
    }
}