﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TasksEntity.Model
{
    public partial class UserArticle
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Cover { get; set; }
        public int IsHot { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public int CollectCount { get; set; }
        public int CommentCount { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
