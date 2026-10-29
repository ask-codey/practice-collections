namespace CollectionsPractice;

public static class DictionaryProblems
{
    /*
     * Return the mascot of a school, using this table:
     *
     * Georgia      Bulldogs
     * Alabama      Crimson Tide
     * Ohio State   Buckeyes
     * Michigan     Wolverines
     * Clemson      Tigers
     *
     * Capital letters in the school's name don't matter.
     * For any other school, return "unknown".
     *
     * Mascot("Georgia") -> "Bulldogs"
     * Mascot("ohio state") -> "Buckeyes"
     * Mascot("Rice") -> "unknown"
     */
    public static string Mascot(string school)
    {
        return "";
    }

    /*
     * Count how many times each word appears.
     *
     * WordCount(["pizza", "tacos", "pizza"]) -> { "pizza": 2, "tacos": 1 }
     * WordCount([]) -> { }
     */
    public static Dictionary<string, int> WordCount(string[] words)
    {
        return new Dictionary<string, int> { ["?"] = 0 };
    }

    /*
     * Return the total price of the items in a cart, using the
     * price list. Items that aren't on the price list are skipped.
     * An item may be in the cart more than once.
     *
     * prices: { "coffee": 3.50, "bagel": 2.25 }
     * CartTotal(prices, ["coffee", "bagel", "coffee"]) -> 9.25
     * CartTotal(prices, ["coffee", "tea"]) -> 3.50
     */
    public static decimal CartTotal(Dictionary<string, decimal> prices, List<string> cart)
    {
        return -1;
    }

    /*
     * Two stores have stock counts for their items. Return one
     * dictionary with every item from both, adding the counts of
     * items that both stores have. Don't change either dictionary
     * you were given.
     *
     * CombineStock({ "apples": 5, "pears": 2 }, { "apples": 3, "plums": 4 })
     *   -> { "apples": 8, "pears": 2, "plums": 4 }
     */
    public static Dictionary<string, int> CombineStock(Dictionary<string, int> firstStore, Dictionary<string, int> secondStore)
    {
        return new Dictionary<string, int>();
    }

    /*
     * Turn each student's percentage into a letter grade:
     * 90 or more "A", 80 or more "B", 70 or more "C",
     * 60 or more "D", otherwise "F".
     *
     * LetterGrades({ "Ana": 93, "Raj": 78 }) -> { "Ana": "A", "Raj": "C" }
     */
    public static Dictionary<string, string> LetterGrades(Dictionary<string, int> percentages)
    {
        return new Dictionary<string, string>();
    }

    /*
     * Return the name of the team with the most wins. No two
     * teams have the same number of wins, and there's at least one.
     *
     * MostWins({ "Georgia": 12, "Alabama": 10, "Ohio State": 11 }) -> "Georgia"
     */
    public static string MostWins(Dictionary<string, int> wins)
    {
        return "";
    }

    /*
     * Count how many words start with each letter, in lowercase.
     * The words are never empty.
     *
     * FirstLetters(["Apple", "avocado", "banana"]) -> { 'a': 2, 'b': 1 }
     */
    public static Dictionary<char, int> FirstLetters(List<string> words)
    {
        return new Dictionary<char, int>();
    }
}
