using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class File : BaseEntity
    {
        [NotMapped]
        public override DateTime UpdateDate { get => base.UpdateDate; set => base.UpdateDate = value; }
    }
}
