using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace WCFServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISelfHost" in both code and config file together.
    [ServiceContract]
    public interface ISelfHost
    {
        [OperationContract]
        void DoWork();
    }

    [ServiceContract]
    public class SelfHostinService : ISelfHost
    {
        public void DoWork()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Uri baseAddress = new Uri("http://localhost:58512/Calculator.svc");
            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(SelfHostinService), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}