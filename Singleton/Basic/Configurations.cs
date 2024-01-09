using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Basic
{
    public class Configurations
    {
        private static Configurations _instance;
        private Configurations()
        {
            Id = Random.Shared.Next();
            this._MachineName = RenameMachineName("myPC");
        }
        public static Configurations Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Configurations();
                }
                return _instance;
            }
        }

        /* configuration properties and methods */
        private string _MachineName;
        public int Id { get; }
        public string MachineName 
        { 
            get { return this._MachineName; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _MachineName = RenameMachineName(value);
                }
            }
        }
        public string FolderPath { get; set; } = string.Empty;
        private static string RenameMachineName(string name)
        {
            return $"{name}-{Guid.NewGuid()}";
        }
    }
}
