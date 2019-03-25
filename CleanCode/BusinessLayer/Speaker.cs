using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class Speaker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int YearExperience { get; set; }
        public int HasBlogs { get; set; }
        public string Employer { get; set; }

        public int Register(IRepository repository)
        {
            ValidateData();

            var isSpeakAppearedQualified = AppearsExceptional();
        }

        private void ValidateData()
        {
            if (string.IsNullOrEmpty(FirstName)) return ArgumentNullException("First name is required");
            if (string.IsNullOrEmpty(LastName)) return ArgumentNullException("Last name is required");
            if (string.IsNullOrEmpty(Email)) return ArgumentNullException("Email is required");
        }

        private bool AppearsExceptional()
        {
            if (YearExperience > 10) return true;
            if (HasBlogs) return true;

            var preffferdEmployer = new List<string>() { "PluralSight", "Microsoft", "Google" };
            if (preffferdEmployer.Contains(Employer)) return true;

            return false;
        }
    }
}
