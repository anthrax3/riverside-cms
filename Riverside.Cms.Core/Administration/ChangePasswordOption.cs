﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riverside.Cms.Core.Administration
{
    public class ChangePasswordOption : AdministrationOption
    {
        public override AdministrationAction Action { get { return AdministrationAction.ChangePassword; } }
    }
}
