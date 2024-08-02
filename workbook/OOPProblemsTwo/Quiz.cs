using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblemsTwo
{
    internal class Quiz
    {
        private string _studentName;
        private int _total;
        private int _mark;
        private int _weight;

        // Because it MUST be provided when the quiz is created, I care about the GREEDY constructor.

        // Constructor
        /// <summary>
        /// Creates the quiz - requires the total and weight.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="weight"></param>
        public Quiz(int total, int weight)
        {
            _total = total;
            _weight = weight;
        }


        /// <summary>
        /// Sets the mark of the quiz.
        /// </summary>
        /// <param name="mark"></param>
        public void SetMark(int mark)
        {
            _mark = mark;
        }

        /// <summary>
        /// Gets the mark.
        /// </summary>
        /// <returns>The mark as an integer.</returns>
        public int GetMark()
        {
            return _mark;
        }

        /// <summary>
        /// Set the student name for the quiz.
        /// </summary>
        /// <param name="name"></param>
        public void SetStudentName(string name)
        {
            _studentName = name;
        }

        /// <summary>
        /// Gets the student's name.
        /// </summary>
        /// <returns>The name as a string.</returns>
        public string GetStudentName()
        {
            return _studentName;
        }

        /// <summary>
        /// Get the quiz total.
        /// </summary>
        /// <returns>The total as an int.</returns>
        public int GetTotal()
        {
            return _total;
        }

        /// <summary>
        /// Get the quiz weight.
        /// </summary>
        /// <returns>The weight as an int.</returns>
        public int GetWeight()
        {
            return _weight;
        }

        /// <summary>
        /// Gets the percentage of mark earned from the quiz.
        /// </summary>
        /// <returns>An int representing the percent.</returns>
        public int GetPercentage()
        {
            // I'm aware this is interger rounding.
            return (_mark / _total) * 100;
        }

    }
}
