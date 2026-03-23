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
            Technic technic = new Technic("Kako da ostvarite trajnu promenu", "Tri osnovna koraka za trajnu i pozitivnu promenu u vasem zivotu \n\n Da bi promene imale istinsku vrednost, moraju da budu trajne i dosledne.\n Svi smo mi na trenutak doziveli promenu koja nas je dovela do toga da se na kraju osetimo izneverenima i razocaranima.\n Mnogi ljudi pokusavaju da se promene uz osecanje straha i uzasa, jer podsvesno znaju da ce promene biti samo privremene.\n Pravi primer za to je neko ko mora da zapocne dijetu, ali neprestano to odlaze, prvenstveno zbog toga sto u podsvesti zna da ce mu svaka patnja koju podnese kako bi ostvario promene donece samo kratkorocnu nagradu.\n\n To su iste one promene koje pojedinac mora da napravi kako bi ostvario licni preobrazaj, \n koje jedna kompanija mora da preuzme da bi maksimalno iskoristila svoj potencijal i koju jedna zemlja mora da preuzme da bi odredila svoje mesto u svetu.", author);

            Step korak1 = new Step("Podignite svoje standarde", "Svaki put kada iskreno zelite nesto da promenite, prvo morate da podignete svoje standarde. \n Najvaznije je bilo to sto sam promenio ono sto sam zahtevao od sebe.\nZapisao sam sve ono sto vise necu da prihvatam u svom zivotu, sve ono sto vise necu da tolerisem i sve sto sam tezio da postanem.\n\n Razmislite o dalekoseznim posledicama kojse su izazvali muskarci i zene kojse podigli svoje standarde i ponasali se u skladu sa njima, odlucivsi da ne pristanu ni na sta manje. \n Istorija belezi inspirativne primere , kao sto su Leonard da Vinci, Abraham Linkoln, Helen Keler, Mahatma Gandi, Martin Luter King, Roza Parks, Albert Ajnstajn i monogi drugi koju su preuzeli izvanredno mocan korak pri podizanju svojih standartda.\n\nIsta moc koja je bila dostupna njima, dostupna je i vama, ukoliko imate HRABROSTI da je izrazite. \n\nPromene u organizaciji, kompaniji, zemlji ili svetu pocinju jednostavnim KORAKOM MENJANJA SEBE.");
            technic.Steps.Add(korak1);

            Step korak2 = new Step("Promenite uverenja koja Vas ogranicavaju", "Ukoliko podignete svoje standarde, ali iskreno ne verujete da mozete da ih postujete, vec ste sabotirali sami sebe. \n\nNasa uverenja su kao nepostavljeni zahtevi,koji nam govore sta je moguce, a sta nemoguce, sta mozemo da ucinimo a sta ne mozemo.\n Ona oblikuju svaki nas postupak, misao i osecaj.\n\n\t Menjanje naseg sistema uverenja od kljucnog je znacaja da bismo proizveli bilo koju stvarnu i trajnu promenu u nasim zivotima.\n Moramo da razvijemo osecaj sigurnosti  da MOZEMO i HOCEMO da se pridrzavamo novih standarda pre no sto zapravo to UCINIMO.\n\n\tBez preuzimanja kontrole nad svojim sistemom uverenja, mozete da podizete svoje standarde koliko god zelite, ali nikada necete posedovati ubedjenje koji biste ih podrzali.\n\n Osnazivanje uverenja - osecaja sigurnosti - sila je koja stoji iza svakog velikog uspeha u istoriji.");
            technic.Steps.Add(korak2);

            Step korak3 = new Step("Promenite svoju strategiju", "Ovo dodati");

            Step podkorakA = new Step("1. Ovladavanje emocionalnim aspektom", "Ovladavanje ovom oblascu priblizice vas tome da ovladate ostlalim cetirima.\n Mislite da cete se drugacije OSECATI kada biste se oslobodili tih nezeljenih kilograma, sto ce vam dati vise energije i vitalnosti, ucinice da se osecate atraktivnijim drugima i podici vase samopouzdanje i samopostovanje do neba? \n\n Prakticno sve sto cinimo je u cilju promene nacina kako se osecamo - iako mali broj nas ima ili uopste nema , iskustva u tome kak o da to ucinimo brzo i efikasno.\n Zapanjujuce je koliko cesto koristimo inteligneciju da bismo se prepustili emocionalnim stanjima koja su beskorisna, zaboravljajuci mnostovo unustrasnjih talenata koje svako od nas ima.\n\nMnogo nas  ostavlja sebe na milost i nemilost spoljasnim dogadjajima nad kojima nemamo kontrolu, ne uspevajuci da rukovodi svojim emocijama - nad kojima samo mi imamo PUNI kontrolu - i umesto toga se oslanjamo na kratkorocne popravke. \n\n Uz ovu knjigu otkricete sta vas podstice da radite to sto cinite, kao i okidace za emocije koje najcesce osecate.\n Zatim ce vam biti dat postupan plan koji ce vma pokazati kako da odredite emocije koja vam daju moc, one koja vam oduzimaju moc i kako da iskoristite obe vrste, tako da ne budu prepreka , vec mocno orudje koj ce vam pomoci da ostvarite svoj potencijal.");
            Step podkorakB = new Step($"2. Ovladavanje fizickim aspektom", "Vredi li kad imate sve o cemu ste oduvek sanjali, ali ne mozete da uzivate u tome jer niste zdravi? Da li se svakog jutra budite osecajuci se energicno , mocno i spremno da  prozivite novi dan? Ili se budite umorni kao i prthodne noci, u bolovima i ozlojedjeni sto sve morate iznove da pocinjete.\nPozajmicu recenicu lekara iz sedamnaestog veka " + BookBase.GetQuoteWithAuthorAsString(BookBase.TomasMafet1) + "dok trpamo u svoja tela masnu hranu, trujemo svoj organizam cigaretama, alkoholom i drogama i pasivno sedimo pred televizorima.\n Ova druga lekcija o ovladavanju pomoci ce vam da preuzmete konstrolu nad svojim fizickim zdravljem , ne samo da bi ste IZGLEDALI dobro, \n vec i da biste se OSECALI dobro i znali da KONTROLISETE svoj zivot, u telu koji odise vitalnoscu.  ");
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
