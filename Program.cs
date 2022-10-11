#region Task 1 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("input values:");
//for (int i = 0; i < n; i++)
//{
//	arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void Min(int[] array)
//{
//	int min = array[0];
//	for (int i = 1; i < array.Length; i++)
//	{
//		if (min > arr[i])
//		{
//			min = arr[i];
//		}
//	}
//	Console.WriteLine(min);
//}
//Min(arr);

#endregion

#region Task 2 - Arrays
//Console.WriteLine("Define size of array");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("input values:");
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void Max(int[] array)
//{
//    int max = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (max < arr[i])
//        {
//            max = arr[i];
//        }
//    }
//    Console.WriteLine(max);
//}
//Max(arr);

#endregion

#region Task 3 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//for (int i = 0; i < n; i++)
//{
//	arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void minIndex(int[] array)
//{
//	int min = array[0];
//	int minIndex = 0;
//	for (int i = 1; i < array.Length; i++)
//	{
//		if (min > arr[i])
//		{
//			min = arr[i];
//			minIndex = i;
//		}
//	}
//	Console.WriteLine(minIndex);
//}
//minIndex(arr);
#endregion

#region Task 4 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void maxIndex(int[] array)
//{
//    int max = array[0];
//    int maxIndex = 0;
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (max < arr[i])
//        {
//            max = arr[i];
//            maxIndex = i;
//        }
//    }
//    Console.WriteLine(maxIndex);
//}
//maxIndex(arr);
#endregion

#region Task 5 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void sumOdd(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += array[i];
//        }
//    }
//    Console.WriteLine(sum);
//}
//sumOdd(arr);

#endregion

#region Task 6 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void reverse(int[] array)
//{
//    int[] reverse = new int[array.Length];
//    for (int i = 0; i < array.Length; i++)
//    {
//        reverse[reverse.Length - 1 - i] = array[i];
//    }

//    for (int i = 0; i < reverse.Length; i++)
//    {
//        Console.WriteLine(reverse[i]);
//    }
//}
//reverse(arr);
#endregion

#region Task 7 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void sumOddValue(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum += array[i];
//        }
//    }
//    Console.WriteLine(sum);
//}
//sumOddValue(arr);
#endregion

#region Task 8 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//static void Split(int[] array)
//{
//    int temp = array.Length / 2;
//    int[] first = new int[array.Length / 2];
//    int[] second = new int[first.Length];
//    for (int i = 0; i < array.Length / 2; i++)
//    {
//        first[i] = array[temp];
//        second[i] = array[i];
//        temp++;
//    }


//    for (int i = 0; i < first.Length; i++)
//    {

//        Console.WriteLine(first[i]);

//    }
//    for (int i = 0; i < second.Length; i++)
//    {

//        Console.WriteLine(second[i]);

//    }
//}
//Split(arr);
#endregion

#region Task 9 - Arrays
//Console.WriteLine("Define size of array:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//Console.WriteLine("Define values:");
//static void bubbleSort(int[] arr)
//{
//    for (int i = 0; i < arr.Length - 1; i++)
//        for (int j = 0; j < arr.Length - i - 1; j++)
//            if (arr[j] > arr[j + 1])
//            {
//                (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
//            }

//    for (int i = 0; i < arr.Length; ++i)
//    {
//        Console.Write(arr[i] + " ");
//    }
//}
//bubbleSort(arr);
#endregion
