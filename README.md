# Practice: Random Numbers

## Instructions

1. Use the following code to create a list of random numbers. Each number will be between 0 and 5.

   ```cs
   Random random = new Random();
   List<int> numbers = new List<int> {
       random.Next(6),
       random.Next(6),
       random.Next(6),
       random.Next(6),
       random.Next(6),
       random.Next(6),
   };
   ```

   ```cs
   for (int i=0; i<numbers.Count; i++) {
      // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

   }
   ```

#### Example Output in the Terminal

```sh
numbers list contains 0
numbers list does not contain 1
numbers list does not contain 2
numbers list contains 3
numbers list contains 4
numbers list does not contains 5
```

**NOTE:** Each run will produce different output.
