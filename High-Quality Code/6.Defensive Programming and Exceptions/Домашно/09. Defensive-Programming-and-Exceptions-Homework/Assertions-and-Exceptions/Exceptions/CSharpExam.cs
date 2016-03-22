using System;

public class CSharpExam : Exam
{
    private const int MinScore = 0;
    private const int MaxScore = 100;

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new NullReferenceException("Score can not be negative");
        }

        this.Score = score;
    }

    public int Score { get; private set; }

    public override ExamResult Check()
    {
        if (this.Score < MinScore || this.Score > MaxScore)
        {
            throw new ArgumentException("Score", "Score should be between " + MinScore + " and " + MaxScore);
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
