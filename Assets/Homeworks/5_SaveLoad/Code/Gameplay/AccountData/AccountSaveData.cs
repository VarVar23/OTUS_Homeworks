using Zenject;

namespace SaveLoad
{
    public class AccountSaveData : IInitializable
    {
        private SaveLoadSystem _system;
        private AccountDataView _view;

        public AccountSaveData(SaveLoadSystem saveLoadSystem, AccountDataView view)
        {
            _system = saveLoadSystem;
            _view = view;
        }

        public void Initialize()
        {
            _view.InputName.onEndEdit.AddListener((_) => _system.Save());
        }
    }
}