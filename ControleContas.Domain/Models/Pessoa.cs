﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Domain.Models
{
    public class Pessoa : Contato
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
    }
}
