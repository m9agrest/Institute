#include <stdio.h>
#include <stdio.h>

typedef struct name_t{
	char *Name;//���
	char *Lastname;//䠬����
	char *Patronymic;//����⢮
	char *Middlename;//��஥ ���
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
	if(name.Name){printf("���: %s\n",name.Name);}
	if(name.Middlename){printf("��஥ ���: %s\n",name.Middlename);}
	if(name.Patronymic){printf("����⢮: %s\n",name.Patronymic);}
	if(name.Lastname){printf("�������: %s\n",name.Lastname);}
}

void PrintBirthDay(DAY day){
	printf("��� ஦�����: %i.%i.%i\n",day.Day, day.Mounth, day.Year);
}

void PrintOnline(int online){
	if(!online){
		printf("���짮��⥫� � ����� ������ �� � ��");
	}else{
		printf("������");
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

	my.Name.Name = "��堨�";
	my.Name.Lastname = "�ନ���";
	my.Name.Patronymic = "�������஢��";
	my.Name.Middlename = NULL;

	my.Online = 1;


	user.BirthDay.Day = 10;
	user.BirthDay.Mounth = 10;
	user.BirthDay.Year = 2001;

	user.Name.Name = "���ᨬ";
	user.Name.Lastname = "�����祭��";
	user.Name.Patronymic = NULL;
	user.Name.Middlename = "����";
	user.Online = 0;
	printf("=========��� ��䨫�==========\n");
	PrintUser(my);
	printf("\n=====��䨫� ���짮��⥫�=====\n");
	PrintUser(user);
	printf("\n\n����� �ணࠬ��");
	getchar();
}