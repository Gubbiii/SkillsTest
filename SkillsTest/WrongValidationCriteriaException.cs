﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    internal class WrongValidationCriteriaException : Exception
    {


        public WrongValidationCriteriaException(string message)
                : base(message)
        {
        }

    }
}
