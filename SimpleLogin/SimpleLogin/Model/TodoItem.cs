using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Model
{
    public class TodoItem
    {
        public string Identification { get; set; }

        public TodoItem(string identification)
        {
            if (string.IsNullOrWhiteSpace(identification))
            {
                throw new ArgumentException("message", nameof(identification));
            }

            Identification = identification;
        }
    }
}
