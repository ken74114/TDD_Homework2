using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TDD_Homework2
{
    [Serializable]
    public class Book
    {
        public string BookName { get; set; }
        public int Price { get; set; }

        public Book Clone()
        {
            using (MemoryStream memory = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memory, this);
                memory.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(memory) as Book;
            }
        }
    }
}