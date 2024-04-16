import math;
Z = 3.5;
print("Задание 1:\na = ", 1 + Z**2 / (3 + Z**2 / 5));

R = int(input("\nЗадание 2:\nВведите R окружности: "));
print("L = ", 2 * R * math.pi, "S = ", R**2 * math.pi);

p = 1; y = 2;
print("\nЗадание 3:\np = ", p, "\ny = ", y, "\nK = ", math.log(p**2 + y**3) + math.exp(p) );

d = 1; y = 2;
print("\nЗадание 4:\nd = ", d, "\ny = ", y, "\nF = ", math.log(d) + (3.5 * d**2 + 1) / (math.cos(2 * y)) );

c = 1; x = 2; t = 1.5;
print("Задание 5:\nc = ", c, "\nx = ", x, "\nt = ", t, "\nL = ", math.tan(c)**2 + (2 * x**2 + 5) / math.sqrt(c + t) );

print( ("Да, число N двузначное", "Нет, число N не двузначное")[len(str(int(input("\nЗадание 6:\nВведите число N: ")))) != 2]);

num = 1212312; n1 = 0; n2 = 0;
print("\nЗадание 7:\nnum = ", num);
while num > 0:
    a = num % 10;
    if a % 2 == 0:
        n1+=1;
    n2+=a;
    num //= 10;
print("\nКол-во четных цифр = ", n1, "\nСумма чисел = ", n2);

num = 123987; sum = 1;
print("\nЗадание 8:\nnum = ", num);
while num > 0:
    a = num % 10;
    sum*=a;
    num //= 10;
if sum < 50:
    print("Произведение чисел меньше 50");
else:
    print("Произведение чисел больше или равно 50");

a = 12; b = 135; c = 3;
print("\nЗадание 9:\na = ", a, "\nb = ", b, "\nc = ", c);
while a <= b:
    if a % c == 0:
        print(a);
    a+=1;

input();