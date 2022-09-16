#include<stdio.h>
void main(){
	double a, b, c;
	printf("enter side a: ");
	scanf("%lf", &a);
	getchar();
	printf("enter side b: ");
	scanf("%lf", &b);
	getchar();
	printf("enter side c: ");
	scanf("%lf", &c);
	getchar();
	int h = 1;
	if (a <= 0) {
		h = 0;
		printf("\nerror: a <= 0");
	}
	if (b <= 0) {
		h = 0;
		printf("\nerror: b <= 0");
	}
	if (a <= 0) {
		h = 0;
		printf("\nerror: c <= 0");
	}
	if (h) {
		if (!((a + b > c) && (b + c > a) && (a + c > b))) {
			printf("\nerror: it is impossible to make a triangle from these sides");
		} else {
			if (a == b || a == c || c == b) {
				printf("the triangle is isosceles ");
			}
			else {
				printf("the triangle is not isosceles");
			}
		}
	}
	getchar();
}