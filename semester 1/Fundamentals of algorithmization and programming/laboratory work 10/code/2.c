#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <direct.h>

#include "lib.c"

OWNER OwnerRead(FILE *file){
	OWNER owner;
	fscanf(file, "%s", &owner.Name.Name);
	fscanf(file, "%s", &owner.Name.Lastname);
	fscanf(file, "%s", &owner.Name.Patronymic);

	fscanf(file, "%i", &owner.Phone);

	fscanf(file, "%i", &owner.Address.PostIndex);
	fscanf(file, "%s", &owner.Address.Country);
	fscanf(file, "%s", &owner.Address.Region);
	fscanf(file, "%s", &owner.Address.District);
	fscanf(file, "%s", &owner.Address.City);
	fscanf(file, "%s", &owner.Address.Street);
	fscanf(file, "%i", &owner.Address.Home);
	fscanf(file, "%i", &owner.Address.Apartment);

	fscanf(file, "%s", &owner.Car.Brand);
	fscanf(file, "%s", &owner.Car.Number);
	fscanf(file, "%i", &owner.Car.Pasport);


	return owner;
}

void func(OWNER owner){
	if(!strcmp(owner.Car.Brand, "Ваз")){
		printf("ФИО: %s %s %s\n", owner.Name.Lastname, owner.Name.Name, owner.Name.Patronymic);
		printf("%s, %s\n%s дом %i, кв. %i\n", owner.Address.Country, owner.Address.City, owner.Address.Street, owner.Address.Home, owner.Address.Apartment);
		printf("Номер машины: %s\n\n", owner.Car.Number);
	}
}

void main(){
	if(!chdir("data")){
		int i = 0, a = 1, b = 0;
		printf("Данные о владельцах Ваз:\n\n\n");
		while(a){
			char c[10];
			sprintf_s(c, 10, "%i.txt", i);
			FILE *f = NULL;
			f = fopen(c, "r");
			if(f == NULL){
				a = 0;
			}else{
				func(OwnerRead(f));
				fclose(f);
			}
			i++;
		}
	}else{
		printf("Файлы не найдены");
	}

}