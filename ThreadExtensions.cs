﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SniperUsbDmx
{
   public static  class ThreadExtensions
    {
        public static void InvokeIfRequired(this ISynchronizeInvoke obj,
                                         MethodInvoker action)
        {
            if (obj.InvokeRequired)
            {
                var args = new object[0];
                obj.Invoke(action, args);
            }
            else {
                action();
            }
        }




    }
}
