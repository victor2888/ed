package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
//		int index = 0;
//		while (index < 5){
//			System.out.println("index=" +index);
//			index++;
//		}
//		System.out.println("fuera del ciclo index=" +index);
		int[] v= new int[]{32, 15, 7, 9, 12};
//		for(int index=0; index <v.length;index++){
//			System.out.println(v[index]);
//		}
//		System.out.println("indexOf=" + indexOf(v, 32));
		
	}
	


	public static int indexOf (int[] v, int data){
//	int index = 0;
//	while (index < v.length && v[index] != data)
//		index++;
//	if(index == v.length)
//		return -1;
//	return index;
	int index=0;
	for (int item : v){
		if (item==data)
			return index;
		index++;
		}
	return -1;
	
	}
	
	public static int min (int[] v){
		int min= v[0];
//		for(int index=1; index<v.length;index++){
//			if(v[index]<min){
//				min= v[index];
		for (int item : v){
			if(item<min){
				min = item;
			
		
				
			}
		}
		return min;
	}
			
}		

		