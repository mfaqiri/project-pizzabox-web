
using System.Collections.Generic;
using PizzaBox.Domain.Models.Orders;

namespace PizzaBox.Domain.Abstracts
{

    

    public abstract class APizzaType : AModels
    {

        public bool isCustom{get; protected set;}        
        public string Name{get;protected set;}
        public List<string> predefinedToppings{get;}

    }
}