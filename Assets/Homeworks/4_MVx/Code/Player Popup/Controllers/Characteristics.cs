using UnityEngine;

namespace MVx
{
    public class Characteristics
    {
        private Transform _container;
        private CharacteristicView _prefab;

        public Characteristics(Transform container, CharacteristicView prefab)
        {
            _container = container;
            _prefab = prefab;
        }

        public void CreateCharacteristics(PlayerInfo playerInfo)
        {
            if (_container.childCount > 0) RemoveAllCharacteristics();

            int count = playerInfo.PlayerStats.Characteristics.Count;

            for(int i = 0; i < count; i++)
            {
                var characteristic = GameObject.Instantiate(_prefab, _container);
                var name = playerInfo.PlayerStats.Characteristics[i].Name;
                var value = playerInfo.PlayerStats.Characteristics[i].Value;

                characteristic.Text.text = name + ": " + value;
            }
        }

        public void RemoveAllCharacteristics()
        {
            for (int i = _container.childCount - 1; i >= 0; i--)
            {
                GameObject.Destroy(_container.GetChild(i).gameObject);
            }
        }
    }
}
