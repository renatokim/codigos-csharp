﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoThreads.AutoMapper
{
    public class Order
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
