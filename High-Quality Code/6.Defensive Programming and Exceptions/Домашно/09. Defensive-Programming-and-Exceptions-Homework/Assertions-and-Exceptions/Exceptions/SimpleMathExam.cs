using System;

public class SimpleMathExam : Exam
{
    private const int MinSolvedProblems = 0;
    private const int MaxSolvedProblems = 10;
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            if (value < MinSolvedProblems)
            {
                throw new ArgumentOutOfRangeException("Problems solved must be higher than " + MinSolvedProblems);
            }

            if (value > MaxSolvedProblems)
            {
                throw new ArgumentOutOfRangeException("Problems solved must be smaller than " + MaxSolvedProblems);
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        switch (ProblemsSolved)
        {
            case 0:
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            case 1:
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            case 2:
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            default:
                return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}
