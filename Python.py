print("")
print("En cada ronda del juego del cachipún, los dos competidores deben elegir entre jugar tijera, papel o piedra. " +
		"Las reglas para decidir quién gana la ronda son: tijera le gana a papel, papel le gana a piedra, piedra le gana a tijera," +
		" y todas las demás combinaciones son empates. El ganador del juego es el primero que gane tres rondas. " + 
		"Escriba un programa que pregunte a cada jugador cuál es su jugada, muestre cuál es el marcador después de cada ronda, " +
		" y termine cuando uno de ellos haya ganado tres rondas. Los jugadores deben indicar su jugada escribiendo: tijera, papel o piedra.")
print("")

#Declaramos las variables contador
contador1 = 0
contador2 = 0

#Bucle infinito para repetir el proceso hasta romperlo
while True:

	#Bloque para el manejo de excepciones
	try:

		#Declaramos la variable que guarda el mensaje de la ronda
		mensaje = ""

		#Bucle infinito para repetir el proceso hasta romperlo
		while True:

			#Solicitamos al jugador uno que ingrese su elección
			jugador1 = input("J1 elija entre piedra, papel o tijera: ")

			#Si el jugador uno realizó un ingreso diferente al solicitado se le indica por pantalla
			if (jugador1 != "piedra" and jugador1 != "papel" and jugador1 != "tijera"):
				print("Sólo puede ingresar piedra, papel o tijera.")

			#Caso contrario se rompe el bucle
			else:
				break

		#Bucle infinito para repetir el proceso hasta romperlo
		while True:

			#Solicitamos al jugador dos que ingrese su elección
			jugador2 = input("J2 elija entre piedra, papel o tijera: ")

			#Si el jugador dos realizó un ingreso diferente al solicitado se le indica por pantalla
			if (jugador2 != "piedra" and jugador2 != "papel" and jugador2 != "tijera"):
				print("Sólo puede ingresar piedra, papel o tijera.")
			
			#Caso contrario se rompe el bucle
			else:
				break

		#Si el ingreso de ambos jugadores es el mismo se establece como empate
		if (jugador1 == jugador2):
			mensaje = "Empate"

		#Si J1 elije piedra y J2 tijera o J1 elije papel y J2 piedra o J1 elije tijera y J2 papel el ganador de la ronda es el jugador uno
		elif ((jugador1 == "piedra" and jugador2 == "tijera") or (jugador1 == "papel" and jugador2 == "piedra") or (jugador1 == "tijera" and jugador2 == "papel")):
			mensaje = "J1 gana ronda"

			#Se aumenta en uno el contador de J1
			contador1 = int(contador1) + 1
		
		#Caso contrario el ganador de la ronda es el jugador dos
		else:
			mensaje = "J2 gana ronda"

			#Se aumenta en uno el contado de J2
			contador2 = int(contador2) + 1
		
		#Mostramos el mensaje de la ronda y el marcador
		print(mensaje)
		print("Marcador: " + str(contador1) + " - " + str(contador2))

		#Si el contador de J1 es mayor al contador de J2 y el contador de J1 es mayor o igual a 3
		#El ganador es el jugador uno y se rompe el bucle
		if (int(contador1) > int(contador2) and int(contador1) >= 3):
			print("J1 gana el juego")
			break
		
		#si el contador de J2 es mayor al contador de J1 y el contador de J2 es mayor o igual a 3
		#El ganador es el jugador dos y se rompe el bucle
		elif (int(contador2) > int(contador1) and int(contador2) >= 3):
			print("J2 gana el juego")
			break

	except Exception as e:
		print("Ha ocurrido un error, intente nuevamente.")
		print(e)