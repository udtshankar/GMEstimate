﻿using System;

namespace HM.GM.DAL.Model
{
    public class ResourceCostDetail
    {
        public string Practice { get; set; }

        public string Skill { get; set; }

        public string Competency { get; set; }

        public double OnsiteCost { get; set; }

        public double OffsiteCost { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public bool IsActive { get; set; }

    }
}
