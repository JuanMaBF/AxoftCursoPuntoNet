using System.IO;

namespace FSW
{
    public class Watcher
    {
        private string _path;
        private string _extension;
        private FileSystemWatcher watcher;

        public string WatchPath { get { return _path; } set { _path = value; } }
        public string WathFileExtension { get { return _extension;  } set { _extension = value; } }

        public Watcher()
        {
            _path = string.Empty;
            _extension = string.Empty;
        }

        public void StartWatch(string Path, string Extension)
        {
            if (watcher == null)
            {
                watcher = new FileSystemWatcher();
                watcher.NotifyFilter =
                    NotifyFilters.LastAccess |
                    NotifyFilters.LastWrite |
                    NotifyFilters.FileName |
                    NotifyFilters.DirectoryName;
                watcher.Created += new FileSystemEventHandler(OnNewFile);
                watcher.Path = Path;
                watcher.Filter = Extension;
                watcher.EnableRaisingEvents = true;
            }
        }

        public void StartWatch()
        {
            this.StartWatch(_path, _extension);
        }

        protected virtual void OnNewFile(object source, FileSystemEventArgs e)
        {
            if (NewFileHandler != null)
            {
                NewFileHandler(this, e);
            }
        }
        public delegate void NewFileEventHandler(object sender, FileSystemEventArgs e);
        public event NewFileEventHandler NewFileHandler;

        public void EndWatch()
        {
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
                watcher = null;
            }
        }


    }
}
