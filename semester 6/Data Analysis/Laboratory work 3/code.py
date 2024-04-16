import re

def task(index):
    print("================")
    print("задание", index)
    print("================")

def search_subst(st, subst):
    if re.search(subst, st):
        print("Есть контакт!")
    else:
        print("Мимо!")

def for_task_2(st, char):
    st = st.lower()
    i1 = -1 #первое вхождение
    i2 = -1 #последнее вхождение
    i = 0
    while i < len(st):
        if char == st[i]:
            i2 = i;
            if i1 == -1:
                i1 = i
        i+=1
    print((char, i1, i2))

def for_task_3(st):
    st = st.lower()
    chars = {}
    for char in st:
        if char != ' ':
            if char not in chars:
                chars[char] = 1
            else:
                chars[char] += 1
    top2(chars)

def top2(chars):
    name_1 = min(chars, key=chars.get)
    value_1 = chars[name_1]
    chars.pop(name_1)
    name_2 = min(chars, key=chars.get)
    value_2 = chars[name_2]
    print(name_1, "-", value_1)
    print(name_2, "-", value_2)

def for_task_4(st):
    line = st.split("\n")
    i = 0
    while i < len(line):
        word = line[i].split(" ")
        word[0] = word[0].lower()
        word[-1] = word[-1].capitalize()
        line[i] = ' '.join(reversed(word))
        i+=1
    new_st = '\n'.join(line)
    print(new_st)

def for_task_5(st):
    word = st.split(" ")
    key = []
    for w in word:
        if w not in key:
            key.append(w)
    i = 0
    while i < len(word):
        word[i] = str(key.index(word[i]))
        i += 1
    new_st = ' '.join(word)
    print(new_st)


task(1)
search_subst(input("Введите строку: "), input("Введите подстроку: "))

task(2)
st = input("Введите строку: ")
for_task_2(st, input("Введите букву 1: "))
for_task_2(st, input("Введите букву 2: "))
for_task_2(st, input("Введите букву 3: "))

task(3)
for_task_3(input("Введите строку: "))

task(4)
st = "Нам не ссориться так просто,\nВедь для добрых отношений\nУважать друг друга нужно —\nКаждого без исключений!"
print(st)
print("=================")
print("проводим операцию")
print("=================")
for_task_4(st)

task(5)
st = "Здесь есть риск подвергнуться атаке светлячков и они совсем не так безобидны как в Гранит Фолз, так что прихватите с рынка защитный порошок от светлячков или хотя бы изучите навык местной культуры"
print(st)
print("=================")
print("проводим операцию")
print("=================")
for_task_5(st)



input()