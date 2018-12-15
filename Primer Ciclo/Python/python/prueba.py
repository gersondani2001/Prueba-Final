#!/usr/bin/env python
# -*- coding: utf-8 -*-
import time
import os
import webbrowser
y = True
while y == True:
	def info():
		informacion = """
			App magic es una aplicacion de registro de compra y venta
			para encontrar el celular que mas necesite para su bien comun. 
		"""
		print informacion
		j = raw_input("Quiere regresar al inicio si o no ''automaticamente saldra de la aplicacion'': ")
		if j == "si":
			base()
			y = False
		if j == "no":
			exit()
		else:
			print "opcion incorecto"
	def Compra_ven():
		articulos = {"Galaxi mini":5000,"Samsung j6": 3000,"Iphone x":5130,"iphone xs": 12000, "Samsung j5":1200, "samsung j9":5000}
		print"""
		---------------------------
			###################
			Productos en venta
			###################
		---------------------------
		"""
		cont = 0
		for x in articulos:
			cont = cont + 1
			print str(cont) + "." + x + " Q." + str(articulos[x])+".00"
			print "#######################"
		codigo = int(input("Ingrese codigo de producto: "))
		nombre = raw_input("Ingrese nombre del comprador: ")
		apellido = raw_input("Ingrese apellido del comprador: ")
		nit = input("ingrese nit: ")
		direccion = raw_input("Ingrese direccion del comprador: ")
		precio = input("Ingrese precio de su compra: ")
		prod = raw_input("Ingrese nombre del producto: ")
		print """
		-------------------------
		Factura
		-------------------------
		"""
		con = 1
		fac = "*"
		for x in fac :
			print "xxxxx"+fac+"xxxxx"
			print "... N." + str(con)
			print "... " + prod + " #." + str(codigo) 
			print "... Nombre Cliente: " + nombre
			print "... Apellido Cliente: " + apellido
			print "... Abono de impuesto: " + str(nit)
			print "... Direccion del Comprador: " + direccion
			print "... R// precio: Q." + str(precio)
			print "##################################"
			y = False
			K = raw_input("Quiere regresar al compra venta si o no: ")
			if K == "si":
				Compra_ven()
				y = False
			if K == "no":
				base()
				y = False
			else:
				print "opcion no valida vuelba a intentar... "
			con = con + 1
		y = False
	def Marcas():
		marcas = ["Galaxi mini","clorox pdf","Iphone x","iphone xs","Samsung j5","samsung j9","Windows iphone","Samsung 2","Samsung mini galaxi","lilipop motorola"]
		print "Marcas de telefonos en el registro:"
		for x in marcas:
			print "      " + x
		j = raw_input("Quiere regresar al inicio si o no ''automaticamente saldra de la aplicacion'': ")
		if j == "si":
			base()
			y = False
		if j == "si":
			exit()
		else:
			print "incorecto"
	def Ubicacion():
		print "Direccion de la empresa APP MAGIC"
		ubicaciones = ["Anillo Periférico y Pan-American Highway/CA-1 hacia 12 Av..","Guatemala","Centro America Industria de telefonia"]
		for y in ubicaciones:
			print "     " + y 
			print "---------------------------"
		mostrar = raw_input("mostrar ubicacion si o no: ")
		if mostrar == "si" :
			webbrowser.open("https://www.google.com/maps/place/Grand+Tikal+Futura+Hotel/@14.6227385,-90.556054,17z/data=!3m1!4b1!4m5!3m4!1s0x8589a1baa9d16f77:0x6867b4859eecd06e!8m2!3d14.6227333!4d-90.5538653")
			y = False
		elif mostrar =="no" :
			pass
			y = False
		else:
			print "incorecto"
		j = raw_input("Quiere regresar al inicio si o no ''automaticamente saldra de la aplicacion'': ")
		if j == "si":
			base()
			y = False
		if j == "no":
			exit()
		else:
			print "incorecto"
	def base():
		time.sleep(3)
		os.system('cls')
		print"""
			####################################
			###APP MAGIC------------------------
			####################################
			Opciones:
			1.Informacion
			2.Compra y venta de Telefonos
			3.Marcas de Telefonos
			4.Ubicaciones
			5.Salir
			____________________________________
		"""
		x = input("Ingrese el numero de opcion: ")
		if x == 1 :
			y = False
			info()
		if x == 2:
			y = False
			Compra_ven()
		if x == 3:
			y = False
			Marcas()
		if x == 4:
			y = False
			Ubicacion()
		if x == 5:
			y = False
			exit()
		else:
			print "Opcion incorecta"
	base()		
