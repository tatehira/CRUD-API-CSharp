﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Api.Project.ModelsDto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Idade { get; set; }
    }
}
