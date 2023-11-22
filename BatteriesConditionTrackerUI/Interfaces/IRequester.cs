using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerUI.Interfaces
{
    public interface IRequester<T> where T : class
    {
        public void ModelCreated(T model);
        public void ModelUpdated(T model);
    }
}
