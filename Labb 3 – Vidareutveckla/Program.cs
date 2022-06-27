using Labb_3___Vidareutveckla;

var machine = new WarmDrinkMachine();
IWarmDrink drink = machine.MakeDrink();
drink.Consume();