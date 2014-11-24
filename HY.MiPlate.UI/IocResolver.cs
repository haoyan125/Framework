using System.Reflection;
using HY.MiPlate.UI.Domain;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace HY.MiPlate.UI
{
    public class IocResolver 
    {
        //public static IContainer Configure()
        //{
        //    //ObjectFactory.Configure(x => x.Scan(scan =>
        //    //{
        //    //    scan.Assembly("HY.MiPlate.UI.Repository");
        //    //    scan.Assembly("HY.MiPlate.UI.Domain");
        //    //}));

        //    //return ObjectFactory.Container;

        //    IContainer container = new Container();

        //    container.Configure(x => x.Scan(scan =>
        //    {
        //        scan.Assembly("HY.MiPlate.UI.Repository");
        //        scan.Assembly("HY.MiPlate.UI.Domain");
        //    }));

        //    container.Configure(x => x.For<ISampleDataDomain>().Use<SampleDataDomain>());
        //    return container;
        //}

        public static IContainer Configure()
        {
            //ObjectFactory.Configure(x => x.Scan(scan =>
            //{
            //    scan.Assembly("HY.MiPlate.UI.Repository");
            //    scan.Assembly("HY.MiPlate.UI.Domain");
            //}));

            //return ObjectFactory.Container;

            return new Container(x => x.Scan(scan =>
            {
                scan.Assembly("HY.MiPlate.UI.Repository");
                scan.Assembly("HY.MiPlate.UI.Domain");
                scan.WithDefaultConventions();
            }));

            //container.Configure(x => x.For<ISampleDataDomain>().Use<SampleDataDomain>());

        }

    }
}