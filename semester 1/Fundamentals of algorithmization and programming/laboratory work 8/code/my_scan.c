#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <locale.h>
#include <conio.h>

void clear_stdin(){
	int trash;
	do {
		trash = getchar();
	} while (trash != '\n' && trash != EOF);
}

int my_scan_int(char *text){
	int a;
	while (1){
		printf(text);
		int err = scanf("%i", &a);
		clear_stdin();
		if (err == 1){ break; }
		printf("Неправильный ввод данных\n");
	}
	return a;
}