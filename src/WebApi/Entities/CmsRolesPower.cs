﻿using System;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public partial class CmsRolesPower
    {
        public int CommId { get; set; }
        public int? RoleId { get; set; }
        public string CmsCode { get; set; }
        public string CmsPowers { get; set; }
    }
}
