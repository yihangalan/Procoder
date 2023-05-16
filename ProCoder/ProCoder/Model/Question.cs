﻿using System.ComponentModel.DataAnnotations;

namespace ProCoder.Model
{
    public class Question
    {
        //Generated by the system
        [Key]
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        [Required]
        public string QuestionTitle { get; set; }
        public DateTime PostDate { get; set; }

        //Entered by the user
        [Required]
        public string Description { get; set; }
        public string RunMethod { get; set; }
        public string TestCase { get; set; }

        //Tag
        public string Tags { get; set; }

        //Difficult level
        public string Difficulty_level{ get; set; }

        //Optional for users
        public string? SampleSolution { get; set; }
    }
}

