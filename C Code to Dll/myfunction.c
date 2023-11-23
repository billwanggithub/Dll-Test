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

struct MyData func_struct(struct MyData myData)
{
	struct MyData _myData;
	
	char header[200] ;
	for (int i = 0; i < 200; i++)
	{
		header[i] = 0;
	}
	_myData.age = myData.age + 10;
	strcat_s(header, sizeof(header), "Name:");
	strcat_s(header,sizeof(header), myData.name);
	strcpy_s(_myData.name,100, header);
	return _myData;
}
