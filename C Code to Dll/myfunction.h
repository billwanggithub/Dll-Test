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

	typedef struct StructSimple StructSimple;
	struct StructSimple
	{
		int money;
		int age;
	};

	typedef struct StructWithPointer StructWithPointer;
	struct StructWithPointer
	{
		char *name;
		int age;
	};

	// export struct
	//DllExport MyData; 

	//export function
	DllExport int  func_add(int a, int b); 
	DllExport int  func_sub(int a, int b);
	DllExport int GetIntSize();
	DllExport void TestPointer(int* data);
	DllExport int func_struct_simple(StructSimple* myData);
	DllExport StructWithPointer* func_struct_pointer(StructWithPointer* data1, char* lastName);

	char* concatenateStrings(char* str1, char* str2);

#if defined(__cplusplus)
}
#endif

#endif /*guard*/
