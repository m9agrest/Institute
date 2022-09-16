#include <stdio.h>

void main() {
	int n;
	printf("read N:"); scanf("%d", &n); getchar();
	int a[n];
	for (int i = 0; i < n; i++) {
		printf("read A[%d]:", i); scanf("%d", &a[i]); getchar();
	}
	int maxi = 0;
	int maxn = 1;
	int maxinew = 0;
	for (int i = 0; i < n; i++) {
		if (a[i]>0) {
			if (maxn - maxi < i - maxinew) {
				maxi = maxinew;
				maxn = i+1;
			}
		} else {
			maxinew = i;
		}
	}
	for (int i = maxi; i <= maxn; i++) {
		a[i] = 0;
	}
	printf("result:");
	for (int i = 0; i < n; i++) {
		printf("\nA[%d]: %d", i, a[i]);
	}
	getchar();
}