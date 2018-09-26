using BusinessService.IService;
using DataAccess.DataSource;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class ProgramService : IProgramService
    {
        public List<Program> GetProgram()
        {
            return ProgramDS.GetAllProgram();
        }

        public List<Program> GetProgramByDegree(int DegreeTypeId)
        {
            return ProgramDS.GetProgramByDegree(DegreeTypeId);
        }

        public string InUpProgram(Program program)
        {
            return ProgramDS.UpdateProgram(program);
        }
    }
}
