import Pyro4
import random
import os
import datetime
import subprocess
import math

now=datetime.datetime.now()
print('date: '+ now.strftime('%d-%m-%y')+' Time:'+ now.strftime('%H:%M:%S'))

@Pyro4.expose
class Server(object):
    def get_usid(self, name):
        return "Ola, {0}.\n Sua sessão de usuário atual é  {1}:".format(name,random.randint(0,1000))
    def add(self, a, b):
        return "{0} + {1} = {2}".format(a, b, a+b)
    def subtract(self, a, b):
        return "{0} - {1} = {2}".format(a, b, a-b)
    def multiply(self, a, b):
         return "{0} * {1} = {2}".format(a, b, a*b)
    def division(self, a, b):
        return "{0} / {1} = {2}".format(a, b, a/b)
    def exp(self, a):
        return "{0} ** {1} = {2}".format(a, a, a**a)
    def bhas(self, a,b,c):
        raiz1 = (-b + math.sqrt(b*b - 4*a*c))/2*a
        raiz2 = (-b - math.sqrt(b*b - 4*a*c))/2*a
        return "x1 = %.2f e x2 = %.2f"%(raiz1, raiz2)

daemon = Pyro4.Daemon()
ns = Pyro4.locateNS()
url = daemon.register(Server)
ns.register("RMI.calculator", url)
print("O servidor agora está ativo. Solicite seus cálculos")
daemon.requestLoop() 