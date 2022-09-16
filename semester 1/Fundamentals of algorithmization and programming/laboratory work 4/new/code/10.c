#include <stdio.h>

void main() {
	int s;
	printf("Read S: "); scanf("%d", &s); getchar();
	int c = s / 2;
	if (s % 2 == 1) {
		c++;
	}
	for (int i = 1; i <= c; i++) {
		if (s % i == 0) {
			if (i <= s / i) {
				printf("%d x %d\n", i, s / i);
			}
			
		}
	}
	getchar();
}