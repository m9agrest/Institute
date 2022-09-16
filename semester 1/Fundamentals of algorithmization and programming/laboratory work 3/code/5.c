#include <stdio.h>
#include <math.h>
long long int fact(int a) {
	int c = 1;
	for (int i = 1; i <= a; i++) {
		c *= i;
	}
	return c;
}


void main() {

	long long int w = 0;
	int k = 0;
	printf("read K:");
	scanf("%d", &k);
	getchar();
	for (int i = -2; i <= k; i++) {
		w += (pow(-1, i) * fact(i + 3)) / (i - 4);
	}

	printf("read W:%lld",w);
	getchar();
}