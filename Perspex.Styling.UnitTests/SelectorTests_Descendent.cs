﻿// -----------------------------------------------------------------------
// <copyright file="SelectorTests_Descendent.cs" company="Steven Kirk">
// Copyright 2014 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Styling.UnitTests
{
    using System;
    using System.Linq;
    using System.Reactive.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Perspex.Styling;

    [TestClass]
    public class SelectorTests_Descendent
    {
        [TestMethod]
        public void Descendent_Matches_Control_When_It_Is_Child_OfType()
        {
            throw new NotImplementedException();
            ////var parent = new Mock<TestLogical1>();
            ////var child = new Mock<TestLogical2>();
 
            ////child.Setup(x => x.LogicalParent).Returns(parent.Object);

            ////var selector = new Selector().OfType(parent.Object.GetType()).Descendent().OfType(child.Object.GetType());

            ////Assert.IsTrue(ActivatorValue(selector, child.Object));
        }

        [TestMethod]
        public void Descendent_Matches_Control_When_It_Is_Descendent_OfType()
        {
            throw new NotImplementedException();
            ////var grandparent = new Mock<TestLogical1>();
            ////var parent = new Mock<TestLogical2>();
            ////var child = new Mock<TestLogical3>();

            ////parent.Setup(x => x.LogicalParent).Returns(grandparent.Object);
            ////child.Setup(x => x.LogicalParent).Returns(parent.Object);

            ////var selector = new Selector().OfType(grandparent.Object.GetType()).Descendent().OfType(child.Object.GetType());

            ////Assert.IsTrue(ActivatorValue(selector, child.Object));
        }

        [TestMethod]
        public void Descendent_Matches_Control_When_It_Is_Descendent_OfType_And_Class()
        {
            throw new NotImplementedException();
            ////var grandparent = new Mock<TestLogical1>();
            ////var parent = new Mock<TestLogical2>();
            ////var child = new Mock<TestLogical3>();

            ////grandparent.Setup(x => x.Classes).Returns(new Classes("foo"));
            ////parent.Setup(x => x.LogicalParent).Returns(grandparent.Object);
            ////parent.Setup(x => x.Classes).Returns(new Classes());
            ////child.Setup(x => x.LogicalParent).Returns(parent.Object);

            ////var selector = new Selector().OfType(grandparent.Object.GetType()).Class("foo").Descendent().OfType(child.Object.GetType());

            ////Assert.IsTrue(ActivatorValue(selector, child.Object));
        }

        [TestMethod]
        public void Descendent_Doesnt_Match_Control_When_It_Is_Descendent_OfType_But_Wrong_Class()
        {
            throw new NotImplementedException();
            ////var grandparent = new Mock<TestLogical1>();
            ////var parent = new Mock<TestLogical2>();
            ////var child = new Mock<TestLogical3>();

            ////grandparent.Setup(x => x.Classes).Returns(new Classes("bar"));
            ////parent.Setup(x => x.LogicalParent).Returns(grandparent.Object);
            ////parent.Setup(x => x.Classes).Returns(new Classes("foo"));
            ////child.Setup(x => x.LogicalParent).Returns(parent.Object);

            ////var selector = new Selector().OfType<TestLogical1>().Class("foo").Descendent().OfType<TestLogical3>();

            ////Assert.IsFalse(ActivatorValue(selector, child.Object));
        }

        private static bool ActivatorValue(Selector selector, IStyleable control)
        {
            return selector.GetActivator(control).Take(1).ToEnumerable().Single();
        }

        ////public abstract class TestLogical1 : TestLogical
        ////{
        ////}

        ////public abstract class TestLogical2 : TestLogical
        ////{
        ////}

        ////public abstract class TestLogical3 : TestLogical
        ////{
        ////}
    }
}
