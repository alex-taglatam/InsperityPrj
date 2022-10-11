# InsperityPrj

Resolution of the required work.

String Manipulation: Sort of String
You are given N strings.
For each string, perform the following sorting operations:
1. Rearrange the alphabets in the string in terms of frequency. i.e. the alphabet having greater frequency comes first.
2. If two or more alphabets have the same frequency, the alphabet which is lexicographically small comes first.

Note
1. The frequency of an alphabet is the number of times an alphabet appears in a string.
Example: Consider the string aabaac; here, the frequency of a is 3, frequency of b is 1, and frequency of c is 1.
2. Lexicographic order is the way of ordering words based on the alphabetical order of English letters i.e. "a" is the smallest letter and "z" is the
largest letter.

Input Format
The first line contains N, denoting the number of strings.

Next N lines contain strings on which sorting operation has to be performed.

Sample Input
2 -- denotes N
abaccadcc -- denotes a string
xyzxy -- denotes a string

Output Format

The output contains N lines containing strings after the sorting operation is performed.

Sample Output
ccccaaabd
xxyyz
