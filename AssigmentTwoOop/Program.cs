namespace AssigmentTwoOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 q1
            //class: هو مكان بجمع فى الfield ,methods الى ليها علاقه ببعض مع بعض
            //هو reference type بيتخزن فى الhead والعنوان بتاع فى الstack
            //;class للبيانات الكبيره ,structللبيانات الصغيره 
            //ينفع نطبق عليه جميع الpillars  بتاعت الoop
            // b:علشان طول م احنا بنستخدم كلاس  معنناش خوف من حجم البايانات
            // وكمان نقدر نطبق عليها جميع الpillars بتاعت الoop
            // ده  معناه ان  الكود محمي ومنظم وقابل لاي تطوير مستقبلي 
            #endregion
            #region part1 q2
            //a/ the parent is class shipment;
            //b/the child class ExpresShipment;
            //c/public string TrackingCode { get; set; }  ده الموروث من shipment
            //d/بنقلل التكرار وبنخلي الكود مبني على منطق صحيح ومنظم وقابل للتطوير
            #endregion
            #region q5
            //q1
            DeliveryCenter de = new DeliveryCenter("ma");
            //q2
            Console.WriteLine("please enter the center name : ");
            string name = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(name);
            //q3
            DeliveryAddress d = new DeliveryAddress();

            StandaredShipment s1 = new StandaredShipment("qwe", "clothes",40,55,d);
            //q4
            ExpressShipment s2 = new ExpressShipment("we", "food",90,95,d,99);
            //q5
            InternationalShipment s3 = new InternationalShipment("jj","games",44,26,d,"parise",10);
            //q6
            Console.WriteLine("-standard shiment");
            Console.WriteLine("enter travking code:");
            string t = Console.ReadLine();
            Console.WriteLine("enter descrabtion : ");
            string des = Console.ReadLine();
            Console.WriteLine("enter the weigth:");
            decimal w = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the Deliveryfee:");
            decimal df = decimal.Parse(Console.ReadLine());
            DeliveryAddress dl = new DeliveryAddress();
            Console.WriteLine("Enter City:");
            dl.setCity(Console.ReadLine());
            Console.WriteLine("Enter Street:");
            dl.setStreet(Console.ReadLine());
            Console.WriteLine("Enter Building Number:");
            dl.setBuldingNum( int.Parse(Console.ReadLine()));
            StandaredShipment std = new StandaredShipment(t, des, w, df, dl);
            //ExpressShipment

            Console.WriteLine("-Epress shiment");
            Console.WriteLine("enter travking code:");
            string et = Console.ReadLine();
            Console.WriteLine("enter descrabtion : ");
            string edes = Console.ReadLine();
            Console.WriteLine("enter the weigth:");
            decimal ew = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the Deliveryfee:");
            decimal edf = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter extrafee:");
            decimal ext = decimal.Parse(Console.ReadLine());
            DeliveryAddress edl = new DeliveryAddress();
            Console.WriteLine("Enter City:");
            edl.setCity(Console.ReadLine());
            Console.WriteLine("Enter Street:");
            edl.setStreet(Console.ReadLine());
            Console.WriteLine("Enter Building Number:");
            edl.setBuldingNum(int.Parse(Console.ReadLine()));
            ExpressShipment estd = new ExpressShipment(et,edes,ew,edf,edl,ext);

            //international shipment 

            Console.WriteLine("-Epress shiment");
            Console.WriteLine("estinationCountry:");
            string ec = Console.ReadLine();
            Console.WriteLine("enter customefee");
            decimal fee = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter travking code:");
            string it = Console.ReadLine();
            Console.WriteLine("enter descrabtion : ");
            string ides = Console.ReadLine();
            Console.WriteLine("enter the weigth:");
            decimal iw = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the Deliveryfee:");
            decimal idf = decimal.Parse(Console.ReadLine());
            DeliveryAddress idl = new DeliveryAddress();
            Console.WriteLine("Enter City:");
            idl.setCity(Console.ReadLine());
            Console.WriteLine("Enter Street:");
            idl.setStreet(Console.ReadLine());
            Console.WriteLine("Enter Building Number:");
            idl.setBuldingNum(int.Parse(Console.ReadLine()));
            InternationalShipment istd = new InternationalShipment(it, ides, iw, idf, idl,ec,fee);
            //7 
            center.AddShipment(std);
            center.AddShipment(estd);
            center.AddShipment(istd);
            //q8
            center.PrintAllShipment();
            //9
            Console.Write("Enter Tracking Code to search: ");
            string searchCode = Console.ReadLine();

  
            #endregion
        }
    }
}
