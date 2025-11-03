using System;
using UnityEngine;

namespace MVx
{
    [Serializable]
    public class Characteristic
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Value { get; private set; }
    }
}