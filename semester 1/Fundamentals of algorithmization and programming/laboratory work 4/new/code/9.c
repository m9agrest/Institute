#include <stdio.h>

void check(int a) {
	int a1 = a / 100;
	int a2 = (a % 100)/ 10;
	int a3 = a % 10;
	if (a1!=a2 && a2 != a3 && a1 != a3) {
		printf("%d\n", a);
	}
}

void main() {
	for (int i = 100; i < 1000; i++) {
		check(i);
	}
	getchar();
}