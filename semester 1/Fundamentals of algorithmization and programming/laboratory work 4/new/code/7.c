#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>

void check(int o, int *a, int *arr, int n){
	int v = 0;
	for(int i=0;i<(*a);i++){
		if(arr[i]==o){
			v = 1;
		}
	}
	if(!v){
		arr[*a] = o;
		(*a)++;
	}
}


void main() {
	int n;
	printf("read N: ");scanf("%d",&n);getchar();

	int x[n];
	int xx[n];
	int g = 0;
	srand(time(NULL));
	printf("x: \n");
	for(int i = 0; i<n;i++){
		x[i] = (double) ((rand() % 10) - 5);
		printf("%d, ", x[i]);
	}
	printf("\n\n");



	for (int i = 0; i < n; i++) {
		check(x[i], &g, xx, n);
	}
	printf("\n%d", g);
	getchar();
}