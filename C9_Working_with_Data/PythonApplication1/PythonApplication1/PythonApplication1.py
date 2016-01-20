import urllib
from bs4 import BeautifulSoup
from pymongo import MongoClient

client = MongoClient('localhost', 27017)
db = client.test
url = 'http://elpais.com/?cp=1'
html = urllib.urlopen(url).read()
sopa = BeautifulSoup(html, "html.parser")
enlaces =sopa.find_all("a", {"title":"Ver Noticia"})
enlaceList = []
for enlace in enlaces:
    content = urllib.urlopen(enlace['href']).read()
    sopa = BeautifulSoup(content, "html.parser")
    contentText = sopa.find("div", {"class":"cuerpo_noticia"})
    try:
        new = News(enlace.text, contentText.text, enlace['href'])
        temaList = []
        for i in enlaceList:
            temaList.append(i.name)
            print (i.name)

        if new.name in temaList:
            pass
        else:
            enlaceList.append(new)
            insert_new = db.new.insert_one({'name': enlace.text, 'periodico': 'elpais', 'url':enlace['href'], 'content':contentText.text.strip()})
    except:
        pass
