import Pyro4
import os
import datetime
import math

Client = Pyro4.Proxy("PYRONAME:RMI.calculator")
now=datetime.datetime.now()
print('Data: '+now.strftime('%d-%m-%y')+' hora:'+now.strftime('%H:%M:%S'))
name =input("Qual o seu nome? ").strip()
print(Client.get_usid(name))
print("Insira o número de cálculos a serem feitos ")
n=int(input("Insira n: "))
while (n>0):
    n=n-1
    print("Digite o número para os cálculos desejados: \n "+ '1.adição \n' + '2.subtração \n' 
    + '3.multiplicação \n' + '4.DIVISÃO \n' + '5.EXPONENTIAÇÃO \n' + '6.bhaskara \n ')
    c=int(input('Digite sua escolha: '))
    if (c==1):
        a =int(input("Insira a: "))
        b =int(input("Insira b: "))
        print(Client.add(a,b))
    elif (c==2):
        a =int(input("Insira a: "))
        b =int(input("Insira b: "))
        print(Client.subtract(a,b))
    elif (c==3):
        a =int(input("Insira a: "))
        b =int(input("Insira b: "))
        print(Client.multiply(a,b))
    elif (c==4):
        a =int(input("Insira a: "))
        b =int(input("Insira b: "))
        print(Client.division(a,b))
    elif (c==5):
        a =int(input("Insira a: "))
        print(Client.exp(a))
    elif (c==6):
        a =int(input("Insira a: "))
        b =int(input("Insira b: "))
        c =int(input("Insira c: "))
        print(Client.bhas(a,b,c))
    else:
        print('Escolha invalida')