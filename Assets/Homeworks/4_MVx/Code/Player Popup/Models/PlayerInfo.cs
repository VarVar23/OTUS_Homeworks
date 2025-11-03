using UnityEngine;

namespace MVx
{
    [CreateAssetMenu(fileName = "PlayerInfo", menuName = "Scriptable Objects/PlayerInfo")]
    public class PlayerInfo : ScriptableObject
    {
        [field: SerializeField] public PlayerProfile PlayerProfile { get; private set; }
        [field: SerializeField] public PlayerStats PlayerStats { get; private set; }
    }
}