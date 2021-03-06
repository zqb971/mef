﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Composition.Demos.Web.Mvc.UnitTests.Util
{
    static class AssertX
    {
        public static TException Throws<TException>(Action action)
            where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException ex)
            {
                return ex;
            }

            throw new AssertFailedException(string.Format("Expected {0}", typeof(TException)));
        }
    }
}
