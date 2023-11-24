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

StructWithPointer* func_struct_pointer(StructWithPointer* data1, char* lastName)
{
	// Allocate memory for data2
	StructWithPointer* data2 = (StructWithPointer*)malloc(sizeof(StructWithPointer));

	// Check if the allocation was successful
	if (data2 != NULL)
	{
		// Copy the values from data1 to data2
		data2->age = data1->age + 10;
		// Assign data1->name to data2->name
		data2->name = "Bill Wang";

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

char* concatenateStrings(char* str1, char* str2) {
	// Allocate memory for the result string
	char* result = (char*)malloc(strlen(str1) + strlen(str2) + 1);

	// Check if memory allocation was successful
	if (result != NULL) {
		// Copy the first string into the result
		strcpy_s(result, sizeof(result), str1);

		// Concatenate the second string to the result
		strcat_s(result, sizeof(result), str2);

		// Return the concatenated string
		return result;
	}
	else {
		// Handle the case where memory allocation failed
		return NULL;
	}
}
