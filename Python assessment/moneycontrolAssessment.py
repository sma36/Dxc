import re
import urllib.request as urllib
from bs4 import BeautifulSoup


r=urllib.urlopen('https://moneycontrol.com').read()

soup=BeautifulSoup(r, 'html.parser')


for i in soup.find_all("div",attrs={"id":"tlNifty"}):
    for j in i.find_all("a"):
        if j.string!="See all  »":
            print(j.string)
