﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Domain
{
    public interface IKeypad
    {
        int getNumberInput();
        string getStringInput();
    }
}
