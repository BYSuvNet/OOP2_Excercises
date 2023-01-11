# Hint 2 - Explanations

* The private items array is where the stack items will be stored. You'll need to resize this array as items are added and removed from the stack.

* The count variable keeps track of how many items are currently in the stack, as it is not the same as the length of the array.

* In the constructor, you should initialize the items array to have a reasonable initial capacity (e.g., 10) and the count variable to 0.

* The Push method should add the given item to the top of the stack (i.e., at the index equal to the current count) and update count. If the array is full you will need to resize the array by creating a new array with larger capacity and copying the items from the old array to the new array.

* The Pop method should return the item at the top of the stack (i.e., the item at the index equal to count-1) and decrement the count. If the array is less than 1/4 full after the item is removed, you can shrink the array capacity by creating a new array with smaller capacity and copying the items.

* The Peek method should return the item at the top of the stack without removing it.

* The Count method or property should return the current count of items in the stack.

* You will also need to ensure that each methods have proper error handling. For example Pop method should check if the stack is empty before removing an item.
