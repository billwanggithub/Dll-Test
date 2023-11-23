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
		char name[100];
		unsigned age;
	};

	// export struct
	DllExport MyData; 

	//export function
	DllExport int  func_add(int a, int b); 
	DllExport int  func_sub(int a, int b);
	DLLImport struct MyData func_struct(struct MyData myData);

#if defined(__cplusplus)
}
#endif

#endif /*guard*/
