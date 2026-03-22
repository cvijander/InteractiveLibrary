using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Technics
{
    public static class TechnicFactory
    {
        public static Technic HowToMakePermanentChange(Author author)
        {
            Technic technic = new Technic("Kako da ostvarite trajnu promenu", "Tri osnovna koraka za trajnu i pozitivnu promenu u vasem zivotu", author);

            Step korak1 = new Step("Podignite svoje standarde", "Ovo dodati");
            technic.Steps.Add(korak1);

            Step korak2 = new Step("Promenite uverenja koja Vas ogranicavaju", "ovo dodati");
            technic.Steps.Add(korak2);

            Step korak3 = new Step("Promenite svoju strategiju", "Ovo dodati");

            Step podkorakA = new Step("1. Ovladavanje emocionalnim aspektom", "ovo dodati");
            Step podkorakB = new Step("2. Ovladavanje fizickim aspektom", "Ovo dodati");
            Step podkorakC = new Step("3. Ovladavanje aspektom veza", "Ovo dodati");
            Step podkorakD = new Step("4. Ovladavanje aspektom finansija", "Ovo dodati");
            Step podkorakE = new Step("5. Ovladavanje aspektom vremena", "Ovo dodati");

            korak3.SubSteps.Add(podkorakA);
            korak3.SubSteps.Add(podkorakB);
            korak3.SubSteps.Add(podkorakC);
            korak3.SubSteps.Add(podkorakD);
            korak3.SubSteps.Add(podkorakE);


            technic.Steps.Add(korak3);

            return technic;

        }

      
    }
}
