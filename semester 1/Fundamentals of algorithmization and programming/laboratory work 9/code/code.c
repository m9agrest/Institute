#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include "lib.h"



void main(){
	srand(time(NULL));

	R1 = sqrt(2);
	L2 = 4.5;
	S1 = (2 * M_PI) - ((float) 1/3 + M_PI / 2);
	S01 = pow( R1*2 ,2);
	S2 = (pow(4.5, 2) / 2) - ((3 * M_PI) / 4);
	S02 = pow(4.5, 2);




	printf("Вычисление фигуры №1\nЕё площадь:%f\n\n",S1);
	func(100, 1);
	func(1000, 1);
	func(10000, 1);
	func(100000, 1);
	func(1000000, 1);
	func(10000000, 1);

	printf("\nВычисление фигуры №2\nЕё площадь:%f\n\n",S2);
	func(100, 2);
	func(1000, 2);
	func(10000, 2);
	func(100000, 2);
	func(1000000, 2);
	func(10000000, 2);
	printf("\nКонец работы");
	getchar();
}