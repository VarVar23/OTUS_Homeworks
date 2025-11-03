using System;

namespace SaveLoad
{
    [Serializable]
    public class SaveData
    {
        public ClickerData ClickerData = new();
        public AccountData AccountData = new();
    }
}