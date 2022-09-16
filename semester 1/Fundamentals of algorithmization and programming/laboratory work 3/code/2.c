#include<stdio.h>

void main() {
	int a = 0;
	printf("read:");
	scanf("%d", &a);
	getchar();
	int b = a % 10;

	while (a > 9 ) {
		a = ((a - a % 10) / 10);
	}
	if (a > b) {
		b = a;
	}
	printf("result: %d", b);
	getchar();
}