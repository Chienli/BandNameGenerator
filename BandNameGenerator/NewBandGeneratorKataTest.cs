﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGenerator
{
    [TestClass]
    public class NewBandGeneratorKataTest
    {
        private readonly NewBandGeneratorKata _kata = new NewBandGeneratorKata();

        [TestMethod]
        public void Diff_first_end_return_The_Blank_Band()
        {
            var actual = _kata.GetNewBandName("soul");

            Assert.AreEqual("The Soul", actual);
        }

        [TestMethod]
        public void Same_first_end_return_Band_repeat_without_first()
        {
            var actual = _kata.GetNewBandName("tart");

            Assert.AreEqual("Tartart", actual);
        }
    }
}