using UnityEngine;

namespace MVx
{
    public class XPBar
    {
        private PlayerPopupView _view;
        private DrawXPBarModel _model;

        public XPBar(PlayerPopupView playerPopupView, DrawXPBarModel model)
        {
            _view = playerPopupView;
            _model = model;
        }

        public void Draw(int currentXP, int maxXP)
        {
            float fillAmound;

            if (currentXP > 0)
            {
                fillAmound = (float)currentXP / maxXP;
            }
            else
            {
                fillAmound = 0;
            }

            _view.XPImage.fillAmount = fillAmound;
            _view.XPText.text = _model.StartTextXP + currentXP + _model.Separation + maxXP;
        }
    }
}
