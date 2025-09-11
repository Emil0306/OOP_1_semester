const sbyte jan = 1;
const sbyte feb = 2;
const sbyte mar = 3;
const sbyte apr = 4;
const sbyte may = 5;
const sbyte jun = 6;
const sbyte jul = 7;
const sbyte aug = 8;
const sbyte sep = 9;
const sbyte oct = 10;
const sbyte nov = 11;
const sbyte dec = 12;

sbyte inputmonth = 3;
switch (inputmonth)
{
case(jan):
	Console.WriteLine("January has 31 days");
	break;
case(feb):
	Console.WriteLine("Febuary has 28 days");
	break;
case(mar):
	Console.WriteLine("March has 31 days");
	break;
case(apr):
	Console.WriteLine("April has 30 days");
	break;
case(may):
	Console.WriteLine("May has 31 days");
	break;
case(jun):
	Console.WriteLine("June has 30 days");
	break;
case(jul):
	Console.WriteLine("July has 31 days");
	break;
case(aug):
	Console.WriteLine("August has 31 days");
	break;
case(sep):
	Console.WriteLine("September has 30 days");
	break;
case(oct):
	Console.WriteLine("October has 31 days");
	break;
case(nov):
	Console.WriteLine("November has 30 days");
	break;
case(dec):
	Console.WriteLine("December has 31 days");
	break;
default:
	Console.WriteLine("I don't understand");
	break;
}
