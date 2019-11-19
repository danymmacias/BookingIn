using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentalsof
{
    class Command
    {
        /// Solicutud para agregar un item a una categoria
        public class AddCommand : Category 
        {
            public Item item;
            private Category category;
           
            //public AddCommand(Item item, Category category)
            //{
            //    this.item = item;
            //    this.category = category;
            //}
            
            public void Execute()
            {
                item.Add(category);
                category.Add(item);
            }
        }

        public class Category
        { 
            /// Almacena los Items de la categoria en forma <clave, valor>
            public Dictionary<string, Item> Items;
            /// Descripcion de la categoria
            private String desc;

            public Category(String s)
            {
                desc = s;
                Items = new Dictionary<string, Item>();
            }

            public String GetDesc()
            {
                return desc;
            }

            public void Add(Item i)
            {
                Items.Add(i.GetDesc(), i);
                Console.WriteLine("Item '" + i.GetDesc() + "' has been added to the '"
                        + GetDesc() + "' Category ");
            }

            public void Delete(Item i)
            {
                Items.Remove(i.GetDesc());
                Console.WriteLine("Item '" + i.GetDesc()
                        + "' has been deleted from the '" + GetDesc() + "' Category ");
            }

            public interface CommandInterface
            {
                void Execute();
            }

            /// Solicitud para borrar un item de una categoria
            public class DeleteCommand : CommandInterface
            {
                public Item item;
                public Category category;

                public DeleteCommand(Item item, Category category)
                {
                    this.item = item;
                    this.category = category;
                }

                public void Execute()
                {
                    item.Delete(category);
                    category.Delete(item);
                }
            }

            /// Representa un item de una libreria
            public class Item
            {
                /// Almacena las categorias del Iem en forma <clave, valor>
                private Dictionary<string, Category> Categories;
                /// Descripcion del item
                private String Desc;

                public Item(String s)
                {
                    Desc = s;
                    Categories = new Dictionary<string, Category>();
                }

                public String GetDesc()
                {
                    return Desc;
                }

                public void Add(Category cat)
                {
                    Categories.Add(cat.GetDesc(), cat);
                }

                public void Delete(Category cat)
                {
                    Categories.Remove(cat.GetDesc());
                }
            }

            /// Clase invocadora, donde todo se manda a llamar
            public class ItemManager
            {
                CommandInterface Command;

                public void SetCommand(CommandInterface c)
                {
                    Command = c;
                }

                public void Process()
                {
                    Command.Execute();
                }
            }
        }
    }
}
