using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Servar
{
    class Aliyun
    {
        public string SendSms(string PhoneNumbers) {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", "<accessKeyId>", "<accessSecret>");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            CommonRequest request = new CommonRequest();
            request.Method = MethodType.POST;
            request.Domain = "dysmsapi.aliyuncs.com";
            request.Version = "2017-05-25";
            request.Action = "SendSms";
            request.AddQueryParameters("PhoneNumbers", "13623043562");
            request.AddQueryParameters("SignName", "三丰医药有限公司");
            request.AddQueryParameters("TemplateCode", "SMS_182679662");
            request.AddQueryParameters("TemplateParam", "{\"name\":\"巫钦怀\"}");
            // request.Protocol = ProtocolType.HTTP;

            try
            {
                CommonResponse response = client.GetCommonResponse(request);
                Console.WriteLine(System.Text.Encoding.Default.GetString(response.HttpResponse.Content));
            }
            catch (ServerException e)
            {
                Console.WriteLine(e);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e);
            }
            return "";
        }

    }
}
