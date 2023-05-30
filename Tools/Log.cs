namespace Tools;
public sealed class Log
{
    private static Log _instance = null;
    private string _path;
    private static object _protect = new Object();

    public static Log GetInstance(string path)
    {
        lock(_protect)
        {
            if (_instance == null)
            {
                _instance = new Log(path);
            }
        }
        
        return _instance;
    }

    private Log(string path)
    {
        _path = path;
    }

    // 1 parameter: the string that will be saved in the txt
    public void Save(string message)
    {
        File.AppendAllText(_path, message + Environment.NewLine);
    }
}

