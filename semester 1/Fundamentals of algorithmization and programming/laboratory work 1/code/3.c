#include<stdio.h>
#include<math.h>
void main() {
	double x, y;
	printf("enter x: ");
	scanf("%lf", &x);
	getchar();
	printf("enter y: ");
	scanf("%lf", &y);
	getchar();
	double z = cos(2 * y) + 3.6 * exp(x);
	printf("result: %lf", z);
	getchar();
}