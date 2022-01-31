﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
     {
         IAuthorDal _authordal;
        Repository<Author> repoauthor = new Repository<Author>();

        public AuthorManager(IAuthorDal authordal)
        {
            _authordal = authordal;
        }
        public List<Author> GetList()
        {
            return  _authordal.List();
        }

        public void TAdd(Author t)
        {
            _authordal.Insert(t);
        }
        public Author GetByID(int id)
        {
            return _authordal.GetByID(id);
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            _authordal.Update(t);
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }
    }
}


