using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fapp.Model
{
    public interface IListContainerService
    {
        Task<IEnumerable<Container>> GetItemsAsync();
    }
}
