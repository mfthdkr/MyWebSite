﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager: IExperienceService
    {
        private IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public void Add(Experience entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Experience entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Experience entity)
        {
            throw new NotImplementedException();
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetList();
        }

        public Experience GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
