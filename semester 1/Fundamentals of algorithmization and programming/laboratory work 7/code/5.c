#include <stdio.h>
#include "lib.h"

void main(){
	start();

	int col = my_scan(L"Введите кол-во столбцов в массиве: ");
	while(col<2){
		col = my_scan(L"Введено маленькое кол-во столбцов, введите больше 1: ");
	}
	int line = my_scan(L"Введите кол-во строк в массиве: ");
	while(line<2){
		line = my_scan(L"Введено маленькое кол-во строк, введите больше 1: ");
	}
	wprintf(L"\nМассив:\n");
	int **arr = array_2d_generation(col, line, -50, 50);

	int n = 0;
	int *arrs = (int*)malloc(n*sizeof(int));
	for(int i = 0; i < line; i++){
		for(int ii = 0; ii < col; ii++){
			if(arr[i][ii]<=10&&arr[i][ii]>0){
				n++;
				arrs = (int*)realloc(arrs, (n) * sizeof(int));
				arrs[n-1]=arr[i][ii];
			}
		}
	}
	wprintf(L"\n\nполучилось:\n");
	array_print(arrs,n);
	end();
}