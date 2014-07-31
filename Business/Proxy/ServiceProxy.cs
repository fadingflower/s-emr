using System;
using System.ServiceModel;

namespace SEMR.Business.Proxy
{
    public static class ServiceProxy
    {
        #region Private Member
		    private static BusinessServiceClient BizService;
        #endregion

        #region Properties

        #endregion

        #region Constructor & Destructor
            static ServiceProxy()
            {
				BasicHttpBinding binding = CreateBasicHttp ();
				EndpointAddress endpoint = new EndpointAddress (Settings.ServerURL);
				BizService = new BusinessServiceClient (binding, endpoint);
			}

			private static BasicHttpBinding CreateBasicHttp()
			{
				BasicHttpBinding binding = new BasicHttpBinding
				{
					Name = "basicHttpBinding",
					MaxBufferSize = 2147483647,
					MaxReceivedMessageSize = 2147483647
				};
				TimeSpan timeout = new TimeSpan(0, 0, 30);
				binding.SendTimeout = timeout;
				binding.OpenTimeout = timeout;
				binding.ReceiveTimeout = timeout;
				return binding;
			}
			
        #endregion

        #region Public Method
            public static void ExecuteBusinessService(ref BusinessObject bo, BusinessContext bizContext, Int32 timeoutMinutes = -1)
            {
                BusinessServiceClient service = null;

                try
                {
                    if (timeoutMinutes <= 0)
                    {
						BasicHttpBinding binding = CreateBasicHttp ();
						EndpointAddress endpoint = new EndpointAddress (Settings.ServerURL);
						service = new BusinessServiceClient (binding, endpoint);
						service.Endpoint.Binding.SendTimeout = new TimeSpan(0, timeoutMinutes, 0);
						service.ExecuteBusinessService(ref bo, bizContext);
                       // BizService.ExecuteBusinessService(ref bo, bizContext);
                    }
                    else
                    {
						BasicHttpBinding binding = CreateBasicHttp ();
						EndpointAddress endpoint = new EndpointAddress (Settings.ServerURL);
						service = new BusinessServiceClient (binding, endpoint);
                        service.Endpoint.Binding.SendTimeout = new TimeSpan(0, timeoutMinutes, 0);
                        service.ExecuteBusinessService(ref bo, bizContext);
                    }
                }
                
                catch (Exception ex)
                {
				throw ex;
                }
                finally
                {
                    if (service != null && service.State == CommunicationState.Opened)
                        service.Close();
                }
            }

            public static BusinessContext NewBusinessContext(String bizServiceCode, Boolean byPassDataIntegrityCheck = false)
            {
                try
                {
             
                    BusinessContext bizContext = new BusinessContext();
                    bizContext.BizServiceCode = bizServiceCode;
                    bizContext.ByPassDataIntegrityCheck = byPassDataIntegrityCheck;
                    bizContext.TransactionID = Guid.NewGuid().ToString();
                    bizContext.ClientCode = "SEMR";
                    //--- Assign location info ---//
                    bizContext.LocationIPAddress = "";
                    bizContext.LocationMachineName = "";
                    bizContext.InstitutionCode = "";
				    return bizContext;
                }
                catch (Exception ex)
                {
					throw ex;
                }
            }
        #endregion

        #region Private Method

        #endregion
    }
}
