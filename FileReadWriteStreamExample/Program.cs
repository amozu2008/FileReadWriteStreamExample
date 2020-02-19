using System;
using System.IO;

namespace FileReadWriteStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Source = null, Destination = null;
            try
            {
                Source =
                new FileStream(@"C:\Users\PC\Documents\VF.mp4",
                               FileMode.Open,
                               FileAccess.Read);

                Destination =
                new FileStream(@"C:\Users\PC\Videos\CopiedVF.mp4",
                                FileMode.Create,
                                FileAccess.Write);

                int len;
                while((len = Source.ReadByte()) > -1)
                {
                    Destination.WriteByte((byte)len);
                }

                Console.WriteLine("Finishing copying");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
