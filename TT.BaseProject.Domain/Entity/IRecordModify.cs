﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.BaseProject.Domain.Entity
{
    public interface IRecordModify
    {
        public DateTime? modified_date { get; set; }

        public string modified_by { get; set; }
    }
}
