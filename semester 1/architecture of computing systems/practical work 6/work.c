#include "lib.h"

void main(){
	srand(time(NULL));
	setlocale(LC_ALL, "");
	wprintf(L"Генерация массива 10 на 5 с визуализацией\n\n\n");
	int **arr = array_2d_generation(10, 5, -10, 10);

	getchar();
}