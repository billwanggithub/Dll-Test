#ifndef MYFUNCTION_H
#define MYFUNCTION_H

//#define DEBUG
#ifdef DEBUG 
#define DllExport  
#define DLLImport 
#else
#define DllExport   __declspec( dllexport )
#define DLLImport __declspec(dllimport)
#endif // DEBUG

#if defined(__cplusplus)
extern "C" {
#endif

	typedef struct SimpleStruct SimpleStruct;
	struct SimpleStruct
	{
		int money;
		int age;
	};
	typedef struct MydataStruct MyDataStruct;
	struct MyDataStruct
	{
		char name[100];
		int age;
	};

	// export struct
	//DllExport MyData; 

	//export function
	DllExport int  func_add(int a, int b); 
	DllExport int  func_sub(int a, int b);
	DllExport int GetIntSize();
	DllExport void TestPointer(int* data);
	DllExport int func_struct(MyDataStruct* myData);
	DllExport int func_simple_struct(SimpleStruct* myData);

#if defined(__cplusplus)
}
#endif

#endif /*guard*/
