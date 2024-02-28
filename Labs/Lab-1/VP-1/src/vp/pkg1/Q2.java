/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vp.pkg1;
import java.util.*;

/**
 *
 * @author Student
 */
public class Q2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input = new Scanner(System.in);
        
        System.out.print("Enter your name: ");
        String name = input.next();
        
        System.out.print("Enter your age: ");
        int age = input.nextInt();
        
        System.out.print("Enter your phone number: +92");
        long phoneNumber = input.nextLong();
        
        System.out.print("Enter your email: ");
        String email = input.next();
        
        Person p1 = new Person(name, age, phoneNumber, email);
        System.out.print("Person: ");
        p1.behaviour();
        
        System.out.print("Enter your name: ");
        name = input.next();
        
        System.out.print("Enter your age: ");
        age = input.nextInt();
        
        System.out.print("Enter your phone number: +92");
        phoneNumber = input.nextLong();
        
        System.out.print("Enter your email: ");
        email = input.next();
        
        Student s1 = new Student(name, age, phoneNumber, email);
        System.out.print("Student: ");
        s1.behaviour();
        
        System.out.print("Enter your name: ");
        name = input.next();
        
        System.out.print("Enter your age: ");
        age = input.nextInt();
        
        System.out.print("Enter your phone number: +92");
        phoneNumber = input.nextLong();
        
        System.out.print("Enter your email: ");
        email = input.next();
        
        Teacher t1 = new Teacher(name, age, phoneNumber, email);
        System.out.print("Teacher: ");
        t1.behaviour();
  
    }
    
}
