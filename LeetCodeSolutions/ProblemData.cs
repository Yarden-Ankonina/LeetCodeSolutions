using LeetCodeSolutions.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class ProblemData
    {
        public readonly Dictionary<ProblemData, Action> r_ListOfProblems = new Dictionary<ProblemData, Action>();
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
            ProblemData problem = new ProblemData();
            problem.UpdateProblem("_1480_RunningSum", eProblemTypes.Array);
            r_ListOfProblems.Add(problem, new Action(_1480_RunningSum.Test));
        }
    }
}
