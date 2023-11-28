using BatteriesConditionTrackerLib.Models;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Filtering
{
    public static class Filterer
    {
        public static Func<ConcreteBattery, bool> FinalFilter 
        {
            get
            {
                return cb => 
                exploitationStatusPredicate(cb) && 
                replacementStatusPredicate(cb) && 
                brandPredicate(cb) && 
                capacityPredicate(cb) &&
                subsystemPredicate(cb) &&
                structurePredicate(cb);
            }
        }

        private static BatteryExploitationStatus? selectedExploitationStatus;
        private static BatteryReplacementStatus? selectedReplacementStatus;
        private static List<string> selectedBrandNames = new List<string>();
        private static List<double> selectedCapacities = new List<double>();
        private static List<int> selectedSubsystemsId = new List<int>();
        private static List<int> selectedStructuresId = new List<int>();

        private static Func<ConcreteBattery, bool> exploitationStatusPredicate = cb => true;
        private static Func<ConcreteBattery, bool> replacementStatusPredicate = cb => true;
        private static Func<ConcreteBattery, bool> brandPredicate = cb => true;
        private static Func<ConcreteBattery, bool> capacityPredicate = cb => true;
        private static Func<ConcreteBattery, bool> subsystemPredicate = cb => true; 
        private static Func<ConcreteBattery, bool> structurePredicate = cb => true; 
        
        public static void CreateExploitationStatusPredicate(object selectedItem)
        {
            if (selectedItem != null)
            {
                selectedExploitationStatus = (BatteryExploitationStatus)selectedItem;
                exploitationStatusPredicate = cb => cb.ExploitationStatus.Id == selectedExploitationStatus.Id;
            }
            else
            {
                selectedExploitationStatus = null;
                exploitationStatusPredicate = cb => true;
            }
        }

        public static void CreateReplacementStatusPredicate(object selectedItem)
        {
            if(selectedItem != null)
            {
                selectedReplacementStatus = (BatteryReplacementStatus)selectedItem;
                replacementStatusPredicate = cb => cb.ReplacementStatus.Id == selectedReplacementStatus.Id;
            }
            else
            {
                selectedReplacementStatus = null; 
                replacementStatusPredicate = cb => true;
            }
        }

        public static void CreateBrandPredicate(CheckedListBox.CheckedItemCollection checkedBrands)
        {
            if (checkedBrands.Count > 0)
            {
                selectedBrandNames = checkedBrands.Cast<string>().ToList();
                brandPredicate = cb => selectedBrandNames.Contains(cb.Model.Brand);
            }
            else
            {
                selectedBrandNames = new List<string>();
                brandPredicate = (cb) => true;
            }
        }

        public static void CreateCapacityPredicate(CheckedListBox.CheckedItemCollection checkedCapacities)
        {
            if (checkedCapacities.Count > 0)
            {
                selectedCapacities = checkedCapacities.Cast<string>().Select(i => double.Parse(i)).ToList();
                capacityPredicate = cb => selectedCapacities.Contains(cb.Model.Capacity);
            }
            else
            {
                selectedCapacities = new List<double>();
                capacityPredicate = (cb) => true;
            }
        }

        public static void CreateSubsystemPredicate(CheckedListBox.CheckedItemCollection checkedSubsystems)
        {
            if (checkedSubsystems.Count > 0)
            {
                selectedSubsystemsId = checkedSubsystems.Cast<BatterySubsystem>().Select(subsystem => subsystem.Id).ToList();
                subsystemPredicate = cb => selectedSubsystemsId.Contains(cb.Subsystem.Id);
            }
            else
            {
                selectedSubsystemsId = new List<int>();
                subsystemPredicate = (cb) => true;
            }
        }

        public static void CreateStructurePredicate(CheckedListBox.CheckedItemCollection checkedStructures)
        {
            if (checkedStructures.Count > 0)
            {
                selectedStructuresId = checkedStructures.Cast<Structure>().Select(structure => structure.Id).ToList();
                structurePredicate = cb => selectedStructuresId.Contains(cb.InstallationStructure.Id);
            }
            else
            {
                selectedStructuresId = new List<int>();
                structurePredicate = (cb) => true;
            }
        }
    }
}
