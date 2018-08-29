using _2_OpenClosed.Enum;

namespace _2_OpenClosed.Correct_Use
{
    interface ILogger
    {
        bool Log(string value);
    }
    class XmlLog: ILogger
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class DbLog: ILogger
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class JsonLog : ILogger
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class Logger
    {
        private readonly ILogger _logger;

        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string value)
        {
            _logger.Log(value);
        }
    }
}
