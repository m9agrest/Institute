#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main() {
	int a[40];
	printf("a: \n");
	srand(time(NULL));
	for(int i = 0; i<40;i++){
		a[i] = ((rand() % 100) - 50);
		printf("%d , ", a[i]);
	}
	printf("\n");



	int max = a[0];
	int maxi = 0;
	int min = a[0];
	int mini = 0;
	for (int i = 0; i < 40; i++) {
		if (a[i]>max) {
			max = a[i];
			maxi = i;
		}
		if (a[i] < min) {
			min = a[i];
			mini = i;
		}
	}
	int result = 0;

	int in = mini + 1;
	int n = maxi;
	if (maxi < mini) {
		in = maxi + 1;
		n = mini;
	}
	for (int i = in; i <= n; i++) {
		result += a[i];
	}
	printf("result: %d", result);
	getchar();
}