def factorial(x):
    if x == 1:
        return 1
    
    else:
        print(f"Returning {x} * factorial({x - 1})")
        return x * factorial(x - 1)

print(factorial(5))