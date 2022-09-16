#include <stdio.h>
#include <stdlib.h> 

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
	
	int x,k1,k2;
	printf("Read X:");scanf("%d",&x);getchar();
	printf("Read k1:");scanf("%d",&k1);getchar();
	printf("Read k2:");scanf("%d",&k2);getchar();

	printf("�⥭�� 䠩��:");
	while(!feof(file)){
		N++;
		arr = (int*)realloc(arr, sizeof(int) * N);
		fscanf(file, "%d", &arr[N-1]);
	}
	int nn = N;
	printf("\n��⮢�\n��⠭� %lld ��ப\n\nࠡ�� � ���ᨢ��:\n",N);


	for(int i = 0; i < N; i++){
		if(arr[i]>x){
			N++;
			arr = (int*)realloc(arr, (N) * sizeof(int));
			int c = arr[N-2];
			for(int iii = N-1; iii > i; iii--){
				arr[iii] = c;
				c = arr[iii-2];
			}
			arr[i+1] = k1;
			i++;
		}

		if(i%10==0){
			PercentInfo(N,i);
		}
	}
	
	printf("\r��⮢�\n��������� %d ������⮢\n\n������ � 䠩�:\n", nn-N);
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