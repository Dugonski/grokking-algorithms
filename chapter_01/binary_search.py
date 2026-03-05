def binary_search(lst, item):
    low = 0
    high = len(lst) - 1

    while low <= high:
        mid = (low + high) // 2
        guess = lst[mid]

        if guess == item:
            print(f"Item found at index {mid}")
            return mid
        
        if guess > item:
            print(f"Item not found at index {mid}")
            high = mid - 1

        else: 
            print(f"Item not found at index {mid}")
            low = mid + 1
        
    return None

# Test cases
print(binary_search([1, 3, 5, 7, 9, 14 ,15 ,16 ,17 ,18 ,19 ,20], 15))
