def find_smallest(arr):
    smallest = arr[0]
    smallest_index = 0

    for i in range(1, len(arr)):
        if arr[i] < smallest:
            smallest = arr[i]
            smallest_index = i
    
    return smallest_index

def selection_sort(arr):
    new_arr = []

    for i in range(len(arr)):
        new_smallest = find_smallest(arr)
        new_arr.append(arr.pop(new_smallest))
        print(f"Old array: {arr}")
        print(f"New array: {new_arr}\n")

    return new_arr 
    

# Test cases
print(selection_sort([1, 3, 5, 7, 9, 14 ,15 ,16 ,17 ,18 ,19 ,20]))