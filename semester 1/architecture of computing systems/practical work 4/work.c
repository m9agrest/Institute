#include <stdio.h>
#include <stdlib.h>
#include <time.h>
void main() {
	int n;
	char* FileName = "test.txt";
	printf("read N: "); scanf("%d", &n); getchar();

	int a[n];
	srand(time(NULL));

	FILE *f;
	f = fopen(FileName, "w");
	fprintf(f, "N: %d\nResult:",n);
	for (int i = 0; i < n; i++) {
		a[i] = rand();
		printf("%d\n",a[i]);
		fprintf(f, "\n%d: %d", i+1, a[i]);
	}
}