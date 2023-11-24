#include <stdio.h>  
#include <string.h> 
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

int func_simple_struct(SimpleStruct *myData)
{
	// Your function implementation here
	myData->age = 100;
	myData->money = 200;
	return myData->age + myData->money;
}

int func_struct(MyDataStruct *myData)
{
	// just echo
	MyDataStruct *_myData = myData;
	return _myData;
}
