#include <stdio.h>
float min(float a, float b){
	if(a>b){
		return b;
	}else{
		return a;
	}
}
void main(){
	float a,b;
	printf("read A:");scanf("%f",&a);getchar();
	printf("read B:");scanf("%f",&b);getchar();
	float z = min(2 * a, b + a) + min(2 * a - b, b);
	printf("\nZ = %.2f",z);
	getchar();
}