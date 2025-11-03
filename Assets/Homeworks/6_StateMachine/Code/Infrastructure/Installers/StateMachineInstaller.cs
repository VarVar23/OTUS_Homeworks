using Zenject;
using UnityEngine;

namespace StateMachine
{
    public class StateMachineInstaller : MonoInstaller
    {
        [SerializeField] private LoadingCurtainView _loadingCurtainView;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Bootstraper>().AsSingle();
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameState>().AsSingle();

            Container.Bind<LoadingCurtainView>().FromInstance(_loadingCurtainView).AsSingle();
            Container.Bind<LoadingCurtainData>().AsSingle();
            Container.Bind<LoadingCurtain>().AsSingle();
            Container.Bind<StateMachine>().AsSingle();
        }
    }
}