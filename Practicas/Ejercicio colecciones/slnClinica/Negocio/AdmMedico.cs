using System;
using Entidades.Reales;
using System.Collections.Generic;

namespace Negocio
{
    public class AdmMedico : AdmBase<Medico>
    {
        public void CrearMedicos()
        {
            lista.Add(new Medico(1, "hola", "hola", "hola",
                DateTime.Now, "hola"));
            lista.Add(new Medico(2, "hola", "hola", "hola",
                DateTime.Now, "hola"));
            lista.Add(new Medico(3, "hola", "hola", "hola",
                DateTime.Now, "hola"));
            lista.Add(new Medico(4, "hola", "hola", "hola",
                DateTime.Now, "hola"));
            lista.Add(new Medico(5, "hola", "hola", "hola",
                DateTime.Now, "hola"));
            lista.Add(new Medico(6, "hola", "hola", "hola",
                DateTime.Now, "hola"));
        }

        public List<string> ObtenerEspecialidades()
        {
            List<string> especialidades = new List<string>();
            lista.ForEach(m =>
            {
                bool any = false;
                especialidades.ForEach(e => 
                {
                    if(e == m.Especialidad)
                    {
                        any = true;
                    }
                });
                if (!any)
                {
                    especialidades.Add(m.Especialidad);
                }
            });
            return especialidades;
        }

    }
}
