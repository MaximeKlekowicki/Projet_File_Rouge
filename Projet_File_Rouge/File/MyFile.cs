using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;

namespace Projet_File_Rouge
{
    public class MyFile : IEnumerable<string>
    {
        private string _path;

        public string Path
        {
            get { return _path; }
            private set { _path = value; }
        }

        public MyFile(string p)
        {
            Path = p;
        }

        public string this[int l]
        {
            get
            {
                string res = "";
                StreamReader _stream = new StreamReader(_path);
                for (int i = -1; i < l; i++)
                {
                    res = _stream.ReadLine();
                }
                _stream.Close();
                return res;
            }
            set
            {
                StreamReader _streamR = new StreamReader(_path);
                string res = "";
                for (int i = -1; i < l; i++)
                {
                    res += _streamR.ReadLine() + '\n';
                }
                res += value + '\n';
                while (!_streamR.EndOfStream)
                {
                    res += _streamR.ReadLine() + '\n';
                }
                _streamR.Close();
                StreamWriter _streamW = new StreamWriter(_path);
                _streamW.Write(res);
                _streamW.Close();
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new FileEnumerator(new StreamReader(_path));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
