using UnityEngine;
using Zenject;

namespace SaveLoad
{
    public class SaveLoadInstaller : MonoInstaller
    {
        [SerializeField] private ClickerView _clickerView;
        [SerializeField] private AccountDataView _accountDataView;

        public override void InstallBindings()
        {
            Container.Bind<ClickerView>().FromInstance(_clickerView).AsSingle();
            Container.Bind<SaveLoadService>().AsSingle();
            Container.BindInterfacesAndSelfTo<Clicker>().AsSingle();
            Container.BindInterfacesAndSelfTo<SaveLoadSystem>().AsSingle();

            Container.Bind<AccountDataView>().FromInstance(_accountDataView).AsSingle();
            Container.BindInterfacesAndSelfTo<AccountDataHandler>().AsSingle();
            Container.BindInterfacesAndSelfTo<AccountSaveData>().AsSingle();
        }
    }
}