﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    internal class WrongValidationCriteriaExceptionDog : Exception
    {


        public WrongValidationCriteriaExceptionDog(string message)
               : base(message)
        {
        }
    }
}
