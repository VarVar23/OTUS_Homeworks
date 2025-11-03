using UnityEngine;
using Zenject;

namespace MVx
{
    public class PlayerUIInstaller : MonoInstaller
    {
        [SerializeField] private PlayerPopupView _playerPopupView;
        [SerializeField] private CharacteristicView _characteristicPrefab;

        [SerializeField] private PlayersListView _allPlayersView;
        [SerializeField] private PlayerListItemView _openPlayerPrefab;


        public override void InstallBindings()
        {
            PlayerPopup();
            AllPlayer();
        }

        private void PlayerPopup()
        {
            Container.Bind<PlayerPopupView>().FromInstance(_playerPopupView).AsSingle();
            Container.Bind<DrawXPBarModel>().AsSingle();
            Container.Bind<XPBar>().AsSingle();
            Container.Bind<Characteristics>().AsSingle().WithArguments(_playerPopupView.CharacteristicsContainer, _characteristicPrefab);
            Container.Bind<PlayerPopupFiller>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerPopup>().AsSingle();
        }

        private void AllPlayer()
        {
            Container.Bind<PlayersListView>().FromInstance(_allPlayersView).AsSingle();
            Container.Bind<PlayerListItemView>().FromInstance(_openPlayerPrefab).AsSingle();
            Container.BindInterfacesAndSelfTo<PlayersListController>().AsSingle();
        }
    }
}