li=[{"Product_id":101,
"Name":"Laptop",
"Category":"ELectronics",
"Brand":"HP",
"Cost":500000,
"Rating":8.9,
"Discount":30
},
{"Product_id":102,
"Name":"Mobile",
"Category":"Electronics",
"Brand":"Oneplus",
"Cost":30000,
"Rating":9.1,
"Discount":20},
{"Product_id":103,
"Name":"Dress",
"Category":"Clothing",
"Brand":"Zara",
"Cost":3000,
"Rating":9.1,
"Discount":40},
{"Product_id":104,
"Name":"Shoes",
"Category":"Clothing",
"Brand":"Nike",
"Cost":5000,
"Rating":8.5, 
"Discount":20},
{"Product_id":105,
"Name":"Shirt",
"Category":"Clothing",
"Brand":"LV",
"Cost":4000,
"Rating":7.3,
"Discount":40}
]
temp='''Name={Name}
Category={Category}
Brand={Brand}
Cost={Cost}
Rating={Rating}
Discount={Discount}
'''


x=int(input('''1.Cost l-h
2.Cost h-l
3.Rating
4.Discount l-h
5.Discount h-l
'''))
print()
xy=[["Cost",False],["Cost",True],["Rating",True],["Discount",False],["Discount",True]]

li.sort(key=(lambda el:el[xy[x-1][0]]),reverse=xy[x-1][1])
for i in li:
    print(temp.format(**i))


    
               
               
               
               
               
              