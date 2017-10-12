using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FSW
{
    public class Watcher
    {
        public delegate void NewFileEventHandler(object sender, FileSystemEventArgs e);
        public event NewFileEventHandler NewFileHandler;

        string _path;
        string _extension;

        FileSystemWatcher watcher;

        public Watcher()
        {
            _path = string.Empty;
            _extension = string.Empty;
        }

        public string WatchPath
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        public string WatchFileExtension
        {
            get
            {
                return _extension;
            }
            set
            {
                _extension = value;
            }
        }

        public void StartWatch()
        {
            this.StartWatch(_path, _extension);
        }

        public void StartWatch(string Path, string Extension)
        {
            if (watcher == null)
            {
                watcher = new FileSystemWatcher();

                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                   | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                watcher.Path = Path;
                watcher.Filter = Extension;

                watcher.Created += new FileSystemEventHandler(OnNewFile);

                watcher.EnableRaisingEvents = true;
            }
        }

        public void EndWatch()
        {
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
                watcher = null;
            }
                
        }

        protected virtual void OnNewFile(object source, FileSystemEventArgs e)
        {
            if (NewFileHandler != null)
            {
                NewFileHandler(this, e);
            }
        }
    }
}
