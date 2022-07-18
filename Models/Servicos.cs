using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jauto.Models
{
    public class Servicos
    {

        public Servicos()
        {
            ListaOficinas = new HashSet<Oficinas>();
        }

        //##################################################################################

        /// <summary>
        /// Identificador do Serviço
        /// </summary>
        [Key]
        public int IdServ { get; set; }
        
        /// <summary>
        /// Tipo de Serviço
        /// </summary>
        public String Servico { get; set; }

        //##################################################################################

        /// <summary>
        /// Lista de Oficinas
        /// </summary>
        public ICollection<Oficinas> ListaOficinas { get; set; }

    }
}
