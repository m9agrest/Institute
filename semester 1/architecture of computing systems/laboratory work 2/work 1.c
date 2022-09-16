#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int check(int a){
	int c = 0;
	while(a){
		if(a%10==1){
			c = 1;
		}
		a = a / 10;
	}
	return c;
}

void main(){
	srand(time(NULL));
	int n,x,k1,k2;
	int *arr;
	printf("Read N:");scanf("%d",&n);getchar();
	printf("Read X:");scanf("%d",&x);getchar();
	printf("Read k1:");scanf("%d",&k1);getchar();
	printf("Read k2:");scanf("%d",&k2);getchar();
	arr = (int*) malloc(n * sizeof(int));
	printf("array:\n");
	arr[0] = rand()%100-50;
	int max = arr[0];
	printf("%d: %d\n", 0, arr[0]);
	for (int i = 1; i < n; i++){
		arr[i] = rand()%100-50;
		printf("%d: %d\n", i, arr[i]);
		if(arr[i]>max){
			max = arr[i];
		}
	}
	printf("\n\n\n\n");
	for(int i = 0; i < n; i++){
		if(arr[i]>x){
			n++;
			arr = (int*)realloc(arr, (n) * sizeof(int));
			int c = arr[n-2];
			for(int iii = n-1; iii > i; iii--){
				arr[iii] = c;
				c = arr[iii-2];
			}
			arr[i+1] = k1;
			i++;
		}
	}
	
	printf("array:\n");
	for(int i = 0; i < n; i++){
		printf("%d: %d\n", i, arr[i]);
	}
	printf("\n");
	free(arr);
}