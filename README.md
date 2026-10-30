# Exercise: Collections

Exercise code for the lesson **Exercise: Collections** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

Fourteen problems with lists and dictionaries, in two classes in the `CollectionsExercise` project:

- `ListProblems.cs`: converting, filtering and searching `List<T>`s
- `DictionaryProblems.cs`: looking up, counting and combining with `Dictionary<TKey, TValue>`

Every method returns an empty collection or a wrong value for now. The comment above each method says what it should return, with examples. Replace the `return` line with your own code.

## Run it

```bash
dotnet run --project CollectionsExercise
```

In Visual Studio, open `CollectionsExercise.slnx` and press **Ctrl+F5**.

## Check your work

```bash
dotnet test
```

In Visual Studio, use **Test > Run All Tests**. At first almost every test fails: that is expected.

## Tips

- To build a new list, start with `new List<T>()` and `Add` to it in a loop.
- Before reading a dictionary key, check it with `ContainsKey`, or use `TryGetValue`.
- To count things, use the thing as the key and its count as the value.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
