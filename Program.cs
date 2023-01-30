int[] arr = new int[] { 9,9,3,1,5,4};


Console.WriteLine("GetSum");
var sum = (from a in arr select a).Sum();
Console.WriteLine(sum);


var kvadrat = (from a in arr select a*a).ToList();
Console.WriteLine("GetSquare");
kvadrat.ForEach(x=>Console.Write(x+" "));


Console.WriteLine("\nGetCube");
var kub = (from a in arr select a*a*a).ToList();
kub.ForEach(x=>Console.Write(x+" "));


Console.WriteLine("\nGetOdd");
var odd = (from a in arr where a%2!=0 select a).ToList();
odd.ForEach(x=>Console.Write(x+" "));


Console.WriteLine("\nGetOddAscending");
var oddascending = (from a in arr  where a%2!=0 orderby a select a).ToList();
oddascending.ForEach(x=>Console.Write(x+" "));


Console.WriteLine("\nGetOddSquare");
var oddsquare = (from a in arr  where a%2!=0 select a*a).ToList();
oddsquare.ForEach(x=>Console.Write(x+" "));


 Console.WriteLine("\nGetAscending3");
 var Top3Ascending = (from a in arr orderby a ascending select a).Distinct().Take(3).ToList();
Top3Ascending.ForEach(x => Console.Write(x+" "));


Console.WriteLine("\nGetAverage");
var Average = (from a in arr select a).Average();
Console.WriteLine(Average+" ");


Console.WriteLine("\nGetDescending3");
var Top3Descending = (from a in arr orderby a descending select a).Distinct().Take(3).Reverse().ToList();
Top3Descending.ForEach(x => Console.Write(x+" "));


Console.WriteLine("\nGetEvenSquare");
var evensquare = (from a in arr  where a%2==0 select a*a).ToList();
evensquare.ForEach(x=>Console.Write(x+" "));


Console.WriteLine("\nGetOddCube");
var oddcube = (from a in arr  where a%2!=0 select a*a*a).ToList();
oddcube.ForEach(x=>Console.Write(x+" "));


// Console.WriteLine("\nGetblizh");
// int n = Convert.ToInt32(Console.ReadLine());
// var blizh = (from a in arr where a-n select a).ToList();
// blizh.ForEach(x=>Console.Write(x+" "));





