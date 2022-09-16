

typedef struct  name_t
{
	char Name[32];
	char Lastname[32];
	char Patronymic[32];
}NAME;

typedef struct address_t
{
	int PostIndex;
	char Country[32];
	char Region[32];
	char District[32];
	char City[32];
	char Street[32];
	int Home;
	int Apartment;
}ADDRESS;

typedef struct car_t
{
	char Brand[32];
	char Number[32];
	int Pasport;
}CAR;

typedef struct owner_t
{
	NAME Name;
	int Phone;
	ADDRESS Address;
	CAR Car;
}OWNER;

