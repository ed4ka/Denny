using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OnlineLesson : Lesson
{
    private string platform;

    public string Platform
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

    public OnlineLesson(string title, int duration, int grade, int difficulty, string teacher, string platform) : base(title, duration, grade, difficulty, teacher)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }
}
