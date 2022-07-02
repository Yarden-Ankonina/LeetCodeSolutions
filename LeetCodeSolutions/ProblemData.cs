using LeetCodeSolutions.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class ProblemData
    {
        public readonly Dictionary<string, Action> r_ListOfProblems = new Dictionary<string, Action>();
        public string ProblemName { get; set; }
        public eProblemTypes ProblemType { get; set; }

        public ProblemData()
        {
            createProblemList();
        }

        public void UpdateProblem(string i_Name, eProblemTypes i_Type)
        {
            ProblemName = i_Name;
            ProblemType = i_Type;
        }

        private void createProblemList()
        {
            ProblemData runningSum = new ProblemData();
            runningSum.UpdateProblem("_1480_RunningSum", eProblemTypes.Array);
            r_ListOfProblems.Add(runningSum.ProblemName, new Action(_1480_RunningSum.Test));
        }
    }
}
