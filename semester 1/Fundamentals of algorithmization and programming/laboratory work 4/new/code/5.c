#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main() {
	srand(time(NULL));
	int n;
	printf("read N:"); scanf("%d", &n); getchar();
	int a[n];
	a[0] = rand() % 100 - 50;
	int min = a[0];
	int mini = 0;
	printf("A = %d", a[0]);
	for (int i = 1; i < n; i++) {
		a[i] = rand() % 100 - 50;
		if (min>a[i]) {
			min = a[i];
			mini = i;
		}
		printf(", %d", a[i]);
	}
	for (int i = mini+1; i < n; i++) {
		if (a[i] < 0) {
			a[i] = 0;
		}
	}
	printf("\nresult:\nA = %d", a[0]);
	for (int i = 1; i < n; i++) {
		printf(", %d", a[i]);
	}
	getchar();
}