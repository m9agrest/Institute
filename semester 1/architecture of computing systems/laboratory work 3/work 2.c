#include <stdio.h>
#include <stdlib.h> 

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

void PercentInfo(int N, int I){
	int p =((float) I / N) * 100;
	printf("\r%d%c",p,37);
}

int main(){
	char name[32];
	int *arr = (int*)malloc(sizeof(int) * 0);
	int N = 0;

	printf("������ ��� 䠩��: ");
	scanf("%s", &name);
	getchar();

	FILE *file = fopen(name, "r");
	if(!file){
		printf("���� �� ������");
		getchar();
		return 0;
	}


	printf("�⥭�� 䠩��:");
	while(!feof(file)){
		N++;
		arr = (int*)realloc(arr, sizeof(int) * N);
		fscanf(file, "%d", &arr[N-1]);
	}
	int nn = N;
	printf("\n��⮢�\n��⠭� %lld ��ப\n\nࠡ�� � ���ᨢ��:\n",N);


	for(int i = 0; i < N; i++){
		if(check(arr[i])){
			for(int ii = i; ii < N-1; ii++){
				arr[ii] = arr[ii+1];
			}
			i--;
			N--;
			arr = (int*)realloc(arr, N * sizeof(int));

		}

		if(i%10==0){
			PercentInfo(N,i);
		}
	}
	
	printf("\r��⮢�\n㤠���� %d ����⮢\n\n������ � 䠩�:\n", nn-N);
	fclose(file);
	file = fopen(name, "w");
	for(int i = 0; i < N; i++){

		if(i==(N-1)){
			fprintf(file,"%d",arr[i]);
		}else{
			fprintf(file,"%d\n",arr[i]);
		}

		if(i%10==0){
			PercentInfo(N,i);
		}
	}


	free(arr);
	fclose(file);
	printf("\r��⮢�\n\n����� ࠡ���\n");
	getchar();
	return 0;
}