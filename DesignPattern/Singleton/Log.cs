using System;
namespace DesignPattern.Singleton
{
	public class Log
	{
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        private Log()
        { }

        // 1 parameter: the string that will be saved in the txt
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}

