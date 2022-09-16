#include <stdio.h>
#include <stdio.h>

typedef struct name_t{
	char *Name;//имя
	char *Lastname;//фамилия
	char *Patronymic;//отчество
	char *Middlename;//второе имя
}NAME;

typedef struct day_t{
	int Day;
	int Mounth;
	int Year;
}DAY;

typedef struct user_t{
	int Online;
	NAME Name;
	DAY BirthDay;
}USER;

void PrintName(NAME name){
	if(name.Name){printf("Имя: %s\n",name.Name);}
	if(name.Middlename){printf("Второе имя: %s\n",name.Middlename);}
	if(name.Patronymic){printf("Отчество: %s\n",name.Patronymic);}
	if(name.Lastname){printf("Фамилия: %s\n",name.Lastname);}
}

void PrintBirthDay(DAY day){
	printf("Дата рождения: %i.%i.%i\n",day.Day, day.Mounth, day.Year);
}

void PrintOnline(int online){
	if(!online){
		printf("Пользователь в данный момент не в сети");
	}else{
		printf("Онлайн");
	}
}

void PrintUser(USER user){
	PrintName(user.Name);
	PrintBirthDay(user.BirthDay);
	PrintOnline(user.Online);
}

void main(){
	USER my, user;

	my.BirthDay.Day = 4;
	my.BirthDay.Mounth = 5;
	my.BirthDay.Year = 2001;

	my.Name.Name = "Михаил";
	my.Name.Lastname = "Ермилов";
	my.Name.Patronymic = "Владимирович";
	my.Name.Middlename = NULL;

	my.Online = 1;


	user.BirthDay.Day = 10;
	user.BirthDay.Mounth = 10;
	user.BirthDay.Year = 2001;

	user.Name.Name = "Максим";
	user.Name.Lastname = "Володченко";
	user.Name.Patronymic = NULL;
	user.Name.Middlename = "Олег";
	user.Online = 0;
	printf("=========мой профиль==========\n");
	PrintUser(my);
	printf("\n=====профиль пользователя=====\n");
	PrintUser(user);
	printf("\n\nКонец программы");
	getchar();
}