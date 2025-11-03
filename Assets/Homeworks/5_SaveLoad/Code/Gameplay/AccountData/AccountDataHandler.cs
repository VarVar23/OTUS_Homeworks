using TMPro;
using UnityEngine;
using Zenject;

namespace SaveLoad
{
    public class AccountDataHandler : IInitializable, ISave, ILoad
    {
        private AccountDataView _view;

        public AccountDataHandler(AccountDataView accountDataView)
        {
            _view = accountDataView;
        }

        public void Initialize()
        {
            _view.InputName.onValueChanged.AddListener(ChangeName);
        }

        public void Load(SaveData data)
        {
            _view.TextName.text = data.AccountData.Name;
        }

        public void Save(SaveData data)
        {
            data.AccountData.Name = _view.TextName.text;
        }

        private void ChangeName(string name)
        {
            _view.TextName.text = name;
        }
    }
}