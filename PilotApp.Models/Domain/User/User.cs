﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotApp.Domain.User
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public object TenantId { get; set; }
    }
}