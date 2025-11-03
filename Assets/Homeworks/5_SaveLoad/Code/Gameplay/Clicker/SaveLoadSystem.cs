using System;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace SaveLoad
{
    public class SaveLoadSystem : IInitializable, IDisposable
    {
        private SaveLoadService _service;
        private bool _gameMode;

        public SaveLoadSystem(SaveLoadService service)
        {
            _service = service;
        }

        public void Initialize()
        {
            _gameMode = true;
            _service.Load();
            AutoSave();
        }

        public void Save()
        {
            _service.Save();
        }

        private async void AutoSave()
        {
            while(_gameMode)
            {
                await Task.Delay(10000);
                if (!_gameMode) return;

                Save();
                Debug.Log("Auto save");
            }
        }

        public void Dispose()
        {
            _gameMode = false;
            Save();
            Debug.Log("The data is saved, goodbye!");
        }
    }
}