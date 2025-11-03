using TMPro;
using UnityEngine;

namespace SaveLoad
{
    public class AccountDataView : MonoBehaviour
    {
        [field: SerializeField] public TMP_InputField InputName { get; private set; }
        [field: SerializeField] public TMP_Text TextName { get; private set; }
    }
}