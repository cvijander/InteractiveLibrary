using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Technics
{
    public class Step
    {
        public string Title { get; set; }

        public string Story { get; set; }

        public List<string> SubSteps { get; set; }

        public Step()
        {

        }

        public Step(string title, string story)
        {
            Title = title;
            Story = story;

            SubSteps = new List<string>();
        }
    }
}
