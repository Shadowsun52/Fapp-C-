using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fapp.Model
{
    public class FakeListContainerService : IListContainerService
    {
        IEnumerable<Container> _fakeList;
        public FakeListContainerService()
        {
            var fakeList = new List<Container>();
            fakeList.Add(new Container(1, "frigo", new DateTime(2014, 11, 26), 1));
            fakeList.Add(new Container(2, "congel", new DateTime(2014, 11, 25), 2));
            _fakeList = fakeList;
        }

        public async Task<IEnumerable<Container>> GetItemsAsync()
        {
            return await Task.FromResult<IEnumerable<Container>>(_fakeList);
        }
    }
}
