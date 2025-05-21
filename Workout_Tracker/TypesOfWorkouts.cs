using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker
{
    class TypesOfWorkouts : ObservableCollection<string>
    {
        public TypesOfWorkouts()
        {
            Add("Cardio");
            Add("Weight Training");
            Add("Stretching");

        }
    }
}
