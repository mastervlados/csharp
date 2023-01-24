// ********************************
// **** Final Work (Developer) ****
// ********************************
/*
 * 1. ✔️Create Git repo
 * 2. Complete the circuit of the algorithm
 * 3. ✔️Add folder «assets» to that repo, add file README.md
 * 4. Code | result array[] | array[v].length <= 3 :: string; uses arrays
 *      Examples:
 *          input: ["hell", "2", "done", ":D"] output: ["2", ":D"]
 *          input: ["1337", "322", "-2", "computer science"] output: ["322", "-2"]
 *          input: ["Russia", "Indonesia", "Denmark"] output: []
 * 5. ✔️Do this by Git control system and post it to GitHub
 * 6. Generate pdf file of this project
 */

void PrintArray(string[] array)
{
    int counter = 0;
    int rowNumber = 0;

    // Method
    void PrintRowNumber(int rowNumber) { Console.Write($"    {rowNumber} | "); }

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
    // Array (before)
    PrintArray(array);

    string[] newArray = new string[1];

    // Array (after)
    Console.WriteLine();
    PrintArray(newArray);

    return newArray;
}

string[] testArray = new string[4] { "hell", "2", "done", ":D" };
GetNewArrayWithItemsLengthLessOrEqualThree(testArray);