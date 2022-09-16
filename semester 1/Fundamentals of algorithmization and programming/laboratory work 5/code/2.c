#include <stdio.h>
#include <math.h>
float sh(float x){
	return (exp(x) - exp(-x))/2;
}
float ctg(float x){
	return 1/tan(x);
}

void main(){
	float result,x;
	printf("read X:");scanf("%f",&x);getchar();
	result = sh(x) * tan(x+1) - pow(ctg(2+sh(x-1)),2);
	printf("\nZ = %f",result);
	getchar();
}