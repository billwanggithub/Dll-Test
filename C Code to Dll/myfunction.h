#ifndef MYFUNCTION_H
#define MYFUNCTION_H

#define DllExport   __declspec( dllexport )

#if defined(__cplusplus)
extern "C" {
#endif

DllExport int  func_add(int a, int b);
DllExport int  func_sub(int a, int b);

#if defined(__cplusplus)
}
#endif

#endif /*guard*/
