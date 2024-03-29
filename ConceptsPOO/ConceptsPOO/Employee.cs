﻿namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDay { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}," +
                $" Birth: {BirthDay}," +
                $" HiringDate: {HiringDate}," +
                $" Is active: {IsActive}";

        }
    }
}