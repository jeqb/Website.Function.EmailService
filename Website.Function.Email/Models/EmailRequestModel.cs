﻿namespace Website.Function.Email.Models
{
    public class EmailRequestModel
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string HtmlBody { get; set; }
    }
}
