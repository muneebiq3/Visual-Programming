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
public class Person {
    
    private String name;
    private int age;
    private long phoneNumber;
    private String email;
    
    Person(){}
    
    Person(String name, int age, long phoneNumber, String email) {
        
        this.name = name;
        this.age = age;
        this.phoneNumber = phoneNumber;
        this.email = email;
        
    }
    
    public void setName(String name) {
        this.name = name;
    }
    
    public String getName() {
        return name;
    }
    
    public void setAge(int age) {
        this.age = age;
    }
    
    public int getAge() {
        return age;
    }
    
    public void setPhoneNumber(long phoneNumber) {
        this.phoneNumber = phoneNumber;
    }
    
    public long getPhoneNumber() {
        return phoneNumber;
    }
    
    public void setEmail(String email) {
        this.email = email;
    }
    
    public String getEmail() {
        return email;
    }
    
    public void behaviour() {
        System.out.println("Existing!");
    }
    
}