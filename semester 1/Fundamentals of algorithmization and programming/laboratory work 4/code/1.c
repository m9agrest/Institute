#include <stdio.h>
#include <math.h>

void main() {
	double x[16] = [16.62, 23.92, 4.59, 62.41, 61.45, 88.19, 63.89, 72.83, 46.57, 81.29, 11.68, 99.11, 20.75, 11.01, 75.37, 21.01];
	for (int i = 0; i < 16; i++) {
		double d = (exp(x[i]) + pow(2 * x, -x[i])) / sqrt(cos(x[i]));
		if (d > 0.1) {
			printf("%d: %lf", i, d);
		}
	}
	getchar();
}