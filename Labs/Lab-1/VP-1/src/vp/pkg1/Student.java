/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vp.pkg1;

/**
 *
 * @author Student
 */
public class Student extends Person{
    
    Student(){}
    
    Student(String name, int age, long phoneNumber, String email) {
        
        this.setName(name);
        this.setAge(age);
        this.setPhoneNumber(phoneNumber);
        this.setEmail(email);
        
    }
    
    @Override
    public void behaviour(){
        System.out.println("Paying fees!");
    }
    
}
