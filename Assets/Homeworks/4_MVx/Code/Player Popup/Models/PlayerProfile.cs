using System;
using UnityEngine;

namespace MVx
{
    [Serializable]
    public class PlayerProfile
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
    }
}