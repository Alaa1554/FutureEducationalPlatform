﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IHelperServices
{
    public interface IOTPServices
    {
        void SendOTP(string email , string subject, string entity);
    }
}