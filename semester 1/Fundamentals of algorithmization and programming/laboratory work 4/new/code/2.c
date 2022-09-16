#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main() {
	double q[20];
	srand(time(NULL));
	printf("q: \n");
	for(int i = 0; i<20;i++){
		q[i] = (double) ((rand() % 1000) - 500)/10;
		printf("%.1lf , ", q[i]);
	}
	printf("\n");



	int c = 0;
	for (int i = 0; i < 20; i++) {
		if (q[i] * q[i] + 3 * q[i] - 5 == 0) {
			c = 1;
			printf("Q[%d]: %lf", i, q[i]);
		}
	}
	if (!c) {
		printf("not found");
	}
	getchar();
}