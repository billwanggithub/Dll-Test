#ifndef MYFUNCTION_H
#define MYFUNCTION_H

#define DllExport   __declspec( dllexport )
#define DLLImport __declspec(dllimport)


#if defined(__cplusplus)
extern "C" {
#endif


	struct MyData
	{
		/* Put data here. */
		char* name;
		unsigned age;
	};

	// export struct
	DllExport struct MyData myData; 

	//export function
	DllExport int  func_add(int a, int b); 
	DllExport int  func_sub(int a, int b);

#if defined(__cplusplus)
}
#endif

#endif /*guard*/
