package org.instituserperpis.ed;
import java.math.BigDecimal;
import java.util.Scanner;
public class suma {

	public static void main(String[] args) {
		Scanner Scanner= new Scanner (System.in);
		System.out.println("programa suma");
		System.out.println("Introduce el primero: ");
		String primerNumero= Scanner.nextLine();
		BigDecimal primero= new BigDecimal(primerNumero);
		System.out.println("    Introduce el segundo");
		String segundonumero= Scanner.nextLine();
		BigDecimal segundo= new BigDecimal(segundonumero);
		BigDecimal suma= primero.add(segundo);
		System.out.println("    La suma es " +suma);

	}

}
