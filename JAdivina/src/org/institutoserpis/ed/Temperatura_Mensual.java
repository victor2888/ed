package org.institutoserpis.ed;
import javax.swing.*;

public class Temperatura_Mensual {
	
	static int MAX = 5;
	int tempSup = 25;
	
	int[] almacenaArray(){
		
		int []arreglo = new int[MAX];
		String cadena;
		
		for(int i = 0; i < MAX; i++){
			
			do{
				cadena = JOptionPane.showInputDialog("Ingrese Temperatura"+(i+1)+":");
				arreglo[i] = Integer.parseInt(cadena);
				if((arreglo[i]<5)|| (arreglo[i]>40)){
					JOptionPane.showMessageDialog(null, "La temperatura debe ser de 5 y 40.");
				}
			}while((arreglo[i]<5)|| (arreglo[i]>40));
				
		}
		return arreglo;
	}
	int temperaturaSuperada(int array[]){
		
		int contador = 0;
		
		for(int i = 0; i < array.length; i++){
			if(array[i] > tempSup){
				contador = contador+1;
			}
		}
		JOptionPane.showMessageDialog(null, "Las temperaturas mayores a"+tempSup+"son: "+contador);
		return contador;
	}
	int promedioTemperaturaSuperior(int temperaturaSuperiorA, int array[] ){
		
		int contador =0, acu = 0;
		double promedioTemp = 0;
		
		for(int i = 0; i < array.length; i++){
			if(array[i] > tempSup){
				acu = acu+array[i];
			}
		}
		promedioTemp = acu/temperaturaSuperiorA;
		JOptionPane.showMessageDialog(null, "El promedio de la temperaturas superiores a"+tempSup+"es: "+promedioTemp);
		return 0;
	}
	void temperaturaMaximaMensual(int array[]){
		
		int tmp = 0;
		String cad = "";
		int array2[] = new int[MAX];
		
		for (int i = 0; i < array.length; i++){
			array2[i] = array[i];
		}
		
		int k = 0, x = 0, c = 0;
		for(int i = 1 ; i < array.length; i++){
			if(array2[i-1] <array2[i]){
				x=i; c++;
			}
			for(int j = 0; j < array.length-i; j++){
				if(array2[j] > array2[j+1]){
					k = array2[j+1]; array2[j+1]=array2[j]; array2[j]=k;
				}
			}
		}
		JOptionPane.showMessageDialog(null, "La temperatura: "+array2[MAX-1]+ "Dia: "+(x-1));
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] array = new int[MAX];
		int temperaturaSuperiorA = 0;
		int opcion = 0;
		int sup =25, retro = 0;
		String cadena = "";
		Temperatura_Mensual temperatura = new Temperatura_Mensual();
		
		do{
			array = temperatura.almacenaArray();
			
			do{
				retro = 1;
				cadena = JOptionPane.showInputDialog("Seleccione una opción: \n 1)Temperatura Maxima del Mes. \n 2)Temperatura superior a "+sup+" ºC. \n 3) Promedio a las temperaturas superiores a"+sup+"ºC. \n 4)Reiniciar. \n 5)Salir" );
				opcion = Integer.parseInt(cadena);
				
				switch(opcion){
				
				case 1:temperatura.temperaturaMaximaMensual(array);break;
				case 2:temperaturaSuperiorA=temperatura.temperaturaSuperada(array);break;
				case 3:
					
				
					if(temperaturaSuperiorA>0){
					temperatura.promedioTemperaturaSuperior(temperaturaSuperiorA,array);
					}else{
					JOptionPane.showMessageDialog(null, "no hay temperaturas superiores a" +sup);
					}break;
				case 4:retro=0;break;
				case 5:System.exit(0);
				}
			}while(retro==1);
		}while(retro==0);
		
	}

}
