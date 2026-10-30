using CollectionsExercise;

// Try your methods here. Change the values and run the program
// (dotnet run, or Ctrl+F5 in Visual Studio) to see what they return.
// The tests in CollectionsExercise.Tests check every method for you.

List<string> words = ListProblems.LongWords(["a", "train", "is", "late"], 4);
Console.WriteLine(string.Join(", ", words));

Dictionary<string, int> votes = DictionaryProblems.WordCount(["pizza", "tacos", "pizza"]);
foreach (KeyValuePair<string, int> vote in votes)
{
    Console.WriteLine($"{vote.Key}: {vote.Value}");
}
