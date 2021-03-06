﻿using DemoCore.Domain.Models;

namespace DemoCore.Domain.Interfaces
{
    public interface IKnowledgeDesignerRepository: IRepository<KnowledgeDesigner>
    {
        void RemoveAll(int knowledgeId);
    }
}
