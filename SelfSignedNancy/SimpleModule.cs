using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfSignedNancy
{
    public class SimpleModule : Nancy.NancyModule
    {
        public SimpleModule()
        {
            Get["/"] = _ => "Received GET request";

            Post["/"] = _ => "Received POST request";

            Get["/user/{id}"] = parameters =>
            {
                if (((int)parameters.id) == 666)
                {
                    return $"All hail user #{parameters.id}! \\m/";
                }
                else
                {
                    return "Just a regular user!";
                }
            };
        }
    }
}
