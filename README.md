# Algorithms
<b>
Case 1<br/>
Search for Pattern repetition in an array of integers.<br/>
This algorithm identifies the largest pattern, with at least one data repetition.<br/>
Whenever there is more than one pattern that follows this requirement return the first pattern found.<br/>
<br/>
The following table presents some input values and the output expected<br/>
Input (int[])  ..............................................    Output(int[])<br/>
[1, 3, 2, 1, 1, 3, 3, 4, 1, 3, 2 1, 2, 1]  ..................    [1, 3, 2, 1]<br/>
[6, 2, 6, 8, 22, 0, 9, 5, 8, 22, 0, 9, 8, 1, 2, 4, 5, 6, 7]	...  [8, 22, 0, 9]<br/>
[1, 2, 1, 2, 1, 3, 1, 1, 2, 5, 1, 7]  .........................  [1, 2]<br/>
[0, 20, 3, 5, 0, 20, 0, 0, 0, 20, 3, 5, 0, 20, 0, 0, 0]  ......  [0, 20, 3, 5, 0, 20, 0, 0]<br/>
[1, 2, 3]	 ....................................................  []<br/>
[1, 2, 1, 2]	.................................................  [1, 2]<br/>
[1, 2, 1, 2, 1, 2, 1]	 ........................................  [1, 2, 1]<br/>
<br/>
/*************************************************************************************************************/<br/></b>
<br/>
Case 2<br/>
Considering the following file. This file contains numeric values for a given date,time and can also have an optional comment.<br/>
Data is organized in 3 columns and separated by commas.<br/>
Implement an algorithm to read this file and extract its data to a JSON object. The size of the fields "Values" and "Comment" is arbitrary and can be empty or missing.<br/>
Assume the field "Comment" does not have the following characters: "[","]" and ",".<br/><br/>

/*************************************************************************************************************/<br/>
<br/>
I am somewhat satisfied with my resolution of Case 2.<br/>
The algorithm I implemented for Case 1, although it works, I feel it's messy, confusing and probably not optimized.<br/>
I think I could have used List<T> and perhaps regex for pattern searching. But I decided to only use primitives.<br/>
If anyone can make a code review and/or suggestions I highly appreciate. If reviewing algorithm 1, you decide it's better to use C# Objects other than primitives and/or regex<br/>
feel free to also suggest.</br>
<br/>
Thanks<br/>
Ekhidna<br/>
