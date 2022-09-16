#include <stdio.h>
#include <stdlib.h>
#include <time.h>

long int fun1(int *b, int n){
	long int TimeStart = time(NULL);
	for(int i = 0; i < n; i++){
		for(int j = i; j < n; j++){
			if (b[i]>b[j]){
				int temp=b[i];
				b[i]=b[j];
				b[j]=temp;
			}
		}
	}
	return time(NULL) - TimeStart;
}
long int fun2(int s){
	long int TimeStart = time(NULL);
	int a[s];
	FILE *f = fopen("arr.txt", "r");
	for (int i = 0; i < s; i++){ fscanf(f,"%d", &a[i]); }
	fclose(f);
	return time(NULL) - TimeStart;
}
long int fun3(int s){
	long int TimeStart = time(NULL);
	FILE *f = fopen("arr.txt", "r");
	for (int i = 0; i < s; i++){
		int a;
		int b;
		fscanf(f,"%d", &a);
		FILE *ff = fopen("const.txt", "r");
		fscanf(f,"%d", &b);
		fclose(ff);
		a*=b;
	}
	fclose(f);
	return time(NULL) - TimeStart;
}

void main(){
	int n = 100000;
	int arr[n];
	
	FILE *f = fopen("const.txt", "w");
	fprintf(f,"%d",3214);
	fclose(f);
	
	f = fopen("arr.txt", "w");
	srand(time(NULL));
	arr[0] = rand();
	fprintf(f,"%d",arr[0]);
	for(int i = 1; i < n; i++){
		arr[i] = rand();
		fprintf(f,"\n%d",arr[i]);
	}
	fclose(f);
	
	printf("%ld\n",fun1(arr,n));
	printf("%ld\n",fun2(n));
	printf("%ld\n",fun3(n));
	
	getchar();
}