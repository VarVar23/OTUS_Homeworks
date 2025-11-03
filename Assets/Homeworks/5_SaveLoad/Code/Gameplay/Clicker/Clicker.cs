using Zenject;

namespace SaveLoad
{
    public class Clicker : IInitializable, ISave, ILoad
    {
        private ClickerView _view;
        private int _count;

        public Clicker(ClickerView clickerView)
        {
            _view = clickerView;
        }

        public void Initialize()
        {
            _view.ClickButton.onClick.AddListener(Click);
        }

        private void Click()
        {
            _count++;
            _view.CountClicksText.text = _count.ToString();
        }

        public void Load(SaveData data)
        {
            _count = data.ClickerData.CountClick;
            _view.CountClicksText.text = _count.ToString();
        }

        public void Save(SaveData data)
        {
            data.ClickerData.CountClick = _count;
        }
    }
}