#include "lib.h"

void main(){
	start();
	int N = 0;
	N = my_scan_int("Введите кол-во поездов: ");
	Info *Data = (Info *)malloc(N * sizeof(Info));
	printf("\n");
	
	Generation(Data, N);
	printf("\n\n\n\n");
	InfoPrint(Data, N);
}