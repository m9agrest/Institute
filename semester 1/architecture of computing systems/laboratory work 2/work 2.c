#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int check(int a){
	if(a<0){ a*=-1; }
	
	if(a>99){
		return 0;
	}else if(a<10){
		return 0;
	}else{
		if(((a / 10) % 2 == 0) && ((a % 10) % 2 == 0)){
			return 1;
		}else{
			return 0;
		}
	}
}

void main(){
	srand(time(NULL));
	int n;
	int *arr;
	printf("Read N:");scanf("%d",&n);getchar();
	arr = (int*) malloc(n * sizeof(int));
	printf("array:\n");
	for (int i = 0; i < n; i++){
		arr[i] = rand()%311-135;
		printf("%d: %d\n", i, arr[i]);
	}
	printf("\n\n");
	for (int i = 0; i < n; i++){
		if(check(arr[i])){
			int c = arr[n-1];
			for(int ii = n-2; ii >= i; ii--){
				int b = *(arr+ii);
				arr[ii] = c;
				c = b;
			}
			i--;
			n--;
			arr = (int*)realloc(arr, (n) * sizeof(int));
		}
	}
	
	printf("array:\n");
	for(int i = 0; i < n; i++){
		printf("%d: %d\n", i, arr[i]);
	}
	printf("\n");
	free(arr);
}