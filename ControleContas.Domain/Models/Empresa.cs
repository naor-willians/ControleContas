﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Domain.Models
{
    public class Empresa : Contato
    {
        public string CNPJ { get; set; }
    }
}
