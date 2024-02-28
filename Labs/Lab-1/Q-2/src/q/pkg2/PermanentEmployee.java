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
public class PermanentEmployee extends Employee{
    private int hourlyIncome;
    
    public PermanentEmployee(String name, int ID, int hourlyIncome) {
        
        this.setName(name);
        this.setID(ID);
        this.hourlyIncome = hourlyIncome;
        
    }
    public int calculateIncome() {
        this.hourlyIncome = 240 * 150;
        return hourlyIncome;
    }
}
