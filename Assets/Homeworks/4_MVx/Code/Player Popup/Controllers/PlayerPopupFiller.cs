namespace MVx
{
    public class PlayerPopupFiller
    {
        private Characteristics _characteristicsFactory;
        private PlayerPopupView _view;
        private XPBar _drawXP;

        public PlayerPopupFiller(Characteristics characteristicsFactory, PlayerPopupView playerPopupView, XPBar drawXP)
        {
            _characteristicsFactory = characteristicsFactory;
            _view = playerPopupView;
            _drawXP = drawXP;
        }

        public void Fill(PlayerInfo playerInfo)
        {
            _view.Name.text = playerInfo.PlayerProfile.Name;
            _view.Description.text = playerInfo.PlayerProfile.Description;
            _view.Icon.sprite = playerInfo.PlayerProfile.Icon;

            _view.LevelText.text = "Level: " + playerInfo.PlayerStats.Level;

            _characteristicsFactory.CreateCharacteristics(playerInfo);
            _drawXP.Draw(playerInfo.PlayerStats.CurrentXP, playerInfo.PlayerStats.MaxXP);
        }

        public void Remove()
        {
            _view.Name.text = string.Empty;
            _view.Description.text = string.Empty;
            _view.LevelText.text = string.Empty;

            _characteristicsFactory.RemoveAllCharacteristics();
            _drawXP.Draw(0, 0);
        }
    }
}
