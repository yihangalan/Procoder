﻿using System.ComponentModel.DataAnnotations;

namespace ProCoder.Model
{
    public class FollowComment
    {
        //Generated by the system
        [Key]
        public int RecordID { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }
        public bool IsLiked { get; set; }
        public string? Following { get; set; } // follow-up discussion, can be null

    }
}
