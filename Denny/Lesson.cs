﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
public abstract class Lesson
{
    private string title;


    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value.Length < 3 || value.Length > 54)
            {
                throw new ArgumentException("Title should be between 3 and 54 characters!");
            }
            title = value;
        }
    }

    private int duration;

    public int Duration
    {
        get
        {
            return duration;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Duration should be positive!");
            }
        }
    }

    private int grade;

    public int Grade
    {
        get
        {
            return grade;
        }
        set
        {
            if(value < 1 || value > 12)
            {
                throw new ArgumentException("Grade should be between 1 and 12!");
            }
        }
    }

    private int difficulty;

    public int Difficulty
    {
        get
        {
            return difficulty;
        }
        set
        {
            if(value < 1 || value > 3)
            {
                throw new ArgumentException("Difficulty should be between 1 and 3!");
            }
        }
    }

    private string teacher;

    public string Teacher
    {
        get
        {
            return teacher;
        }
        set
        {
            if(value.Length < 3 || value.Length > 54)
            {
                throw new ArgumentException("Teacher should be between 3 and 54 characters!");
            }
        }
    }

    private List<int> ratings;

    public Lesson(string title, int duration, int grade, int difficulty, string teacher)
    {
        Title = title;
        Duration = duration;
        Grade = grade;
        Difficulty = difficulty;
        Teacher = teacher;
        ratings = new List<int>();
    }

    public void AddRating(int rate)
    {
        ratings.Add(rate);
    }
    private int rating;
    public double Rating
    {
        get
        {
            if (ratings.Count > 0)
            {
                return ratings.Average();
            }
            return 0;
        }
    }

    public override string ToString()
    {
        return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5))";
    }
}
