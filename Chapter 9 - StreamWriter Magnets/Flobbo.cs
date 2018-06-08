using System;
using System.IO;

namespace Chapter_9___StreamWriter_Magnets
{
    internal class Flobbo
    {
        private string zap;

        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        internal StreamWriter Snobbo()
        {
            return new StreamWriter("macaw.txt");
        }

        internal bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "green purple";
            return false;
        }

        internal bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(zap);
                zap = "red orange";
                return true;
            }
        }
    }
}