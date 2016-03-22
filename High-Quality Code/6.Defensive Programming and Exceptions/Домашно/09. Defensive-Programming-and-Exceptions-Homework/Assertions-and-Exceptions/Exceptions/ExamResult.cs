using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get { return this.grade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade can not be negative.");
            }

            value = this.grade;
        }
    }

    public int MinGrade
    {
        get { return this.minGrade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Min Grade can not be negative.");
            }

            value = this.minGrade;
        }
    }

    public int MaxGrade
    {
        get { return this.maxGrade; }
        private set
        {
            if (value <= this.minGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade should be bigger than min grade");
            }

            value = this.maxGrade;
        }
    }

    public string Comments
    {
        get { return this.comments; }
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Comments can not be empty.");
            }

            value = this.comments;
        }
    }
}
