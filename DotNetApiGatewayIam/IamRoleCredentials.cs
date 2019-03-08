﻿using System;

namespace DotNetApiGatewayIam
{
    public class IamRoleCredentials
    {
        public string Code { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Type { get; set; }
        public string AccessKeyId { get; set; }
        public string SecretAccessKey { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
