Algoritmo proyecto_AppMagic
	Definir cod,nit,cont Como Entero
	Definir sal,nombre,apellido,salt,prod Como Caracter
	Definir precio Como Real
	Repetir
		// mostrar menu
		Borrar Pantalla
		Escribir 'App Magic: Opciones'
		Escribir '   1. Informacion'
		Escribir '   2. Compra y venta de productos'
		Escribir '   3. Marcas de Telefonos'
		Escribir '   4. Ubicacion'
		Escribir '   5. Salir'
		// ingresar una opcion
		Escribir 'Elija una opción: '
		Leer OP
		// procesar esa opción
		Segun OP  Hacer
			1:
				// La informacion
				Escribir 'Informacion:'
				Escribir ' + Es una empresa de compra y venta de dispositivos electronicos (Gerson Boche)'
				Escribir ' + App Magic esta es la empresa de comercio empresarial de compra y venta de celulares (Orson Scott Card)'
				Escribir ' + Es la empresa mas grande de Guatemala de comercio de dispositivos electronicos  (Adolfo Bioy Casares)'
				Escribir 'Regresar a inicio: '
			2:
				Repetir
					// Compra y venta
					Escribir 'Telefonos en compra y venta'
					Escribir ' 1.+ Celulares Samsung. samsung j9.                      Q3,000.00'
					Escribir ' 2.+ Celulares Celulares Huawei. huawei y5 lite          Q4,000.00'
					Escribir ' 3.+ Celulares Nokia. tokialite .                        Q3,500.00'
					Escribir ' 4.+ Celulares Alcatel.  BlackBerry.                     Q1,200.00'
					Escribir ' 5.+ Celulares Sony Ericsson. lilipop firefox300         Q5,000.00'
					Escribir ' 6.+ Celulares Apple. Iphone xs.                         Q2,250.00'
					Escribir ' 7.+ Celulares BLU. tklite200.                           Q1,525.00'
					Escribir 'Escoja su compra y rellene los requisitos'
					Escribir 'Nombre Cliente: '
					Leer nombre
					Escribir 'Apellido Cliente: '
					Leer apellido
					Escribir 'Direccion: '
					Leer direccion
					Escribir 'Codigo del producto: '
					Leer cod
					Escribir 'Nombre del producto: '
					Leer prod
					Escribir 'Precio del producto: '
					Leer precio
					Escribir 'Marca del producto: '
					Leer marca
					Escribir 'Nit del cliente: '
					Leer nit
					cont <- cont+1
					// factura de la compra
					Escribir '######## Factura ########'
					Escribir '*******************no.',cont
					Escribir '...'+nombre
					Escribir '...'+apellido
					Escribir '...'+direccion
					Escribir '...',cod
					Escribir '...'+prod
					Escribir '... Q.',precio,'.00'
					Escribir '...'+marca
					Escribir '...',nit
					Escribir '#########################'
					Escribir 'Desea continuar si o no: '
					Leer salt
				Hasta Que salt='no'
			3:
				// Registro
				Escribir 'Marcas de telefono registradas para la compra y venta de dispositivos electronicos:'
				Escribir 'Telefonos en compra y venta'
				Escribir ' + Celulares Samsung. Celulares LG. '
				Escribir ' + Celulares Motorola. Celulares Huawei.'
				Escribir ' + Celulares Nokia. Celulares Sony. '
				Escribir ' + Celulares Alcatel. Celulares BlackBerry. '
				Escribir ' + Celulares Sony Ericsson. Celulares HTC. '
				Escribir ' + Celulares Apple. Celulares ZTE. '
				Escribir ' + Celulares BLU. Celulares Xiaomi.'
			4:
				// Ubicacion
				Escribir 'Ubicacion:'
				Escribir '4ta Avenida 11-12 Zona 3, Ciudad Capital, Guatemala'
				Escribir ' + Terminal Velocity (Terminal Reality/3D Realms, 1995)'
				Escribir ' + Death Rally (Remedy/Apogee, 1996)'
				Escribir 'Ubicacion mapa: https://www.google.com/maps/place/Grand+Tikal+Futura+Hotel/@14.6227385,-90.556054,17z/data=!3m1!4b1!4m5!3m4!1s0x8589a1baa9d16f77:0x6867b4859eecd06e!8m2!3d14.6227333!4d-90.5538653'
			5:
				// Salir del programa
				Escribir 'Gracias, vuelva prontos'
			De Otro Modo:
				// Direccion
				Escribir 'Opción no válida'
		FinSegun
		Escribir 'Presione enter para continuar'
		Esperar Tecla
	Hasta Que OP=5
FinAlgoritmo

