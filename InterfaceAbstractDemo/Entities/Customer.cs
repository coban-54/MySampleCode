﻿using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalId { get; set; }
    }
}