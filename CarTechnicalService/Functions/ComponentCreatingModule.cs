using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTechnicalService.Objects;

namespace CarTechnicalService.Functions
{
    public class ComponentCreatingModule
    {
        Component component = new Component();
        public Component CreateAndAttachComponent(Car car)
        {
            if (car.AdditionalComponent == null)
            {
                component.Name = car.AdditionalComponent;
                component.CodeOfComponent = car.AdditionalComponentCode;
            }
            else
                return null;

            return component;
        }
    }
}