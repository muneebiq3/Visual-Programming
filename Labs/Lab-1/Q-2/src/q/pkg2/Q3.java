/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package q.pkg2;
import java.util.*;
/**
 *
 * @author Student
 */
public class Q3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner input = new Scanner(System.in);
        
        System.out.print("Enter your name: ");
        String name = input.next();
        
        System.out.print("Enter your ID: ");
        int ID = input.nextInt();
        
        System.out.print("Enter the hours you've worked so far: ");
        int hours = input.nextInt();
        
        HourlyEmployee h1 = new HourlyEmployee(name, ID, hours);
        
        System.out.println("Calculated income of Hourly Employee: " + h1.calculateIncome(hours));
        
        System.out.print("Enter your name: ");
        name = input.next();
        
        System.out.print("Enter your ID: ");
        ID = input.nextInt();
        
        System.out.print("Enter the hours you've worked so far: ");
        hours = input.nextInt();
        
        PermanentEmployee p1 = new PermanentEmployee(name, ID, hours);
        
        System.out.println("Calculated income of Permanent Employee: " + p1.calculateIncome());
        
    }
    
}
