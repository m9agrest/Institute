#include<stdio.h>
#include <math.h> 
void main() {
	double a, b, i1, i2, i3;
	printf("enter S square: ");
	scanf("%lf", &a);
	getchar();
	printf("enter S circle: ");
	scanf("%lf", &b);
	getchar();
	i1 = sqrt(a);//сторона квадрата
	i2 = 2 * sqrt(b / M_PI);//димаетр
	i3 = sqrt(2 * i1 * i1);//диагональ квадрата
	if (i2 <= i1) {
		printf("a) yes");
	} else {
		printf("a) no");
	}
	printf("\n");
	if (i3 <= i2) {
		printf("b) yes");
	}
	else {
		printf("b) no");
	}

	getchar();
}