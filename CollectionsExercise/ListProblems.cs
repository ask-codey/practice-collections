namespace CollectionsExercise;

public static class ListProblems
{
    /*
     * Return a List<string> holding the same items as the array,
     * in the same order.
     *
     * ArrayToList(["Ana", "Raj", "Lee"]) -> ["Ana", "Raj", "Lee"]
     */
    public static List<string> ArrayToList(string[] items)
    {
        return new List<string>();
    }

    /*
     * Return an array holding the same items as the list,
     * in the same order.
     *
     * ListToArray(["milk", "eggs"]) -> ["milk", "eggs"]
     */
    public static string[] ListToArray(List<string> items)
    {
        return [];
    }

    /*
     * Return a new list of the words that have at least
     * minimumLength letters, in their original order.
     * Don't change the list you were given.
     *
     * LongWords(["a", "train", "is", "late"], 4) -> ["train", "late"]
     * LongWords(["go", "team"], 5) -> []
     */
    public static List<string> LongWords(List<string> words, int minimumLength)
    {
        return new List<string>();
    }

    /*
     * Return the largest number in the list. The list has
     * at least one number.
     *
     * Largest([21, 7, 35, 14]) -> 35
     * Largest([-5, -2, -9]) -> -2
     */
    public static int Largest(List<int> numbers)
    {
        return int.MinValue;
    }

    /*
     * Return a list of only the odd numbers from the array,
     * in their original order.
     *
     * OddOnly([1, 2, 3, 4, 5]) -> [1, 3, 5]
     * OddOnly([2, 4]) -> []
     */
    public static List<int> OddOnly(int[] numbers)
    {
        return [-1];
    }

    /*
     * Return true if the number appears in the list at least
     * twice, and false otherwise.
     *
     * AppearsTwice([3, 7, 3, 9], 3) -> true
     * AppearsTwice([3, 7, 9], 3) -> false
     * AppearsTwice([], 3) -> false
     */
    public static bool AppearsTwice(List<int> numbers, int number)
    {
        return numbers.Count == 0;
    }

    /*
     * Return a list of the numbers from 1 to count, as text,
     * except: "Fizz" for multiples of 3, "Buzz" for multiples
     * of 5, and "FizzBuzz" for multiples of both.
     *
     * FizzBuzz(5) -> ["1", "2", "Fizz", "4", "Buzz"]
     * FizzBuzz(15)'s last item -> "FizzBuzz"
     */
    public static List<string> FizzBuzz(int count)
    {
        return new List<string>();
    }
}
