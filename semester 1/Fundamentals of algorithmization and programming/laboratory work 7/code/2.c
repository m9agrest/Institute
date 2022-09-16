#include <stdio.h>
#include "lib.h"

void func(int *arr1, int *arr2){
	int min1 = arr1[0], i1 = 0;
	int min2 = arr2[0], i2 = 0;
	for(int i = 1; i < 4; i++){
		if(arr1[i]<=min1){
			min1 = arr1[i];
			i1 = i;
		}
		if(arr2[i]<=min2){
			min2 = arr2[i];
			i2 = i;
		}
	}
	arr1[i1] = min2;
	arr2[i2] = min1;
}

void main(){
	start();
	static int col = 4, line = 3, min = -5, max = 5;
	do{
		wprintf(L"Ваш массив\n");
		int **arr = array_2d_generation(col, line, min, max);
		wprintf(L"\nменяем местами наименьшие элементы в первой и третей строке");
		func(arr[0],arr[2]);
		wprintf(L"\nВаш массив после преобразования:\n");
		array_2d_print(arr, col, line, min, max);
	}while(cycle());
	end();
}