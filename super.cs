using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallengeW1D3
{
    [TestClass]
    public class super
    {
        [TestMethod]
        public void SuperLoop()
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
        }
    }
}


