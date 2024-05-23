﻿namespace RepositoryPattern.Repository.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);  
    }
}
