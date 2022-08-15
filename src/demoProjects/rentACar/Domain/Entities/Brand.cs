using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Car brand
    /// </summary>
    public class Brand : Entity
    {
        public Brand()
        {

        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
        
        /// <summary>
        /// Brand name
        /// </summary>
        public string Name { get; set; }

    }
}
