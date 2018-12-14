from random import randint as ri

class MonteCarlo():
  
  def flipCoin(numberOfFlip):
    arrayNumb = []
    arrayNumb2 = []
   
    for i in range(numberOfFlip):
      randNumb = ri(0, 1)
      randNumb2 = ri(0, 1)
     # print(randNumb)
      arrayNumb.append(randNumb)
      arrayNumb2.append(randNumb2)
    print(arrayNumb)
    print(arrayNumb2)
    
    AA = 0 #AA = 00
    AG = 0 #AG = 01 / 01
    GG = 0 #GG = 11

    for i in range(len(arrayNumb)):
      if arrayNumb[i] == 0 and arrayNumb2[i] == 0:
        AA += 1
      elif arrayNumb[i] == 0 and arrayNumb2[i] == 1 or arrayNumb[i] == 1 and arrayNumb2[i] == 0: 
        AG += 1
      elif arrayNumb[i] == 1 and arrayNumb2[i] == 1:
        GG += 1
        
    print("Banyaknya Muncul AA",AA)
    print("Banyaknya Muncul AG/GA", AG)
    print("Banyaknya Muncul GG", GG)

    print("Probabilitas AA :", AA/len(arrayNumb))
    print("Probabilitas AG/GA :", AG/len(arrayNumb))
    print("Probabilitas GG :", GG/len(arrayNumb))

  input = int(input("Banyaknya Percobaan : "))
  flipCoin(input)
MonteCarlo()
