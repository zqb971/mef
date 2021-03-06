﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NETFX_CORE
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace System.Composition.UnitTests
{
    [TestClass]
    public class CompositionContextExtensionsTests : ContainerTests
    {
        public interface IUnregistered { }

        [TestMethod]
        public void GettingAnOptionalExportThatDoesntExistReturnsNull()
        {
            var c = CreateContainer();

            IUnregistered unregistered;
            Assert.IsFalse(c.TryGetExport<IUnregistered>(null, out unregistered));
            Assert.IsNull(unregistered);
        }
    }
}
