#include <stdio.h>
#include "lib.h"

void main(){
	start();
	static int col = 36, line = 18, min = 0, max = 1;
	do
	{
		wprintf(L"Ваш массив\n");
		int **arr = array_2d_generation(col, line, min, max);
		int frees = 0;
		for(int i = 0; i < line; i++){
			for(int ii = 0; ii < col; ii++){
				if(!arr[i][ii]){
					frees++;
				}
			}
		}
		wprintf(L"\nкол-во свободных мест: %d\n", frees);
	} while (cycle());
	end();
}