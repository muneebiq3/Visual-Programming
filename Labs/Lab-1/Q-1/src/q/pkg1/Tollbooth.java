/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package q.pkg1;

/**
 *
 * @author Student
 */
public class Tollbooth {
    
    private int totalCars;
    private double totalCash;
    
    public Tollbooth() {
        this.totalCars = 0;
        this.totalCash = 0.0;
    }
    public void payingCar() {
        this.totalCars ++;
        this.totalCash += 5;
    }
    
    public void nonpayingCars() {
        this.totalCars ++;
    }
    
    public void display() {
        System.out.println("Total Cars: " + this.totalCars);
        System.out.println("Total Cash to be collected: " + this.totalCash);
    }
    
}
