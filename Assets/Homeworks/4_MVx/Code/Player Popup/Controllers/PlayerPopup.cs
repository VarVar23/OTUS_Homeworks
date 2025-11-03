using Zenject;

namespace MVx
{
    public class PlayerPopup : IInitializable
    {
        private PlayerPopupView _view;
        private PlayerPopupFiller _popupFiller;

        public PlayerPopup(PlayerPopupView playerPopupView, PlayerPopupFiller popupFiller)
        {
            _view = playerPopupView;
            _popupFiller = popupFiller;
        }

        public void Initialize()
        {
            _view.CloseButton.onClick.AddListener(Close);
        }

        public void Open(PlayerInfo playerInfo)
        {
            _popupFiller.Fill(playerInfo);
            _view.gameObject.SetActive(true);
        }

        public void Close()
        {
            _view.gameObject.SetActive(false);
            _popupFiller.Remove();
        }
    }
}