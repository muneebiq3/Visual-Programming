/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package q.pkg1;
import java.util.*;

/**
 *
 * @author Student
 */
public class Q1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Tollbooth t1 = new Tollbooth();
        
        Scanner input = new Scanner(System.in);
        System.out.println("Press P if paying car found, N for non-paying and D for status: ");
        
        while(true) {
            char status = input.next().charAt(0);
            
            switch (status) {
                case 'P':
                case 'p':
                    t1.payingCar();
                    break;
                case 'N':
                case 'n':
                    t1.nonpayingCars();
                    break;
                case 'D':
                case 'd':
                    t1.display();
                    break;
                default:
                    System.out.println("Invalid Input!");
            }
        }
    }
}