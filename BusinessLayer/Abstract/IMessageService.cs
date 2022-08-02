using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
    }
}
