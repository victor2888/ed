package org.institutoserpis.ed;
import java.util.*;
public class Adivina {

	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Random random=new Random();
		int numeroaleatorio;
		numeroaleatorio=random.nextInt(1000) +1;
		int num;
		Scanner Scanner=new Scanner (System.in);
		do{
			System.out.println("Introduce numero");
			String line=Scanner.nextLine();
			num= Integer.parseInt(line);
			
			if(num<numeroaleatorio){
				System.out.println("Es mas pequeño que el numero aleatorio,te has quedado corto sigue intentandolo);");
			}
			else 
				if(num>numeroaleatorio){
					System.out.println("El numero es mas mayor que el numero aleatorio, te has pasado, sigue intentandolo");
				}
		} while (num!=numeroaleatorio);
		System.out.println("Muy bien has acertado, campeon");
		
			
	}
}

