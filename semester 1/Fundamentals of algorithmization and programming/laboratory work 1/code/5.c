#include<stdio.h>
#include<math.h>
void main() {
	double a, b, x, y;
	printf("enter a: ");
	scanf("%lf", &a);
	getchar();
	printf("enter b: ");
	scanf("%lf", &b);
	getchar();
	printf("enter x: ");
	scanf("%lf", &x);
	getchar();
	printf("enter y: ");
	scanf("%lf", &y);
	getchar();
	double f = x + b - a;
	if (f >= 0) {
		double w = atan(b + a);
		if (w) {//если 0 - false
			double z = (sqrt(f) + log(y)) / w;
			printf("result: %lf", z);
		}
		else {
			printf("error: arctg(b + a) = 0");
		}
	}
	else {
		printf("error: (x + b - a) < 0");
	}
	getchar();
}