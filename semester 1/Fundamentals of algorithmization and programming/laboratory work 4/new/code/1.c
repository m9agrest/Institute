#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>

void main() {
	double x[16];
srand(time(NULL));
	printf("x: \n");
	for(int i = 0; i<16;i++){
		x[i] = (double) ((rand() % 1000) - 500)/10;
		printf("%.1lf , ", x[i]);
	}
	printf("\n");



	for (int i = 0; i < 16; i++) {
		double d = (exp(x[i]) + pow(2 * x[i], -x[i])) / sqrt(cos(x[i]));
		if (d > 0.1) {
			printf("%d: %.1lf\n", i, d);
		}
	}
	getchar();
}