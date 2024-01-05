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
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string Location
    {
        get
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
        set
        {
            //TODO: Implement me...
            throw new NotImplementedException();
        }
    }

    public override string ToString()
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

}
