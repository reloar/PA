﻿using PADomain;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAWeb
{
    public class MemberListViewModel
    {
        public IPagedList<IMember> Members { get; set; }

    }
}