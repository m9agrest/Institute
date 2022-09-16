#include<stdio.h>
#include<math.h>
void main() {
	double y, i;
	printf("enter y: ");
	scanf("%lf", &y);
	getchar();
	printf("enter i: ");
	scanf("%lf", &i);
	getchar();
	double f = log(y) + 2 * pow(i, 3);
	if (f) {//если 0 - false
		double z = (0.81 * cos(i)) / f;
		printf("result: %lf", z);
	}
	else {
		printf("error: ln(y) + 2i^3 = 0");
	}
	getchar();
}