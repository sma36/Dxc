
#pattern 1
y=int(input("Enter number of lines: "))
i=1
while i<=y:
    print("*"*i)
    i+=1
    
#pattern 2
y=int(input("Enter number of lines: "))
i=y
while i>=1:
    print(" "*(y-i),end="")
    print("*"*i)
    i-=1
    
#pattern 3
y=int(input("Enter number of lines: "))
i=y
while i>=1:    
    print("*"*i)
    i-=1
    
#pattern 4
y=int(input("Enter number of lines: "))
i=1
while i<=y:
    print(" "*(y-i),end="")
    print("*"*i)
    i+=1
    
#pattern 5
y=int(input("Enter number of lines: "))
i=1
while i<=y:
    print(" "*(y-i),end="")
    print("* "*i)
    i+=1  
    
    
#pattern 6
y=input("Enter String ")
i=1
l=len(y)
while i<=l:
    print(" "*(l-i),end="")
    print(y[:i])
    i+=1