using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Api.Project.ModelsDto
{
    public class Cliente
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }    
        public virtual int Idade { get; set; }
    }
}
