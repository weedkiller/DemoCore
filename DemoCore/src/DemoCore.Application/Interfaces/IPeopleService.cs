﻿using DemoCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCore.Application.Interfaces
{
    public interface IPeopleService: IDisposable
    {
        void Register(PeopleVM peopleVM);
        IEnumerable<PeopleVM> GetAll();
        PeopleVM GetById(int id);
        void Update(PeopleVM peopleVM);
        void Remove(int id);
        Task<PeopleVM> GetByEmailAsync(string email);
        //IList<PeopleHistoryData> GetAllHistory(Guid id);
    }
}
