using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTechnicalService.Objects;

namespace CarTechnicalService.Functions
{
    public class ProjectCreatingModule
    {
        List<Project> projects = new List<Project>();

        public List<Project> ViewAllProjects()
        {
            return projects;
        }
    }
}