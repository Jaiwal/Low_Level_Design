namespace src.DesignPatterns.Creational.Singleton.GoodSolution
{
    public class AppSettings
    {
        private static AppSettings _instance; //instance will be stored here, like a cache you say
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        private AppSettings()
        {
            
        }

        public static AppSettings GetInstance()
        {
            if (_instance is null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }
        public object Get(String key)
        {
            if (!_settings.ContainsKey(key))
            {
                return null;
            }
            return _settings[key];
        }

        public void Set(string key, object value)
        {
            _settings[key] = value;
        }
    }
}