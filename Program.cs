// See https://aka.ms/new-console-template for more information
while (true) 
{
    Console.WriteLine("Please enter a temperature value and its unit of measurement, e.g: 100 F or 30 C");
    var userInput = Console.ReadLine();
    if (userInput == "" || userInput == null)
    {
        Console.WriteLine("Invalid input. Please enter a valid temperature value and its unit of measurement, e.g: 100 F or 30 C");
        userInput = Console.ReadLine();
    }
    else if (userInput.ToLower() == "exit") 
    {
        Console.WriteLine("Program terminated");
        return;
    }
    else
    {
        var inputArray = userInput.Split(" ");
        if (inputArray.Length != 2 || !float.TryParse(inputArray[0], out float input))
        {
            Console.WriteLine("Invalid input. Please enter a valid temperature value and its unit of measurement, e.g: 100 F or 30 C");
        }
        else 
        {
            var inputNum = float.Parse(inputArray[0]);
            var inputUnit = inputArray[1].ToUpper();
            float result;
            switch (inputUnit)
            {
                case "C":
                result = TempConvert(inputNum, inputUnit);
                Console.WriteLine(userInput + " = " + result + " F");
                break;
                case "F":
                result = TempConvert(inputNum, inputUnit);
                Console.WriteLine(userInput + " = " + result + " C");
                break;
                default:
                Console.WriteLine("invalid input");
                break;
            }
        }
    }
}

static float TempConvert(float input, string unit)
{
    float scale;
    switch (unit)
    {
        case "C":
        scale = input * 9 / 5 + 32;
        return (float) Math.Round(scale, 2);
        // break;
        case "F":
        scale = (input - 32) * 5 / 9;
        return (float) Math.Round(scale, 2);
        // break;
        default:
        Console.WriteLine("Invalid input");
        return 0;
        // break;
    }
}