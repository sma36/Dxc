temp='''Name={0}
Category={1}
Brand={2}
Cost={3}
Rating={4}
Discount={5}

'''


class products:
    def __init__(self,pid,name,category,brand,cost,rating,discount):
        self.pid=pid
        self.name=name
        self.category=category
        self.brand=brand
        self.cost=cost
        self.rating=rating
        self.discount=discount
    def __str__(self):
        return temp.format(self.name,self.category,self.brand,self.cost,self.rating,self.discount)
    
          
li=[
    products(1,"laptop","electronics","HP",40000,7.8,20),
    products(2,"mobile","electronics","Apple",80000,8.8,30),
    products(3,"shoe","clothing","Nike",4000,8.1,15),
    products(4,"shirt","clothing","LV",21000,9.2,5),
    products(5,"shirt","clothing","Arrow",3000,8.5,25),
]

print("Filter By")
x=int(input('''1.Category
2.Brand
3.Name\n
'''))
print()
xy=["category","brand","name"]
for i in li:
    print(i.__dict__[xy[x-1]])

cat=input("Enter the "+xy[x-1]+"\n")

newli=filter((lambda el: el.__dict__[xy[x-1]]==cat),li)

print(*newli) 






