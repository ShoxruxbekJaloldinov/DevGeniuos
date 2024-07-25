using DevGenious.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGenious.Domain.Entities
{
    public class UserSubject : Auditable
    {
        public long UserId { get; set; }
        public long SubjectId { get; set; }
    }
}
