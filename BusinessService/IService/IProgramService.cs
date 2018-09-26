using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IProgramService
    {
        List<Program> GetProgram();
        string InUpProgram(Program program);
        List<Program> GetProgramByDegree(int DegreeTypeId);
    }
}
