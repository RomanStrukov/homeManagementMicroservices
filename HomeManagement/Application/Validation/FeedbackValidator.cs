using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeManagement.Application.Models;

namespace HomeManagement.Application.Validation
{
    public class FeedbackValidator
    {
        private const int VALID_COMMENT_LENGTH = 100;
        public bool CheckFeedback(UserComment comment)
        {
            return comment.Content.Length <= VALID_COMMENT_LENGTH;
        }
    }
}