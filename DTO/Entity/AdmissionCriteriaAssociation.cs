﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class AdmissionCriteriaAssociation
    {
        public int AdmissionCriteriaAssociationId { get; set; }
        public int BatchId  { get; set; }
        public int ProgramId { get; set; }
        public int CriteriaId { get; set; }
        public string SetAction { get; set; }
        public string CriteriaIds { get; set; }
        public string CriteriaDescription { get; set; }
        public bool Active { get; set; }
    }
}
