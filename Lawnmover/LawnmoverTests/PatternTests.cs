﻿namespace LawnmoverTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Lawnmover;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PatternTests
    {
        [TestMethod]
        public void CreatePattern()
        {
            Pattern pattern = new Pattern(3, 2);

            Assert.AreEqual(3, pattern.Width);
            Assert.AreEqual(2, pattern.Height);
        }

        [TestMethod]
        public void SetRows()
        {
            Pattern pattern = new Pattern(2, 2);

            pattern.SetRow(0, new int[] { 1, 2 });
            pattern.SetRow(1, new int[] { 2, 3 });

            Assert.AreEqual(1, pattern.GetCell(0, 0));
            Assert.AreEqual(2, pattern.GetCell(0, 1));
            Assert.AreEqual(2, pattern.GetCell(1, 0));
            Assert.AreEqual(3, pattern.GetCell(1, 1));
        }
    }
}