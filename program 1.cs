using System;
using System.Collections;
 
public class SamplesArrayList  {
 
   public static void Main()  {
 
      ArrayList myAL = new ArrayList();
 
      myAL.Add("Hello");
      myAL.Add(new Emp {EmpID = 101, EmpName = "Vijay" }); 
      myAL.Add(new Cat {Age = 2, Name = "Dicky" });
 
      PrintValues( myAL );
   }
 
   public static void PrintValues( IEnumerable myList )  {
       /*
      foreach ( Object obj in myList )
         Console.Write( "   {0}", ((obj.GetType)obj).EmpName );    
      Console.WriteLine();
      */
 
     
      foreach ( Object obj in myList )
       {
         Console.WriteLine("Printing Type: " + obj.GetType().ToString());
         switch(obj.GetType().ToString())
           {
              case "System.String":
              Console.WriteLine( "   {0}", obj);
              break;
              case "Emp":
              Console.WriteLine( "   {0}", ((Emp)obj).EmpName );
              break;
              default:
              Console.WriteLine("Unrecognized" );
              break;
           }
       }
   }
 
}
 
class Emp
{
    public int EmpID {get; set;}
    public String EmpName {get; set;}
}
public class Cat
{
    public int Age { get; set; }
    public string Name { get; set; }
}
    



    
