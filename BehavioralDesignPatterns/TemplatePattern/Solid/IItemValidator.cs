using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern.Solid
{
    public interface IItemValidator
    {
        void ValidateItem();
    }
    public class ItemValidator : IItemValidator
    {
        public void ValidateItem()
        {
            Console.WriteLine("Item validated");
        }
    }
}