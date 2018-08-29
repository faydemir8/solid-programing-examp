using _2_OpenClosed.Enum;

namespace _2_OpenClosed.False_Use
{
    class XmlLog
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class DbLog
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class Logger
    {
        private readonly XmlLog _xmlLog;
        private readonly DbLog _dbLog;

        public Logger(XmlLog xmlLog, DbLog dbLog)
        {
            _xmlLog = xmlLog;
            _dbLog = dbLog;
        }

        public void Log(LogType type, string value)
        {
            switch (type)
            {
                case LogType.Xml:
                    _xmlLog.Log(value);
                    break;
                case LogType.Db:
                     _dbLog.Log(value);
                    break;
            }

        }
    }
}
