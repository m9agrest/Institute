#include <stdio.h>
#include <stdlib.h>
#include <direct.h>

#include "lib.c"



OWNER OwnerRead(){
	OWNER o;
	printf("Введите имя:");scanf("%s", &o.Name.Name);getchar();
	printf("Введите фамилию:");scanf("%s", &o.Name.Lastname);getchar();
	printf("Введите отчество:");scanf("%s", &o.Name.Patronymic);getchar();

	printf("Введите номер телефона:");scanf("%i", &o.Phone);getchar();

	printf("Введите почтовый индекс:");scanf("%i", &o.Address.PostIndex);getchar();
	printf("Введите страну:");scanf("%s", &o.Address.Country);getchar();
	printf("Введите область:");scanf("%s", &o.Address.Region);getchar();
	printf("Введите район:");scanf("%s", &o.Address.District);getchar();
	printf("Введите город:");scanf("%s", &o.Address.City);getchar();
	printf("Введите улицу:");scanf("%s", &o.Address.Street);getchar();
	printf("Введите дом:");scanf("%i", &o.Address.Home);getchar();
	printf("Введите квартиру:");scanf("%i", &o.Address.Apartment);getchar();

	printf("Введите марку машины:");scanf("%s", &o.Car.Brand);getchar();
	printf("Введите номер машины:");scanf("%s", &o.Car.Number);getchar();
	printf("Введите номер техпаспорта:");scanf("%i", &o.Car.Pasport);getchar();

	return o;
}

void OwnerSave(OWNER owner, int i){
	char c[10];
	sprintf_s(c, 10, "%i.txt", i);
	FILE *f = fopen(c, "w");
	fprintf(f, "%s\n%s\n%s\n%i\n", owner.Name.Name, owner.Name.Lastname, owner.Name.Patronymic, owner.Phone);
	fprintf(
		f, "%i\n%s\n%s\n%s\n%s\n%s\n%i\n%i\n",
		owner.Address.PostIndex, owner.Address.Country,
		owner.Address.Region, owner.Address.District,
		owner.Address.City, owner.Address.Street,
		owner.Address.Home, owner.Address.Apartment
	);
	fprintf(f, "%s\n%s\n%i", owner.Car.Brand, owner.Car.Number, owner.Car.Pasport);
	fclose(f);
}

void main(){
	int n;
	printf("Введите кол-во N: ");scanf("%i", &n);getchar();

	if(!chdir("data")){
		int i = 0, a = 1;

		while(a){
			char c[10];
			sprintf_s(c, 10, "%i.txt", i);
			FILE *f = NULL;
			f = fopen(c, "r");
			if(f == NULL){
				a = 0;
			}else{
				fclose(f);
				remove(c);
			}
			i++;
		}
	}else{
		printf("2");
		mkdir("data");
		chdir("data");
	}


	printf("-------------------------\n");
	for(int i = 0; i < n; i++){
		OwnerSave(OwnerRead(), i);
		printf("-------------------------\n");
	}
	printf("Файлы созданы");
	getchar();
}