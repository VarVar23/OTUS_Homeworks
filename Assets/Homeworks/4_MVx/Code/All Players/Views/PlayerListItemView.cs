using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVx
{
    public class PlayerListItemView : MonoBehaviour
    {
        [field: SerializeField] public Button OpenButton { get; private set; }
        [field: SerializeField] public TMP_Text Name { get; private set; }
        [field: SerializeField] public Image Icon { get; private set; }
    }
}