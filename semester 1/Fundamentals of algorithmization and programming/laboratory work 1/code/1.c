#include<stdio.h>
#include<math.h>
void main() {
	double x = 0.335, y = 0.025;
	double z = x * (sin(pow(x, 3)) + pow(cos(y), 2));
	printf("%lf", z);
	getchar();
}