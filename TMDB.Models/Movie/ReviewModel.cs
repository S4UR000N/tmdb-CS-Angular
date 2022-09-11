﻿using Common.Models.Audit;


namespace TMDB.Models.Movie
{
    public class ReviewModel : AuditableEntity
    {
        //id
        //page
        //results
        public string Author { get; set; } = string.Empty;
        //author_details - person that written review
        //{
            //public string Name { get; set; } = string.Empty;
            //public string Username { get; set; } = string.Empty;
            //public string AvatarPath { get; set; } = string.Empty;
            //public string Rating { get; set; } = string.Empty;
        //}
        public string Content { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        //total_pages
        //total_results
    }
}
