using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LectureLesson : Lesson
{
    private string location;

    public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location) : base(title, duration, grade, difficulty, teacher)
    {
        base.Title = title;
        Location = location;
        base.Duration = duration;
        base.Grade = grade;
        base.Difficulty = difficulty;
        base.Teacher = teacher;
    }

    public string Location
    {
        get
        {
            return location;
        }
        set
        {
            location = value;
        }
    }

    public override string ToString()
    {
        return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5) @ Onsite: {Location}";
    }

}
