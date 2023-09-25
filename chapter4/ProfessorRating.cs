using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class ProfessorRating
    {
        private string professorName;
        private int professorID;
        private int helpfulnessRating;
        private int easyRating;
        private int clarityRating;
        private double overallAverage;

        public ProfessorRating(string professorName, int professorID, int helpfulnessRating, int easyRating, int clarityRating)
        {
            this.professorName = professorName;
            this.professorID = professorID;
            this.helpfulnessRating = helpfulnessRating;
            this.easyRating = easyRating;
            this.clarityRating = clarityRating;
            this.overallAverage = clarityRating + easyRating + helpfulnessRating / 3;
        }
        public override String ToString()
        {
            return "Professor Name: "+ professorName + "Helpfullness Rating "+ helpfulnessRating + " Overall Average" + overallAverage;
        }
    }
}
