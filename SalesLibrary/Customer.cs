using System;
using System.Collections.Generic;
using System.Text;

namespace AccessTernary {
    public class Customer {
        public override string ToString() {
            return $"Id={this.Id},Name={this.Name},NAcct={this.IsNationalAccount}";
        }
        private static int NextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }
        static Customer() {
            // read file to get the next id to be assigned
            NextId = 21;
        }
        public void NationalAccount(string YesOrNo) {
            this.IsNationalAccount = YesOrNo.Equals("yes") ? true : false;
        }
        public static string PrintNextId() {
            return ($"Next id is {NextId}");
        }
        public Customer(string Name) {
            this.Name = Name;
            this.Id = NextId;
            NextId++;
        }
    }
}