using System;

/* Struktur:
   Rum -- klädkammaren -- ut
             \
              \-- brandsläckare -- dödsbrand
                                 \
                                  \-- #winning
*/

string choice = "";

Console.WriteLine("Du sitter framför datorn mitt i ett slafsigt league game som lutar mot en vinst, när du hör brandlarmet börja tjuta");
Console.WriteLine("Du kollar på din dörr, det är en gammal halt avsliten affish där det står \" Glöm ej ljusen!\" ");
Console.WriteLine("Du går fram till dörren och öppnar den, framåt finns klädkammaren, du vet att det finns en brandfilt och en brandsläckare där inne.");
Console.WriteLine("Till höger så kommer du till ytterdörren så du kan gå ut");
Console.WriteLine("Vart går du? Framåt eller höger?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "höger")
{
Console.WriteLine("Du springer ut ur ditt rum åt höger, springer förbi elden till vänster och kubbar rakt ut ur ditt hem");
Console.WriteLine("Du klarade dig, men på vilken bekostnad? Nu blev du av med alla dina ägodelar förutom din telefon som du hade i högerfickan");
Console.WriteLine("Du ringer 112 för att få hit brandkoren, men din telefon dör precis när du kommit fram till operatören");
Console.WriteLine("Du står med din döda mobil i hand och ser ditt hus brinna ner, sakta men säkert.")
}


else if (choice == "framåt")
{
Console.WriteLine("Du går fram till klädkammaren och öppnar dörren, du stiger in och till höger så har du brandsläckaren och brandfilten");
Console.WriteLine("Tänk noggrant nu, tar du brandsläckaren eller brandfilten?");
choice = Console.ReadLine();
choice = choice.ToLower();
}

if (choice == "brandsläckaren")
{
  Console.WriteLine("Du går fram till elden på vänstersidan av korridoren.");
  Console.WriteLine("Du tar bort säkerhets-spärren från brandsläckaren, siktar änden mot elden och klämmer allt vad du kan!");
  Console.WriteLine("Ut kommer en liten sprutt av något som liknar pulvermjölk, du skakar om brandsläckaren och prövar igen");
  Console.WriteLine("Denna gång händer ingenting alls, även fast det kändes som att det fanns tryck kvar i den");
  Console.WriteLine("Ur frustration så kastar du brandsläckaren in i elden, vad är det värsta som kan hända? tänker du");
  Console.WriteLine("Du vänder ryggen för att gå tillbaka till klädkammaren, kanske hinner du hämta brandfilten?");
  Console.WriteLine("BOOM! Låter det bakom dig när brandsläckarens tub exploderar och kastar dig framåt, face first in i vägen");
}

else if (choice == "brandfilten")
{
  Console.WriteLine("Du rycker ut brandfilten ur dess lilla påseliknande förhållare");
  Console.WriteLine("Medans du går fram mot elden så väcklar du ut brandfilten, den är större än vad du tänkte dig.");
  Console.WriteLine("Du tar sats och sedan kastar brandfilten över elden, WOOSH! låter det när den håller på att landa");
  Console.WriteLine("Efter några sekunder av att kolla på elden under brandfilten så kommer du på att det kanske inte är tillräckligt!");
  Console.WriteLine("Du går till klädkammaren fort och hämtar brandsläckaren, ifall att brandfilten inte fungerar");
  Console.WriteLine("Du tar bort säkerhets-spärren från brandsläckaren, siktar änden mot kanten av brandfilten där det fortfarande brinner lite och klämmer allt vad du kan.");
  Console.WriteLine("Absolut ingenting händer när du trycker på avtryckaren, tack och lov att jag tog brandfilten först tänker du. Jag sa ju åt pappa att byta ut brandsläckaren för flera månader sen!");
  Console.WriteLine("Allt ser ut att gå bra vid elden så du tar upp din telefon, 2% står det att du har. Fort så kopplar du in telefonen till en laddare i köket och ringer 112");
  Console.WriteLine("Du kommer fram till operatören och förklarar situationen, operatören frågar dig sedan varför du ringer de när du redan löst problemet med en arg ton.s")

}

Console.WriteLine("Tryck valfri tangent för att avsluta");
Console.ReadLine(); 