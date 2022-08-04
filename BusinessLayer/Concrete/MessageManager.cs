using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager: IMessageService
    {
        private IMesssageDal _messsageDal;

        public MessageManager(IMesssageDal messsageDal)
        {
            _messsageDal = messsageDal;
        }
        public void Add(Message entity)
        {
            _messsageDal.Insert(entity);
        }

        public void Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
