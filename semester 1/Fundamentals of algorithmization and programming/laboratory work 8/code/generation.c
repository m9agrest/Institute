#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <locale.h>
#include <conio.h>

void Generation(Info *arr, int n){
	for(int i = 0; i < n; i++){
		arr[i].timeOutput = time(NULL) - rand()%1000000;
		arr[i].timeInput = time(NULL) + rand()%1000000;
		arr[i].distance = (float) (rand()%1000000) / 100;
		arr[i].name = malloc(32*sizeof(char));
		sprintf_s(arr[i].name, 32, "Город №%d", i+1);
		arr[i].id = malloc(8*sizeof(char));
		switch (rand()%4){
			case 0: sprintf_s(arr[i].name, 8, "П%i", 1 + rand()%100); break;
			case 1: sprintf_s(arr[i].name, 8, "Г%i", 100 + rand()%100); break;
			case 2: sprintf_s(arr[i].name, 8, "Т%i", 200 + rand()%100); break;
			case 3: sprintf_s(arr[i].name, 8, "М%i", 300 + rand()%100); break;
		}
		
	}
}