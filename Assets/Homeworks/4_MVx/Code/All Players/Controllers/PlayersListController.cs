using UnityEngine;
using Zenject;

namespace MVx
{
    public class PlayersListController : IInitializable
    {
        private PlayersListView _allPlayersView;
        private PlayerListItemView _prefab;
        private PlayerPopup _playerPopup;

        public PlayersListController(PlayersListView allPlayersView, PlayerListItemView openPlayerView, PlayerPopup playerPopup)
        {
            _allPlayersView = allPlayersView;
            _prefab = openPlayerView;
            _playerPopup = playerPopup;
        }

        public void Initialize()
        {
            Create();
        }

        private void Create()
        {
            for(int i = 0; i < _allPlayersView.AllPlayers.Count; i++)
            {
                int j = i;

                var openPlayer = GameObject.Instantiate(_prefab, _allPlayersView.transform);

                openPlayer.Icon.sprite = _allPlayersView.AllPlayers[i].PlayerProfile.Icon;
                openPlayer.Name.text = _allPlayersView.AllPlayers[i].PlayerProfile.Name;
                openPlayer.OpenButton.onClick.AddListener(() => _playerPopup.Open(_allPlayersView.AllPlayers[j]));
            }
        }
    }
}