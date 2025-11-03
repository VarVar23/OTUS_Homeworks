using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SaveLoad
{
    public class ClickerView : MonoBehaviour
    {
        [field: SerializeField] public Button ClickButton { get; private set; }
        [field: SerializeField] public TMP_Text CountClicksText { get; private set; }
    }
}