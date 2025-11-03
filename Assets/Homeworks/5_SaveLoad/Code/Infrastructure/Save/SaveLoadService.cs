using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace SaveLoad
{
    public class SaveLoadService
    {
        private SaveData _saveData;
        private List<ISave> _saveList = new();
        private List<ILoad> _loadList = new();

        private readonly string _path = Application.dataPath + "Save.json";

        public SaveLoadService(IEnumerable<ISave> saves, IEnumerable<ILoad> loades)
        {
            _saveList.AddRange(saves);
            _loadList.AddRange(loades);
        }

        public void AddSaveItem(ISave item)
        {
            _saveList.Add(item);
        }

        public void AddLoadItem(ILoad item)
        {
            _loadList.Add(item);
        }

        public void Save()
        {
            for(int i = 0; i < _saveList.Count; i++)
            {
                _saveList[i].Save(_saveData);
            }

            var json = JsonUtility.ToJson(_saveData);
            File.WriteAllText(_path, json);
        }

        public void Load()
        {
            if(!File.Exists(_path))
            {
                _saveData = new();
                Debug.Log("File not found");
                Save();
            }
            else
            {
                Debug.Log("File found: " + _path);
                var json = File.ReadAllText(_path);
                _saveData = JsonUtility.FromJson<SaveData>(json);
            }

            for(int i = 0; i < _loadList.Count; i++)
            {
                _loadList[i].Load(_saveData);
            }
        }
    }
}