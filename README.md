# Counting Sort

Counting sort is an integer sorting algorithm that works by counting the frequency of each unique element in the unsorted list, and using that information to place each element in its correct position in the sorted output. 

Unlike other comparison-based sorting algorithms, counting sort does not make any comparisons between elements, making it highly efficient for small integers or for lists where the elements have a small range. 

Instead, it uses the counts as indices to place each element in the correct position in the output list. 

The time complexity of counting sort is O(n + k), where n is the number of elements in the list and k is the range of the elements (i.e., the difference between the maximum and minimum elements). 

Counting sort is an efficient and stable sorting algorithm for lists where the elements have a small range and can be used as a subroutine in more complex sorting algorithms.