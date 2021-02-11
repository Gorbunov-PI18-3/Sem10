using System;

namespace Sem10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Writer writer = new Writer();

            ((IWriter)writer).Write();

            Console.ReadKey();
        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }

    public interface IWriter
    {
        void Write();
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IMailer
    {
    }

    internal interface IReader
    {
    }
}
