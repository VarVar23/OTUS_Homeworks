using System;
using System.Collections.Generic;
using UnityEngine;

namespace MVx
{
    [Serializable]
    public class PlayerStats
    {
        [field: SerializeField] public int Level { get; private set; }
        [field: SerializeField] public int CurrentXP { get; private set; }
        [field: SerializeField] public int MaxXP { get; private set; }
        [field: SerializeField] public List<Characteristic> Characteristics { get; private set; }
    }
}