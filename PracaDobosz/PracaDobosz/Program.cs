using PracaDobosz;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to console app of shop warehouse here You can add,delete and edit products and warehouse adress. You can also manage product avibility in warehouses.");
        //zmiena kontrolna
        int p = 0;
        //listy
        List<product> products= new List<product>();
        List<warehouse> warehouses= new List<warehouse>();
        // ten while odpowiada za ciągłość menu
        while(p != 9)
        {
            Console.WriteLine("Select one option:");
            Console.WriteLine("1.Add product\n2.Delete product\n3.Edit product");
            Console.WriteLine("4.Add warehouse\n5.Delete warehouse\n6.Edit warehouse");
            Console.WriteLine("7.Add product to warehouse\n8.Delete product from warehouse");
            Console.WriteLine("9.Exit console app");
            //try do wykrycia i obsłuzenia błedów
            try
            {
                //dodawanie produktow
                p=Convert.ToInt32(Console.ReadLine());
                if(p == 1)
                {
                    Console.WriteLine("Type producer name:");
                    string producer_name = Console.ReadLine();
                    Console.WriteLine("Type product name:");
                    string product_name=Console.ReadLine();
                    Console.WriteLine("Type category:");
                    string category=Console.ReadLine();
                    Console.WriteLine("Type product code:");
                    int product_code=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type price:");
                    int price=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type product description");
                    string description=Console.ReadLine();
                    products.Add(new product(producer_name, product_name, category, product_code, price, description));
                }
                //odejmowanie produktow
                if(p == 2)
                {

                    Console.WriteLine("Choose product to delete");
                    int i = 0;
                    foreach (product product in products)
                    {
                        int d = i + 1;
                        Console.WriteLine(d + "." + products[i].product_name);
                        i++;
                    }
                    int x=Convert.ToInt32(Console.ReadLine());
                    products.RemoveAt(x - 1);
                }
                //Edytowanie produktow
                if (p == 3)
                {
                    Console.WriteLine("Chosse product to edit by number");
                    int i = 0;
                    foreach (product product1 in products)
                    {
                        int d = i + 1;
                        Console.WriteLine(d+"."+products[i].product_name);
                        i++;
                    }
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type producer name:");
                    string producer_name = Console.ReadLine();
                    Console.WriteLine("Type product name:");
                    string product_name = Console.ReadLine();
                    Console.WriteLine("Type category:");
                    string category = Console.ReadLine();
                    Console.WriteLine("Type product code:");
                    int product_code = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type price:");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type product description");
                    string description = Console.ReadLine();
                    product product=new product(producer_name, product_name, category, product_code, price, description);
                    products[x - 1] = product;
                }
                //Dodawanie magazynu
                if (p == 4)
                {
                    Console.WriteLine("Type street:");
                    string street=Console.ReadLine();
                    Console.WriteLine("Type post-code:");
                    string post_code=Console.ReadLine();
                    Console.WriteLine("Type city:");
                    string city=Console.ReadLine();
                    Console.WriteLine("Type possesion number:");
                    string possesion_number=Console.ReadLine();
                    Console.WriteLine("Type flat number:");
                    string flat_number=Console.ReadLine();
                    warehouse warehouse=new warehouse(null,new Adress(street,post_code,city,possesion_number,flat_number));
                    warehouses.Add(warehouse);

                }
                //usuwanie magazynu
                if (p==5)
                {
                    try
                    {
                        Console.WriteLine("Choose warehouse to delete");
                        int i = 0;
                        foreach (warehouse warehouse in warehouses)
                        {
                            int d = i + 1;
                            Console.WriteLine(d + "." + warehouses[i].warehouse_adress.street);
                            i++;
                        }
                        int x = Convert.ToInt32(Console.ReadLine());
                        warehouses.RemoveAt(x - 1);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That warehouse dosen't exist");
                    }
                }
                //edytowanie magazynu
                if (p == 6)
                {
                    int x = 0;
                    try
                    {
                        Console.WriteLine("Choose warehouse to edit");
                        int i = 0;
                        foreach (warehouse warehouse1 in warehouses)
                        {
                            int d = i + 1;
                            Console.WriteLine(d + "." + warehouses[i].warehouse_adress.street);
                            i++;
                        }
                        x = Convert.ToInt32(Console.ReadLine());
                        warehouses[x - 1] = null;
                        Console.WriteLine("Type street:");
                        string street = Console.ReadLine();
                        Console.WriteLine("Type post-code:");
                        string post_code = Console.ReadLine();
                        Console.WriteLine("Type city:");
                        string city = Console.ReadLine();
                        Console.WriteLine("Type possesion number:");
                        string possesion_number = Console.ReadLine();
                        Console.WriteLine("Type flat number:");
                        string flat_number = Console.ReadLine();
                        warehouse warehouse = new warehouse(null, new Adress(street, post_code, city, possesion_number, flat_number));
                        warehouses[x - 1] = warehouse;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That warehouse dosen't exist");
                        
                    }
                    

                }
                //Dodawanie produktu do magazynu
                if (p == 7)
                {
                    Console.WriteLine("Choose product to add");
                    int i = 0;
                    foreach (product product in products)
                    {
                        int d = i + 1;
                        Console.WriteLine(d + "." + products[i].product_name);
                        i++;
                    }
                    int x=Convert.ToInt32(Console.ReadLine())-1;
                    Console.WriteLine("Choose warehouse to add product");
                    i = 0;
                    foreach (warehouse warehouse1 in warehouses)
                    {
                        int d = i + 1;
                        Console.WriteLine(d + "." + warehouses[i].warehouse_adress.street);
                        i++;
                    }
                    int y=Convert.ToInt32(Console.ReadLine())-1;
                    warehouses[y].products1.Add(products[x]);

                }
                //usuwanie produktow z magazynu
                if (p == 8)
                {
                    try {
                        Console.WriteLine("Choose product to delete");
                        int i = 0;
                        foreach (product product in products)
                        {
                            int d = i + 1;
                            Console.WriteLine(d + "." + products[i].product_name);
                            i++;
                        }
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Choose warehouse to delete product");
                        i = 0;
                        foreach (warehouse warehouse1 in warehouses)
                        {
                            int d = i + 1;
                            Console.WriteLine(d + "." + warehouses[i].warehouse_adress.street);
                            i++;
                        }
                        int y = Convert.ToInt32(Console.ReadLine());
                        warehouses[y - 1].products1.Remove(products[x - 1]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("This product isnt in this warehouse");
                    }
                    }
                //wyjscie z konsoli
                if (p == 9)
                {
                    Environment.Exit(0);
                }
            }//obsługa błedów
            catch
            {
                Console.WriteLine("You have make a mistake try again");
            }
        }
    }
}
