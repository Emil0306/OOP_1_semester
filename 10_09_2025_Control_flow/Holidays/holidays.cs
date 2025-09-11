int month = 11;

int oct = 10;
int dec = 12;
int apr = 4;
int jul = 7;
int aug = 8;

if (month == oct){
	Console.WriteLine("Autumn Holiday");
} else if (month == dec){
	Console.WriteLine("Christmas Holiday");
} else if (month == apr){
	Console.WriteLine("Spring Holiday");
} else if (month == jul || month == aug) {
	Console.WriteLine("Summer Holiday");
} else {
	Console.WriteLine("Hard work");
}
