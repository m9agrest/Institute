#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

int f1(int x){
	if(x>0){
		if(x%5==0){
			int s = 0;
			while(pow(5,++s)<x);
			if(pow(5,s)==x){
				return s;
			}else{
				return -1;
			}
		}else if(x==1){
			return 0;
		}else{
			return -1;
		}
	}else{
		return -1;
	}
}
void main(){
	srand(time(NULL));
	int n, x = 0;
	printf("read N:");scanf("%d",&n);getchar();
	int arr[n];
	printf("array:");
	for (int i = 0; i < n; i++){
		//arr[i] = rand()%201-100;
		//printf("\n%d: %d", i, arr[i]);
		printf("\n%d: ", i);
		scanf("%d",&arr[i]);
		getchar();
		int f = f1(arr[i]);
		if(f>=0){
			x++;
			printf(" = 5^%d", f);
		}
	}
	printf("\n\nResult = %d",x);
	getchar();
}