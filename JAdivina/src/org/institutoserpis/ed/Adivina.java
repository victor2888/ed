package org.institutoserpis.ed;
import java.util.*;
public class Adivina {

	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Random random=new Random();
		int numeroaleatorio;
		numeroaleatorio=random.nextInt(1000) +1;
		int num;
		Scanner scanner=new Scanner (System.in);
		boolean acertado;
		int contadorIntentos = 0;
		do{
			contadorIntentos++;
			System.out.printf("Introduce el numero (intento nº %d): ", contadorIntentos);
			String line=scanner.nextLine();
			num= Integer.parseInt(line);
			
			if(num<numeroaleatorio){
				System.out.println("Es mas pequeño que el numero aleatorio,te has quedado corto sigue intentandolo);");
			}
			 
			if(num>numeroaleatorio){
				System.out.println("El numero es mas mayor que el numero aleatorio, te has pasado, sigue intentandolo");
				}
			acertado = num == numeroaleatorio;
		} while (!acertado);
		System.out.printf
		
			
	}
}

