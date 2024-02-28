/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package q.pkg2;

/**
 *
 * @author Student
 */
public class HourlyEmployee extends Employee{
    private int hourlyIncome;
    
    public HourlyEmployee(String name, int ID, int hourlyIncome) {
        
        this.setName(name);
        this.setID(ID);
        this.hourlyIncome = hourlyIncome;
        
    }
    
    public int calculateIncome(int hours) {
        this.hourlyIncome = 150 * hours;
        return hourlyIncome;
    }
}
