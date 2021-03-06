﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Model;

namespace BackEnd.BLL
{
    public class UsuarioBLLImpl : BLLGenericoImpl<Usuario>, IUsuarioBLL
    {
        private UnidadDeTrabajo<Usuario> unidad;
        public List<Usuario> Consulta()
        {
            try
            {
                List<Usuario> lista;
                using (unidad = new UnidadDeTrabajo<Usuario>(new SCJ_BDEntities()))
                {
                    Expression<Func<Usuario, bool>> consulta = (d => d.idEstado.Equals(12));
                    lista = unidad.genericDAL.Find(consulta).ToList();
                }
                return lista;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
