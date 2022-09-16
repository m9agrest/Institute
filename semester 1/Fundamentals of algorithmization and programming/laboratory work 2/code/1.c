#include<stdio.h>
void main() {
	double v1, w1, v2, w2;
	printf("enter volume 1: ");
	scanf("%lf", &v1);
	getchar();
	printf("enter weight 1: ");
	scanf("%lf", &w1);
	getchar();
	printf("enter volume 2: ");
	scanf("%lf", &v2);
	getchar();
	printf("enter weight 2: ");
	scanf("%lf", &w2);
	getchar();
	int a = 1;
	if (v1 <= 0) {
		a = 0;
		printf("\nerror: volume 1 <= 0");
	}
	if (w1 < 0) {
		a = 0;
		printf("\nerror: weight 1 < 0");
	}
	if (v2 <= 0) {
		a = 0;
		printf("\nerror: volume 2 <= 0");
	}
	if (w2 < 0) {
		a = 0;
		printf("\nerror: weight 2 < 0");
	}
	if (a) {
		double d1 = w1 / v1;
		double d2 = w2 / v2;
		if (d1 > d2) {
			printf("the density of the first object is greater");
		}else if (d1 == d2) {
			printf("the densities of the two objects are equal");
		}else {
			printf("the density of the second object is greater");
		}
	}
	getchar();
}