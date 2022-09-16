#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>
#include <stdarg.h>
#include <string.h>

void start(){
	srand(time(NULL));
	setlocale(LC_ALL, "");
}

void end(){
	wprintf(L"\n\n\nКонец работы!\nнажмите enter чтобы закончить\n");
	getchar();
}



int **array_2d_generation(int size_col, int size_line, int min, int max){
	if(min > max){
		int f = min;
		min = max;
		max = f;
	}
	int **arr = (int **)malloc(size_line*sizeof(int *));
	int m = max - min + 1;
	for(int i = 0; i < size_line; i++) {
		arr[i] = (int *)malloc(size_col*sizeof(int));
		for(int ii = 0; ii < size_col; ii++){
			arr[i][ii] = rand() % m + min;
		}
	}
	array_2d_print(arr, size_col, size_line, min, max);
	return arr;
}

void array_2d_print(int **arr, int size_col, int size_line, int min, int max){

	int Nspace = 0;
	int NspaceLine = n_space(size_line+1);
	
		int NspaceA = min;
		int NspaceAN = n_space(NspaceA);

		int NspaceB = size_col+1 > max ? size_col+1 : max;
		int NspaceBN = n_space(NspaceB);
		Nspace = NspaceBN > NspaceAN ? NspaceBN : NspaceAN;
	
	for(int i = -1; i < size_line; i++){
		array_2d_print_num(i+1, NspaceLine);
		printf("#");
		for(int ii = 0; ii < size_col; ii++){
			if(i<0){
				array_2d_print_num(ii+1, Nspace);
			}else{
				array_2d_print_num(arr[i][ii], Nspace);
			}
			if(ii!=size_col-1){
				printf("|");
			}
		}
		if(i>=0&&i!=size_line-1){
			array_2d_print_line(size_col, Nspace, NspaceLine);
		}else if(i<0){
			array_2d_print_line_head(size_col, Nspace, NspaceLine);
		}
		printf("\n");
	}
}

int n_space(int num){
	int a = 0;
	if(!num){
		a = 1;
	}else if(num<0){
		a++;
		num*=-1;
	}
	while(num){
		num /= 10;
		a++;
	}
	return a;
}

void array_2d_print_num(int num, int Nspace){
	int space = Nspace - n_space(num);
	printf(" ");
	for(int i = 0; i<space; i++){
		printf(" ");
	}
	printf("%d ", num);
	
}

void array_2d_print_line(int size_col, int Nspace, int NspaceLine){
	int line = NspaceLine + (Nspace + 3) * size_col + 1;
	printf("\n");
	for(int i = 0; i<=line; i++){
		if(i==NspaceLine+2){
			printf("#");
		}else{
			printf("-");
		}
	}
}

void array_2d_print_line_head(int size_col, int Nspace, int NspaceLine){
	int line = NspaceLine + (Nspace + 3) * size_col + 1;
	printf("\n");
	for(int i = 0; i<=line; i++){
		printf("#");
	}
}

int cycle(){
	int b = 1;
	wprintf(L"\nхотите продолжить? y/n\n");
	char c = getch();
	while(c!='y'&&c!='n'){ c = getch(); }
	if(c=='n'){b = 0;}else{ printf("\n"); }
	return b;
}

void clear_stdin(){
	int trash;
	do {
		trash = getchar();
	} while (trash != '\n' && trash != EOF);
}

int my_scan(wchar_t *text){
	int a;
	while (1){
		wprintf(text);
		int err = scanf("%i", &a);
		clear_stdin();
		if (err == 1){ break; }
		wprintf(L"Неправильный ввод данных\n");
	}
	return a;
}

void array_print(int *arr, int n){
	for(int i = 0; i < n; i++){
		printf(" %d ", arr[i]);
		if(i!=n-1){
			printf("|");
		}
	}
}