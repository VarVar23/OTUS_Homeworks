using System.Collections.Generic;
using UnityEngine;

namespace MVx
{
    public class PlayersListView : MonoBehaviour
    {
        [field: SerializeField] public List<PlayerInfo> AllPlayers { get; private set; }
    }
}