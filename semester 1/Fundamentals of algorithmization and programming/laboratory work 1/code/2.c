#include<stdio.h>
#include<math.h>
void main() {
	double r;
	printf("enter radius: ");
	scanf("%lf", &r);
	getchar();
	double d = r * 2;
	printf("diameter: %lf", d);
	getchar();
}