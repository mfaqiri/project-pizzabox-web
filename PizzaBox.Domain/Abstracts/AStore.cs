using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models.Orders;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class AStore : AModels
    {
        
        public string Name{get; set;}
        public List<Order> orders = new List<Order>();
        //public string country{get; protected set;}
        //public string address{get; protected set;}

        public void SortOrder()
        {

        }

        private void SortByQuarter()
        {

        }

        private void SortByYear()
        {

        }

        private void SortByMonth()
        {

        }

        private void SortByWeek()
        {
            
        }

        private void SortByDay()
        {
            
        }

    }
}