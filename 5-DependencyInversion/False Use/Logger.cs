namespace _5_DependencyInversion.False_Use
{
    class XmlLog
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class Logger
    {
        private readonly XmlLog _xmlLog= new XmlLog();

        public void Log(string value)
        {
            _xmlLog.Log(value);
        }

    }
}

