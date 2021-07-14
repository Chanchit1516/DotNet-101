using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_101.Core.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        Task CompleteAsync();
    }
}
