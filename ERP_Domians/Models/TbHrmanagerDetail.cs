﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_Domians.Models
{
    public partial class TbHrmanagerDetail
    {
        public TbHrmanagerDetail()
        {
            TbEmployeeDetails = new HashSet<TbEmployeeDetail>();
            TbEmployeeTrainnings = new HashSet<TbEmployeeTrainning>();
            TbRecuirements = new HashSet<TbRecuirement>();
        }

        public int Hrid { get; set; }
        public string HrfullName { get; set; }
        public string Hrpassword { get; set; }

        public virtual ICollection<TbEmployeeDetail> TbEmployeeDetails { get; set; }
        public virtual ICollection<TbEmployeeTrainning> TbEmployeeTrainnings { get; set; }
        public virtual ICollection<TbRecuirement> TbRecuirements { get; set; }
    }
}
