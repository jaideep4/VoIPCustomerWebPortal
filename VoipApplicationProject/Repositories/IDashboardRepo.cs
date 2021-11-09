﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoipApplicationProject.Models;

namespace VoipApplicationProject.Repositories
{
    public interface IDashboardRepo
    {
        List<MenuAccessModel> GetMenu(string CustomerId, bool IsAccess);
    }
}
