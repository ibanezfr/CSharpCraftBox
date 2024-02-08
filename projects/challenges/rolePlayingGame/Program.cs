/*
   Rules for the game:
      ._You must use either the 'do-while' statement or the 'while' statement as an
      outer game loop.
      ._The hero and the monster will start with 10 health points.
      ._All attacks will be a value between 1 and 10.
      ._The hero will attack first.
      ._Print the amount of health the monster lost and their remaining health.
      ._If the monster's health is greater than 0, it can attack the hero.
      ._Print the amount of health the hero lost and their remaining health.
      ._Continue this sequence of attacking until either the monster's health
      or hero's health is zero or less.
      ._Print the winner.
*/
Random rnd = new Random();
int hero = 10;
int monster = 10;
string winner;
int attack;

Console.Write("\n");

do
{
  attack = rnd.Next(1, 11);
  monster -= attack;
  Console.Write($"Monster was damaged and lost {attack} health and ");
  Console.WriteLine($"now has {monster} health.");

  if (monster <= 0) continue;

  attack = rnd.Next(1, 11);
  hero -= attack;
  Console.Write($"Hero was damaged and lost {attack} health and ");
  Console.WriteLine($"now has {hero} health.");
}
while (hero > 0 && monster > 0);

winner = hero > monster ? "Hero" : "Monster";

Console.WriteLine($"\n\n\t{winner} wins!\n");

