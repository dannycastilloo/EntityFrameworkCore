﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
