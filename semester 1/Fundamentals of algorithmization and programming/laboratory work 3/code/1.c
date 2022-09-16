#include<stdio.h>

void main() {
	int a = 0;
	int b = 0;
	int c = 1;
	int x = 0;
	printf("read x:");
	scanf("%d", &x);
	getchar();
	printf("read: \n");
	while (c) {
		scanf("%d", &c);
		getchar();
		if (c > x) {
			a += c;
		}
		if (c % 2 == 0) {
			b++;
		}
	}

	printf("result:\n");
	printf("a) %d\n",a);
	printf("b) %d\n",b);
	getchar();
}