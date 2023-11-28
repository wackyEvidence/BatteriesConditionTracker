using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerUI.Interfaces
{
    public interface IModelListRequester<T>
    {
        public void ModelListUpdated(List<T> modelList);
    }
}
