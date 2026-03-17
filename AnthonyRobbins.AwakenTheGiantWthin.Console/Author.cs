using System;
using System.Collections.Generic;
using System.Text;


namespace AnthonyRobbins.AwakenTheGiantWthin.Console
{
    public class Author
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    System.Console.WriteLine("Unos je prazan.");
                    name = "Unknown";
                }
                else
                {
                    string filteredValue = value.Trim();

                    if (filteredValue.Length < 3)
                    {
                        System.Console.WriteLine("Please enter more than 2 characters.");
                        name = "Unknown";
                    }
                    else
                    {
                        name = filteredValue.Substring(0, 1).ToUpper() + filteredValue.Substring(1).ToLower();
                    }

                }

            }
        }
        private string biography;

        public string Biography
        {
            get
            {
                return biography;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    biography = "Biografija nije uneta";
                }
                else
                {
                    biography = value.Trim();
                }
            }
        }
        public List<Quote> hisQuotes { get; set; } = new List<Quote>();

        public Author()
        {

        }

        public Author(string name, string biography)
        {
            Name = name;
            Biography = biography;
        }
    }
}
