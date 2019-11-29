def createWallet(balance,username):
    def deposit(amt):
        nonlocal balance
        balance+=amt
        nonlocal username
        print(username+" deposited ",amt,"Balance = ",balance)
    def withdraw(amt):
        nonlocal balance
        if balance>amt:
            balance-=amt
            nonlocal username
            print(username+" withdraw ",amt,"Balance = ",balance)
        else:
            print("Cannot withdraw")
    
    def show():
        nonlocal balance        
        nonlocal username
        print(username+" Balance = ",balance)
        
    
    return {"deposit":deposit,"withdraw":withdraw,"show":show}

user1=createWallet(500,"Swati")
user1["deposit"](800)
user1["withdraw"](200)
user1["show"]()
print()

user2=createWallet(1000,"Ankush")
user2["deposit"](700)
user2["withdraw"](200)
user2["show"]()
print()

def transfer(u1,u2,amt):
        u1["withdraw"](amt)
        u2["deposit"](amt)

transfer(user1,user2,500)

user1["show"]()
user2["show"]()