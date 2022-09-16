#include<stdio.h>
void main() {
	int b, a, c;
	printf("enter a two-digit number: ");
	scanf("%i", &b);
	getchar();
	if (b < 100 && b > 10) {
		c = b % 10 + b / 10;
		if (c % 3 == 0) {
			printf("a) yes");
		}else {
			printf("a) no");
		}
		printf("\nenter the number a: ");
		scanf("%i", &a);
		getchar();
		if (a % c == 0) {
			printf("a) yes");
		}else {
			printf("a) no");
		}
	}else {
		printf("error: the number is not two-digit");
	}
	getchar();
}