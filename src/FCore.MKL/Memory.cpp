#include <stdlib.h>
#include "malloc.h"
#include <string.h>
#include <mkl_types.h>
#include "mkl.h"

#define OUTOFMEMORY -1

template<typename T>
int create_array(const MKL_INT length, T*& x)
{
	if (x == nullptr)
	{
		x = (T*)malloc(length*sizeof(T));
		if (x == nullptr)
		{
			return OUTOFMEMORY;
		}
	}
	return 0;
}

template<typename T>
void copy_array(const MKL_INT length, const T* x, T* y)
{
	memcpy(y, x, length * sizeof(T));
}

template<typename T>
void fill_array(const T a, const MKL_INT length, T* x)
{
	for (MKL_INT i = 0; i < length; i++)
	{
		x[i] = a;
	}
}

extern "C" __declspec(dllexport) void free_array(void* x)
{
	free(x);
}

extern "C" __declspec(dllexport) int d_create_array(const MKL_INT length, double*& x)
{
	return create_array(length, x); 
}

extern "C" __declspec(dllexport) int b_create_array(const MKL_INT length, bool*& x)
{
	return create_array(length, x); 
}

extern "C" __declspec(dllexport) void d_copy_array(const MKL_INT length, const double* x, double* y)
{
	copy_array(length, x, y); 
}

extern "C" __declspec(dllexport) void b_copy_array(const MKL_INT length, const bool* x, bool* y)
{
	copy_array(length, x, y); 
}

extern "C" __declspec(dllexport) void d_fill_array(const double a, const MKL_INT length, double* x)
{
	fill_array(a, length, x); 
}

extern "C" __declspec(dllexport) void b_fill_array(const bool a, const MKL_INT length, bool* x)
{
	fill_array(a, length, x); 
}

extern "C" __declspec(dllexport) void set_max_threads(const MKL_INT num_threads)
{
	mkl_set_num_threads(num_threads);
}


