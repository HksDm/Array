using Array;

int[] a = ArrayController.GenRandom(20, -100, 100);
ArrayController.WriteArray(a);
Console.WriteLine(ArrayController.GetMin(a));