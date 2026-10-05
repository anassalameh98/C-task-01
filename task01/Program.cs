using System.Diagnostics.Metrics;

double productPrice =0;
int productQuantity =0;
double total =0;
string counter="0";
double allTotal = 0;

do{
Console.WriteLine("enter the product price");
productPrice=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the product quantity");
productQuantity=Convert.ToInt32(Console.ReadLine());
total=productPrice*productQuantity;
Console.WriteLine($"the total is {total}");
Console.WriteLine("enter 1 to add another product or 0 to finish");
counter=Console.ReadLine();
allTotal=allTotal+total;
}
while(counter=="1");

Console.WriteLine($"the total of all products is {allTotal}");