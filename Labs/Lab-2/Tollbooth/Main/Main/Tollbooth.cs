using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class Tollbooth {
        private int totalCars;
        private double totalCash;

        public Tollbooth() {
            this.totalCars = 0;
            this.totalCash = 0.0;
        }
        public void payingCar() {
            this.totalCars++;
            this.totalCash += 5;
        }

        public void nonpayingCars() {
            this.totalCars++;
        }

        public void display() {
            Console.WriteLine("Total Cars: " + this.totalCars);
            Console.WriteLine("Total Cash to be collected: " + this.totalCash);
        }
    }
}