#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main() {
	int a[45] = {};
	srand(time(NULL));
	printf("a: \n");
	for(int i = 0; i<20;i++){
		a[i] = ((rand() % 100) - 50);
		printf("%d , ", a[i]);
	}
	printf("\n");




	int max= a[0];
	int min = 0;
	int i1 = 0;
	int i2 = 0;
	for (int i = 0; i < 45; i++) {
		if (a[i]>max){
			max = a[i];
			i1 = i;
		}
		if(a[i]<0){
			min = a[i];
			i2 = i;
		}
	}
	printf("result: %d\n %d,%d", max-min, i1, i2);
	getchar();
}