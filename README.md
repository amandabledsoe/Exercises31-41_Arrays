This my solution for Exercises 31-41 for Arrays in the 2022 C# .NET After-Hours Boot Camp at Grand Circus.

# Exercises31-41_Arrays

## EXERCISE 31
### Description
Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user to enter an index. Display the element in the array at that index.

### Example
```
Enter an index of the array: 2
The value at index 2 is 0.
Would you like to continue (y/n)? y
Enter an index of the array: 7
That is not a valid index.
Would you like to continue (y/n)? y
Enter an index of the array: 0
The value at index 0 is 2.
Would you like to continue (y/n)? n
Goodbye!
``` 


## EXERCISE 32
### Description
Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user to enter a number. If the number is in the array, display the index at which it is located.

### Example
```
Enter a number: 12
That value cannot be found in the array.
Would you like to continue (y/n)? y
Enter an index of the array: 24
The value 24 can be found at index 3.
Would you like to continue (y/n)? y
Enter an index of the array: abc
That value cannot be found in the array.
Would you like to continue (y/n)? n
Goodbye!
```

## EXERCISE 33
### Description
Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Let the user change the array by specifying an index and a replacement number.

## Example
```
Enter an index of the array: 2
The value at index 2 is 0.  Would you like to change it (y/n)? y
Enter the new value at index 2: 17
The value at index 2 is 17.  Would you like to continue (y/n)? y
Enter an index of the array: 2
The value at index 2 is 17.  Would you like to change it (y/n)? n
Would you like to continue (y/n)? y
Enter an index of the array: 7
That is not a valid index. Would you like to continue (y/n)? n
Goodbye!
``` 

## EXERCISE 34
### Description
Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256. Prompt the user to enter a command, 'half' or 'double'.  If the user enters 'half', half all the elements in the array.  If the user enters 'double', double all the elements in the array.

### Example
```
Enter a command (half/double): half
>>The array now contains: 8, 16, 32, 64, 128.
Would you like to continue (y/n)? y
Enter a command (half/double): half
The array now contains: 4, 8, 16, 32, 64.
Would you like to continue (y/n)? y
Enter a command (half/double): double
The array now contains: 8, 16, 32, 64, 128.
Would you like to continue (y/n)? n
Goodbye!
```

## EXERCISE 35
### Description
Create an array of size 5 and fill it with the following strings: "cow", "elephant", "jaguar", "horse", "crow". Prompt the user to enter two indices separated by a space.  The first index will specify the word, and the second will specify a letter in that word.  Display the corresponding word and letter.

### Example
```
Enter two indices: 2 0
The value at index 2 is jaguar.  The letter at index 0 is j.
Would you like to continue (y/n)? y
Enter two indices: 4 2
The value at index 4 is crow.  The letter at index 2 is o.
Would you like to continue (y/n)? y
Enter two indices: 0 1
The value at index 0 is cow.  The letter at index 1 is o.
Would you like to continue (y/n)? y
Enter two indices: 7 0
>>Those are not valid indices.
Would you like to continue (y/n)? y
Enter two indices: 2 17
Those are not valid indices.
Would you like to continue (y/n)? n
Goodbye!
```

## EXERCISE 36
### Description
Create two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. Fill the second array with the strings: "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking". Combine both arrays to display a piece of the holiday song.

### Example
```
Enter a command (sing/quit): sing
12 Drummers Drumming
11 Pipers Piping
10 Lords a-Leaping
9 Ladies Dancing
8 Maids a-Milking
Enter a command (sing/quit): quit
Goodbye!
```


## EXERCISE 37
### Description
Prompt the user to enter five numbers.  Store these numbers in an array and output their sum.

### Example
```
Enter a number: 7
Enter a number: 12
Enter a number: 45
Enter a number: 29
Enter a number: 12
7 + 12 + 45 + 29 + 12 = 105
Would you like to continue (y/n)? <<y
Enter a number: 11
Enter a number: 78
Enter a number: 5
Enter a number: 0
Enter a number: 30
11 + 78 + 5 + 0 + 30 = 124
Would you like to continue (y/n)? <<n
Goodbye!
```

## EXERCISE 38
### Description
Prompt the user to enter five numbers.  Store these numbers in an array and output their average.

### Example
```
Enter a number: 7
Enter a number: 12
Enter a number: 45
Enter a number: 29
Enter a number: 12
(7 + 12 + 45 + 29 + 12)/5 = 21
Would you like to continue (y/n)? y
Enter a number: 11
Enter a number: 78
Enter a number: 5
Enter a number: 0
Enter a number: 30
(11 + 78 + 5 + 0 + 30)/5 = 24.8
Would you like to continue (y/n)? n
Goodbye!
```

## EXERCISE 39
### Description
Prompt the user to enter five numbers.  Store these numbers in an array and output them in ascending order.

### Example
```
Enter a number: <<7
Enter a number: <<12
Enter a number: <<45
Enter a number: <<29
Enter a number: <<12
7 12 12 29 45
Would you like to continue (y/n)? <<y
Enter a number: 11
Enter a number: 78
Enter a number: 5
Enter a number: 0
Enter a number: 30
0 5 11 30 78
Would you like to continue (y/n)? <<n
>>Goodbye!
```

## EXERCISE 40
### Description
Prompt the user to enter five numbers.  Store these numbers in an array and output the median.

### Example
```
Enter a number: 7
Enter a number: 12
Enter a number: 45
Enter a number: 29
Enter a number: 12
The median of (7, 12, 12, 29, 45) is 12.
Would you like to continue (y/n)? <<y
Enter a number: 11
Enter a number: 78
Enter a number: 5
Enter a number: 0
Enter a number: 30
The median of (0, 5, 11, 30, 78) is 11.
Would you like to continue (y/n)? n
Goodbye!
```


## EXERCISE 41
### Description
Prompt the user to enter two numbers.  Divide the two numbers and show only two decimal places.

### Example
```
Enter a number: 1
Enter another number: 8
1/8 is approximately .13.
Would you like to continue (y/n)? y
Enter a number: 7
Enter another number: 3
7/3 is approximately 2.33
Would you like to continue (y/n)? y
Enter a number: 5
Enter another number: 0
You cannot divide by 0.
Would you like to continue (y/n)? n
Goodbye!
```
