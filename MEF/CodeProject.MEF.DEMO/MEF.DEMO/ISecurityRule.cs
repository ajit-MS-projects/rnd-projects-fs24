﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MEF.DEMO
{
    public interface ISecurityRule
    {
        bool PassesValidation(XDocument document);
    }
}
