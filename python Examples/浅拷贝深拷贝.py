from copy import copy, deepcopy

lst = [1, 2, [3, 4, 5]]
lst1 = lst
lst2 = copy(lst) #list.copy(lst)

lst.append(6)

print(lst)
print(lst1)
print(lst2)

lst.remove(6)
lst[2].append(0)
print(lst)
print(lst1)
print(lst2)
print(id(lst))
print(id(lst1))
print(id(lst2))

print(id(lst[2]))
print(id(lst2[2]))

lst3 = deepcopy(lst)
print(id(lst[2]))
print(id(lst3[2]))