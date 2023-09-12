/* 
You're developing a Student Grading application that automates the calculation
of current grades for each student in a class. The parameters for your
application are:

-You're given a short list of four students and their five assignment grades.

-Each assignment grade is expressed as an integer value, 0-100, where 100
represents 100% correct.

-Final scores are calculated as an average of the five assignment scores.

-Your application needs to perform basic math operations to calculate the final
grades for each student.

-Your application needs to output/display each student’s name and final score.

Desired output:
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A

 */
 
 // initialize variables - graded assignments 
int currentAssignments = 5;

int sofia1 = 93;
int sofia2 = 87;
int sofia3 = 98;
int sofia4 = 95;
int sofia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int marta1 = 84;
int marta2 = 96;
int marta3 = 73;
int marta4 = 85;
int marta5 = 79;

int juan1 = 90;
int juan2 = 92;
int juan3 = 98;
int juan4 = 100;
int juan5 = 97;

int totalSofia = sofia1 + sofia2 + sofia3 + sofia4 + sofia5;
int totalNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int totalMarta = marta1 + marta2 + marta3 + marta4 + marta5;
int totalJuan = juan1 + juan2 + juan3 + juan4 + juan5;

decimal promedioSofia = (decimal) totalSofia / currentAssignments;
decimal promedioNicolas = (decimal) totalNicolas / currentAssignments;
decimal promedioMarta = (decimal) totalMarta / currentAssignments;
decimal promedioJuan = (decimal) totalJuan / currentAssignments;

Console.WriteLine("Alumno\t\tNota\n");
Console.WriteLine("Sofia:\t\t" + promedioSofia + "\tA");
Console.WriteLine("Nicolas:\t" + promedioNicolas + "\tB");
Console.WriteLine("Marta:\t\t" + promedioMarta + "\tB");
Console.WriteLine("Juan:\t\t" + promedioJuan + "\tA");