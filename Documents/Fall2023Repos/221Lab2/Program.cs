//initializing variables to 0 or 0.0 depending on int or double 
int numberOfPies = 0;
double amountOfToppings = 0.0;
double serviceFee = 0.0;

//initializing the given variables 
double DRIVERS_WAGE = 5.27;
int COST_OF_PIE = 10; 
double COST_OF_TOPPING = .25; 

//display How many pizzas were ordered
Console.WriteLine("How many pizzas did you order:  "); 
int userInput;
userInput = int.Parse(Console.ReadLine()); 
numberOfPies = userInput;

//dislay how many topping were on pizza
Console.WriteLine("How many different toppings did you get on your pizza:  "); 
userInput = int.Parse(Console.ReadLine());
amountOfToppings = userInput;

//display how much tip did you leave
Console.WriteLine("How much tip did you leave:  "); 
userInput = int.Parse(Console.ReadLine());
serviceFee = userInput;

//set the orderCost to the equation to calculate the wage or driver plus tip
double orderCost = DRIVERS_WAGE + serviceFee + (COST_OF_PIE * numberOfPies) + (COST_OF_TOPPING * amountOfToppings); 

//display final order cost 
Console.WriteLine ("Your order cost:$" + orderCost);