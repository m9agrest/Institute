#include <stdio.h>

void aa(int *c, int *arr, int a){
	int cc = *c;
	int ccc = 0;
	for(int i = 0; i < cc; i++){
		arr[i] *= 2;
		arr[i] += ccc;
		ccc = 0;
		if(arr[i]>9){
			if(i+1 == *c){
				arr[*c]=0;
				(*c)++;
			}
			ccc += arr[i]/10;
			arr[i] = arr[i]%10;
		}
	}
	if(ccc){
		arr[(*c) - 1] = ccc;
	}
	
}

void main(){
	int a[100];
	int b = 1;
	a[0] = 2;
	for(int i = 1; i < 100; i++){
		aa(&b, a, 100);
	}
	for(int i = b-1; i >= 0; i--){
		printf("%d", a[i]);
	}
	getchar();
}