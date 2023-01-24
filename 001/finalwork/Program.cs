// ********************************
// **** Final Work (Developer) ****
// ********************************
/*
 * 1. ✔️Create Git repo
 * 2. 📌Complete the circuit of the algorithm
 * 3. ✔️Add folder «assets» to that repo, add file README.md
 * 4. ✔️Code | result array[] | array[v].length <= 3 :: string; uses arrays
 *      Examples:
 *          input: ["hell", "2", "done", ":D"] output: ["2", ":D"]
 *          input: ["1337", "322", "-2", "computer science"] output: ["322", "-2"]
 *          input: ["Russia", "Indonesia", "Denmark"] output: []
 * 5. ✔️Do this by Git control system and post it to GitHub
 * 6. 💌Generate pdf file of this project
 */
string[] GetArray()
{
    string result = String.Empty;
    string word = String.Empty;
    int counter = 1;
    bool isCorrect = false;

    // User input words
    while (!isCorrect)
    {
        Console.Write($"Type {counter} word: ");
        word = Console.ReadLine();
        counter++;
        result += $"{word},";

        // End loop
        if (word == String.Empty) 
        { 
            isCorrect = true;
            Console.WriteLine();
        } 
    }
    
    // Cut the last symbol from result "," (always be)
    int resultLength = result.Length;

    switch (resultLength)
    {
        case 0:
            break;
        case 1:
            result = result.Remove(resultLength - 1);
            break;
        default:
            // 'Cause -2 when it appears as empty 
            result = result.Remove(resultLength - 2);
            break;
    }
    // Console.WriteLine(result);

    return result.Split(",");
}

void PrintRowNumber(int rowNumber) { Console.Write($"    {rowNumber} | "); }

void PrintArray(string[] array)
{
    int counter = 0;
    int rowNumber = 0;

    for (int i = 0; i < array.Length; i++)
    {
        switch (counter)
        {
            case 0:
                rowNumber++; // go to next row
                PrintRowNumber(rowNumber);
                break;
            case 2:
                Console.WriteLine();
                rowNumber++; // go to next row
                PrintRowNumber(rowNumber);
                counter = 0; // to zero
                break;
            default:
                // do nothing
                break;
        }
        // Print value
        Console.Write($"\"{array[i]}\" ");
        counter++;
    }
    Console.WriteLine(); // space after
}

string[] GetNewArrayWithItemsLengthLessOrEqualThree(string[] array)
{
    string result = String.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result += $"{array[i]},";
        }
    }
    // Cut the last symbol from result "," (always be)
    int resultLength = result.Length;
    
    if (resultLength > 0)
    {
        result = result.Remove(resultLength - 1);
    }
    // Console.WriteLine(result);

    // Array (before)
    Console.WriteLine("::> input:");
    PrintArray(array);

    string[] newArray = result.Split(","); // create array from result

    // Array (after)
    Console.WriteLine(); // space before
    Console.WriteLine("::> output:");
    PrintArray(newArray);
    // Double space after
    Console.WriteLine("-----------\n");

    return newArray;
}

string[] firstArray = new string[4] { "hell", "2", "done", ":D" };
string[] secondArray = new string[4] { "1337", "322", "-2", "computer science" };
string[] thirdArray = new string[3] { "Russia", "Indonesia", "Denmark" };
// GetNewArrayWithItemsLengthLessOrEqualThree(firstArray);
// GetNewArrayWithItemsLengthLessOrEqualThree(secondArray); 
// GetNewArrayWithItemsLengthLessOrEqualThree(thirdArray);
GetNewArrayWithItemsLengthLessOrEqualThree(GetArray());