using system;

class progrram
{
  static void main(string[]args)
    {
       console.write("what is your grade percentage?");
       string answer = console.ReadLine();
       int percent =int.parse(answer);

       string letter ="";
  
       if (percent >= 90)
       {
         letter = "A";
       }
       else if (percent >= 80)
       {
          letter = "B";
       }
       else if (percent >= 70)
       {
          letter ="C";
       }
       else if (percent >= 60)
       {
          letter = "D";
       }
       else
       {
          letter = "F";
       }
         console.writeline($"your grade is :{letter}");
           
            if (percent >= 70)
            {
               console.writeline("you passed");
            }
            else
            {
               console.writeline("Better luck next time");
            }
      }
}
          