﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JackWFinlay.Jsonize
{
    /// <summary>
    /// Specifies handling of the class attributes on a node during conversion.
    /// </summary>
    public enum ClassAttributeHandling
    {
        /// <summary>
        /// Output classes as an array.
        /// </summary>
        Array = 0,

        /// <summary>
        /// Output classes as a space delimited string.
        /// </summary>
        String = 1
    }
}
