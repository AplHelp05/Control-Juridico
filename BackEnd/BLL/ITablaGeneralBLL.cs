﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;
namespace BackEnd.BLL
{
    public interface ITablaGeneralBLL:IBLLGenerico<TablaGeneral>
    {
        List<TablaGeneral> Consulta(string tabla,string campo);
    }
}
