using HomeworkArray;

int[] a = ArrayController.GenRandom(20, -100, 100);
ArrayController.WriteArray(a);
ArrayController.WriteArray(ArrayController.SortBubble(a));