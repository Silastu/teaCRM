﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using teaCRM.Dao.Impl;

namespace teaCRM.Service.Impl
{
    public class SysDepartmentService : ISysDepartmentService
    {
        public string GetTreeData()
        {
            return new SysDepartmentDao().GetTreeData();
        }



    }
}
