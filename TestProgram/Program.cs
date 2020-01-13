using static ABCNET.Extensions.SeqExt;
using ABCNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProgram
{
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            var Arr1 = Arr.Fill(5, 2);
            var Arr2 = Arr.Fill(3, 3);
            //Arr.New<byte>(1, 2, 3).ToTup3().Println();
            Arr1.Interleave(Arr2,false).Println();
            _ = Arr.ReadInteger(1);
        }
    }
}