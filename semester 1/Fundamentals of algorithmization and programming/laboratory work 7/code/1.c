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

	wprintf(L"\n\nВторой столбец массива:\n");
	int *arrs = (int*)malloc(line*sizeof(int));
	for(int i = 0; i < line; i++){
		arrs[i] = arr[i][1];
	}
	array_print(arrs,col);

	wprintf(L"\n\n\n");
	int Nline = my_scan(L"Введите какую строку нужно вывести: ");
	while (Nline<1||Nline>line){
		wprintf(L"Такой строки нет, ");
		Nline = my_scan(L"попробуйте снова: ");
	}
	wprintf(L"\nВаша строка:\n");
	array_print(arr[Nline-1],col);
	end();
}