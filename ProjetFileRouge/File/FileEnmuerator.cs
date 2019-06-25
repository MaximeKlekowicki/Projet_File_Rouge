using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Projet_File_Rouge
{
    class FileEnumerator : IEnumerator<string>
    {
        StreamReader _stream;

        public string Current => _stream.ReadLine();

        object IEnumerator.Current => this.Current;

        public FileEnumerator(StreamReader stream)
        {
            _stream = stream;
        }

        public void Dispose()
        {
            _stream.Close();
        }

        public bool MoveNext()
        {
            return !_stream.EndOfStream;
        }

        public void Reset()
        {
            _stream.DiscardBufferedData();
        }
    }
}
