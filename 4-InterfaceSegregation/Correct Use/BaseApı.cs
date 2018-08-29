using System;
using System.Collections.Generic;
using System.Text;

namespace _4_InterfaceSegregation.Correct_Use
{
    interface IGet
    {
        void Get(int id);
    }
    interface IBaseApi : IGet
    {
        void Put(int id);
        void Post(int id);
        void Delete(int id);
    }

    public class News : IBaseApi
    {
        public void Put(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Video : IBaseApi
    {
        public void Put(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Notification : IGet
    {
        public void Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
