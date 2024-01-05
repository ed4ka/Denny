﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class OnlineLesson : Lesson
{
    private string platform;

    public string Platform
    {
        get
        {
            return platform;
        }
        set
        {
            if(value.Length <3 || value.Length > 30)
            {
                throw new ArgumentException("Platform should be between 3 and 30 characters!");
            }
            platform = value;
        }
    }

    public OnlineLesson(string title, int duration, int grade, int difficulty, string teacher, string platform) : base(title, duration, grade, difficulty, teacher, p)
    {
        base.Title = title;
        base.Duration = duration;
        base.Grade = grade;
        base.Difficulty = difficulty;
        base.Teacher = teacher;
        Platform = platform;
    }

    public override string ToString()
    {
        return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5) @ Online: {Platform}";
    }
}
