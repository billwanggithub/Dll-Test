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

	struct MyData
	{
		/* Put data here. */
		char name[100];
		int age;
	};

	// export struct
	DllExport MyData; 

	//export function
	DllExport int  func_add(int a, int b); 
	DllExport int  func_sub(int a, int b);
	DllExport int func_struct_age(struct MyData* myData);
	DLLImport struct MyData* func_struct(struct MyData* myData);

#if defined(__cplusplus)
}
#endif

#endif /*guard*/
