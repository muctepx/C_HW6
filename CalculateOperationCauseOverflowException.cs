﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    internal class CalculateOperationCauseOverflowException : Exception
    {
        public CalculateOperationCauseOverflowException(string message) : base(message)
        {
           
        }
    }
}
