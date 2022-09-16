#include <stdio.h>
#include "lib.h"

void main(){
	start();
	int col = my_scan(L"Введите кол-во столбцов в массиве: ");
	while(col<3){
		col = my_scan(L"Введено маленькое кол-во столбцов, введите больше 2: ");
	}

	int line = my_scan(L"Введите кол-во строк в массиве: ");
	while(line<3){
		line = my_scan(L"Введено маленькое кол-во строк, введите больше 2: ");
	}
	wprintf(L"\n\nВаш массив\n");
	int **arr = array_2d_generation(col, line, -100, 100);
	int imax = 0;
	int max = arr[0][2];
	for(int i = 1; i < line; i++){
		if(arr[i][2]>=max){
			max = arr[i][2];
			imax = i;
		}
	}
	wprintf(L"\n\n\nНаибольший элемент в 3 столбце, находится в %d строке", imax+1);
	end();
}