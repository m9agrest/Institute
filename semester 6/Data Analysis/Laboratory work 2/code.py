import random
import math


print("Задание 1")
C = []
A = 0
Al = 0
i = 0
for i in range(23):
	C.append(random.random()*7)
for i in range(len(C)):
    if C[i] >= 3.5:
        Al += 1
        A += C[i]
print("Среднее значение ", A / Al)


print("Задание 2")
sum = 0
arr = []
for i in range(15):
	arr.append(random.randint(-100, 100))
for i in range(len(arr)):
    sum += abs(arr[i])
print("Сумма абсолютных значений ", sum)


print("Задание 3")
sum1 = 1
sum2 = 1
arr = []
for i in range(30):
	arr.append(random.randint(-100, 100))
for i in range(len(arr)):
    if i > 0:
        if arr[i] != 0:
            if arr[i] % 2 == 0:
                sum1 *= arr[i];
            else:
                sum2 *= arr[i];
print("произведение четных ", sum1)
print("произведение не четных ", sum2)


print("Задание 4")
N = 25
arr = []
for i in range(N):
	arr.append(random.randint(-100, 100))
arr.sort()
arr.reverse()
print(arr)


print("Задание 5")
N = 25
i1 = 0
i2 = 1
arr = []
for i in range(N):
	arr.append(random.randint(-100, 100))
arr2 = [None] * N
for i in range(len(arr)):
    if arr[i] > 0 and i > 0 and i % 2 == 0:
        arr2[i1] = arr[i]
        i1 += 1
    else:
        arr2[-i2] = arr[i]
        i2 += 1
print(arr)
print(arr2)


print("Задание 6")
print("Часть 1")
def func1(_a, _b):
    _c = _a ** 2 + _b ** 2
    return _c ** 1/2
a1 = int(input("Введите катет треугольника 1 "))
b1 = int(input("Введите второй катет треугольника 1 "))
c1 = func1(a1, b1)
a2 = int(input("Введите катет треугольника 2 "))
b2 = int(input("Введите второй катет треугольника 2 "))
c2 = func1(a2, b2)
if c1 > c2:
    print("Гипотенуза 1 больше")
else:
    print("Гипотенуза 2 больше")
print("Часть 2")
def func2(sentence):
    words = sentence.split(" ")
    sorted_words = []
    for word in words:
        sorted_word = ""
        for char in sorted(word):
            sorted_word += char
        sorted_words.append(sorted_word)
    return " ".join(sorted_words)

sentence = input("Введите предложение ")
print(func2(sentence))



input()