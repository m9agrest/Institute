#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

int main(){
	srand(time(NULL));
	int n = 10;
	int max = 0;
	int *arr = (int*) malloc (n * sizeof(int));
	printf("array:\n");
	for(int i = 0; i < n ; i++){
		arr[i] = rand()%41 + 10;
		printf("%d ", arr[i]);
		if(arr[i]%2 == 0){
			if(arr[i] > max){
				max = arr[i];
			}
		}
	}
	printf("\n\nmax: %d", max);
	getchar();
	return 0;
}