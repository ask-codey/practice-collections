using CollectionsPractice;

namespace CollectionsPractice.Tests;

// Each test calls one of your methods and checks what it returns.
// You don't need to change this file.

[TestClass]
public class ListProblemsTests
{
    [TestMethod]
    public void ArrayToList()
    {
        List<string> actual = ListProblems.ArrayToList(["Ana", "Raj", "Lee"]);

        CollectionAssert.AreEqual(new List<string> { "Ana", "Raj", "Lee" }, actual, "The list holds the array's items, in order.");
    }

    [TestMethod]
    public void ListToArray()
    {
        string[] actual = ListProblems.ListToArray(["milk", "eggs"]);

        CollectionAssert.AreEqual(new[] { "milk", "eggs" }, actual, "The array holds the list's items, in order.");
    }

    [TestMethod]
    public void LongWords()
    {
        List<string> words = ["a", "train", "is", "late"];

        CollectionAssert.AreEqual(new List<string> { "train", "late" }, ListProblems.LongWords(words, 4), "Words of 4 letters or more, in order.");
        Assert.HasCount(0, ListProblems.LongWords(["go", "team"], 5), "No word has 5 letters.");
        Assert.HasCount(4, words, "The list you were given is unchanged.");
    }

    [TestMethod]
    [DataRow(new[] { 21, 7, 35, 14 }, 35)]
    [DataRow(new[] { -5, -2, -9 }, -2)]
    [DataRow(new[] { 4 }, 4)]
    public void Largest(int[] numbers, int expected)
    {
        Assert.AreEqual(expected, ListProblems.Largest(new List<int>(numbers)), $"The largest of [{string.Join(", ", numbers)}] is {expected}.");
    }

    [TestMethod]
    public void OddOnly()
    {
        CollectionAssert.AreEqual(new List<int> { 1, 3, 5 }, ListProblems.OddOnly([1, 2, 3, 4, 5]));
        Assert.HasCount(0, ListProblems.OddOnly([2, 4]), "There are no odd numbers in [2, 4].");
    }

    [TestMethod]
    [DataRow(new[] { 3, 7, 3, 9 }, 3, true)]
    [DataRow(new[] { 3, 7, 9 }, 3, false)]
    [DataRow(new[] { 5, 5, 5 }, 5, true)]
    [DataRow(new int[0], 3, false)]
    public void AppearsTwice(int[] numbers, int number, bool expected)
    {
        Assert.AreEqual(expected, ListProblems.AppearsTwice(new List<int>(numbers), number), $"{number} in [{string.Join(", ", numbers)}] twice or more: {expected}.");
    }

    [TestMethod]
    public void FizzBuzz()
    {
        CollectionAssert.AreEqual(new List<string> { "1", "2", "Fizz", "4", "Buzz" }, ListProblems.FizzBuzz(5));

        List<string> fifteen = ListProblems.FizzBuzz(15);
        Assert.HasCount(15, fifteen);
        Assert.AreEqual("FizzBuzz", fifteen[14], "15 is a multiple of 3 and 5.");
        Assert.AreEqual("Fizz", fifteen[8], "9 is a multiple of 3.");
        Assert.AreEqual("Buzz", fifteen[9], "10 is a multiple of 5.");
    }
}

[TestClass]
public class DictionaryProblemsTests
{
    [TestMethod]
    [DataRow("Georgia", "Bulldogs")]
    [DataRow("ohio state", "Buckeyes")]
    [DataRow("CLEMSON", "Tigers")]
    [DataRow("Rice", "unknown")]
    public void Mascot(string school, string expected)
    {
        Assert.AreEqual(expected, DictionaryProblems.Mascot(school));
    }

    [TestMethod]
    public void WordCount()
    {
        Dictionary<string, int> counts = DictionaryProblems.WordCount(["pizza", "tacos", "pizza", "sushi", "pizza"]);

        Assert.HasCount(3, counts, "There are 3 different words.");
        Assert.AreEqual(3, counts["pizza"]);
        Assert.AreEqual(1, counts["tacos"]);
        Assert.AreEqual(1, counts["sushi"]);
        Assert.HasCount(0, DictionaryProblems.WordCount([]), "No words, no counts.");
    }

    [TestMethod]
    [DataRow(new[] { "coffee", "bagel", "coffee" }, 9.25)]
    [DataRow(new[] { "coffee", "tea" }, 3.50)]
    [DataRow(new string[0], 0.0)]
    public void CartTotal(string[] cart, double expected)
    {
        Dictionary<string, decimal> prices = new Dictionary<string, decimal> { ["coffee"] = 3.50m, ["bagel"] = 2.25m };

        Assert.AreEqual((decimal)expected, DictionaryProblems.CartTotal(prices, new List<string>(cart)), $"[{string.Join(", ", cart)}] costs {expected}.");
    }

    [TestMethod]
    public void CombineStock()
    {
        Dictionary<string, int> first = new Dictionary<string, int> { ["apples"] = 5, ["pears"] = 2 };
        Dictionary<string, int> second = new Dictionary<string, int> { ["apples"] = 3, ["plums"] = 4 };

        Dictionary<string, int> combined = DictionaryProblems.CombineStock(first, second);

        Assert.HasCount(3, combined, "apples, pears and plums.");
        Assert.AreEqual(8, combined["apples"], "5 + 3 apples.");
        Assert.AreEqual(2, combined["pears"]);
        Assert.AreEqual(4, combined["plums"]);
        Assert.AreEqual(5, first["apples"], "The first store's dictionary is unchanged.");
    }

    [TestMethod]
    public void LetterGrades()
    {
        Dictionary<string, int> percentages = new Dictionary<string, int> { ["Ana"] = 93, ["Raj"] = 78, ["Lee"] = 80, ["Kim"] = 59 };

        Dictionary<string, string> grades = DictionaryProblems.LetterGrades(percentages);

        Assert.AreEqual("A", grades["Ana"]);
        Assert.AreEqual("C", grades["Raj"]);
        Assert.AreEqual("B", grades["Lee"], "80 is a B.");
        Assert.AreEqual("F", grades["Kim"]);
    }

    [TestMethod]
    public void MostWins()
    {
        Assert.AreEqual("Georgia", DictionaryProblems.MostWins(new Dictionary<string, int> { ["Georgia"] = 12, ["Alabama"] = 10, ["Ohio State"] = 11 }));
        Assert.AreEqual("Clemson", DictionaryProblems.MostWins(new Dictionary<string, int> { ["Georgia"] = 2, ["Clemson"] = 9 }));
    }

    [TestMethod]
    public void FirstLetters()
    {
        Dictionary<char, int> counts = DictionaryProblems.FirstLetters(["Apple", "avocado", "banana"]);

        Assert.HasCount(2, counts);
        Assert.AreEqual(2, counts['a'], "Apple and avocado both start with a.");
        Assert.AreEqual(1, counts['b']);
    }
}
