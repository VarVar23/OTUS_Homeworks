using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StateMachine
{
    public class BootstrapState : IState
    {
        public event Action InitializeCompleted;

        private LoadingCurtain _loadingCurtain;

        public BootstrapState(LoadingCurtain loadingCurtain)
        {
            _loadingCurtain = loadingCurtain;
        }

        public async void Enter()
        {
            Debug.Log("Bootstrap State");

            await _loadingCurtain.Close();
            await Task.Delay(5000); // Imitated service initialize

            InitializeCompleted?.Invoke();
        }

        public async void Exit()
        {
            await SceneManager.LoadSceneAsync(1);
            await _loadingCurtain.Open();
        }
    }
}