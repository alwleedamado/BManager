﻿using BManager.Models;
using BManager.Persons.Queries;
using BManager.Utils;
using BManager.Utils.Abstractions;

namespace BManager.Data.IRepositories
{
    public interface IPersonRepository : IRepository<Person, PersonFilter>
    {
    }
}
