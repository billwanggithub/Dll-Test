#include <stdio.h>  
#include <string.h> 
#include <stdlib.h>
#include "myfunction.h" //  Must to include header
int func_add(int a, int b)
{
	return a + b;
}

int func_sub(int a, int b)
{
	return a - b;
}

int GetIntSize()
{
	int a = 10;
	return sizeof(a);
}

void TestPointer(int* data) {
	// Your implementation here
	// Example: Set the value pointed to by 'data' to 42
	*data = 42;
}

int func_struct_simple(StructSimple *myData)
{
	// Your function implementation here
	myData->age = 100;
	myData->money = 200;
	return myData->age + myData->money;
}

StructWithPointer* func_struct_pointer(StructWithPointer* data1)
{
	// Allocate memory for data2
	StructWithPointer* data2 = (StructWithPointer*)malloc(sizeof(StructWithPointer));

	// Check if the allocation was successful
	if (data2 != NULL)
	{
		// Copy the values from data1 to data2
		data2->age = data1->age + 10;
		data2->name = data1->name;

		// Return the pointer to the allocated memory
		return data2;
	}
	else
	{
		// Handle the case where memory allocation failed
		// For example, you might return NULL or take appropriate action
		return NULL;
	}
}
