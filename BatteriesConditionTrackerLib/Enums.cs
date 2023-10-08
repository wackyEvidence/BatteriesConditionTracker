using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib
{
    internal class Enums
    {
        public enum ExploitationStatus
        {
            Exploitated, 
            NotExploitated, 
            None
        }

        public enum ReplacementStatus
        {
            NeedsReplacement, 
            DoesntNeedReplacement, 
            Replaced 
        }
    }
}
