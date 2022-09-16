#include <stdio.h>

int mod(int a, int b){
	while(a!=b){
		if(a>b){
			a-=b;
		}else{
			b-=a;
		}
	}
	return a;
}

void main(){
	int a,b,c,d;
	printf("read A:");scanf("%d",&a);getchar();
	printf("read B:");scanf("%d",&b);getchar();
	printf("read C:");scanf("%d",&c);getchar();
	printf("read D:");scanf("%d",&d);getchar();
	
	printf("\nMOD(A and B) = %d",mod(a,b));
	printf("\nMOD(A and C) = %d",mod(a,c));
	printf("\nMOD(A and D) = %d",mod(a,d));
	getchar();
}