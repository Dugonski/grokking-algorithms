def recursive_binary_search(lst, item):
    if len(lst) == 0:
        return None
    
    mid = len(lst) // 2
    guess = lst[mid]

    if guess == item:
        return mid
    
    if guess > item:
        return recursive_binary_search(lst[:mid], item)
    
    else:
        return recursive_binary_search(lst[mid + 1:], item)

print(recursive_binary_search([1, 3, 5, 7, 9, 14 ,15 ,16 ,17 ,18 ,19 ,20], 15))
