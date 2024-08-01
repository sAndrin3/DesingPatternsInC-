using StrategyPattern;

var items = new[] { 55, 3, 67, 89, 100, 7};

var sortedNumbers = new SortedNumbers(new BubbleSort());
sortedNumbers.Sort(items);

Console.WriteLine("=======================");

sortedNumbers = new SortedNumbers(new QuickSort());
sortedNumbers.Sort(items);