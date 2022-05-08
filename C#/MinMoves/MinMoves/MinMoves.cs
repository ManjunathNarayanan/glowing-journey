//Problem: Read a string of the format 1110101001
//Need to calculate the minimum number of moves so that all 1s are together
int MAX_ARRAY_LENGTH = 200;

int[] ReadInputString()
{
    string? inputStr = string.Empty;
    Console.WriteLine("Please enter the input string:");
    inputStr = Console.ReadLine();
    if (inputStr != null)
    {
        return inputStr.Select(c => c - '0').ToArray();
    }
    else
        return new int[0];
}

int CalculateMinMoves(int[] inputArray)
{
    int oneCnt = 0;
    int length = inputArray.Length;
    
    //Get total number of 1's in the input array
    for (int i = 0; i < length; ++i)
    {
        if (inputArray[i] == 1)
            ++oneCnt;
    }

    int x = oneCnt;
    int maxOnes = 0;

    int[] tempArray = new int[length];
    if (inputArray[0] == 1)
        tempArray[0] = 1;

    //If count is x, then we need to find the subarray of length x of this array with maximum number of 1’s
    for (int i = 1; i < length; ++i)
    {
        if (inputArray[i] == 1)
            tempArray[i] = tempArray[i - 1] + 1;
        else
            tempArray[i] = tempArray[i - 1];
    }

    //Minimum swaps required will be the number of 0’s in the subarray of length x with maximum number of 1’s
    for (int i = x - 1; i < length; ++i)
    {
        if (i == (x - 1))
            oneCnt = tempArray[i];
        else
            oneCnt = tempArray[i] - tempArray[i - x];

        if (maxOnes < oneCnt)
            maxOnes = oneCnt;
    }
    int swapCnt = x - oneCnt;
    return swapCnt;
}

int[] inputArray = new int[MAX_ARRAY_LENGTH];

//Read the string
inputArray = ReadInputString();

//Calcualte the minimum number of moves required so that all X's are together
int minMovesRequired = CalculateMinMoves(inputArray);

Console.WriteLine("Need {0} moves", minMovesRequired);



