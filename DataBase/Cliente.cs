﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Cliente
    {
        public string Nome { get; set; }
       public List<Cliente>  Clientes (string cliente)
        {

            var Clientes = new List<Cliente>();
            Clientes.Add(new Cliente() { Nome = "Danilo" });
            return Clientes;
        }
    }
}

