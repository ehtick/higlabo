﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Core;

public class InputValidateResult
{
    public static string DefaultSeparator = Environment.NewLine;

    public bool Valid { get; set; } = true;
    public string Message { get; set; } = "";

    public InputValidateResult(bool valid)
        : this(valid, "")
    {
    }
    public InputValidateResult(bool valid, string message)
    {
        Valid = valid;
        Message = message;
    }

    public static implicit operator bool(InputValidateResult inputValidateResult)
    {
        return inputValidateResult.Valid;
    }

    public static InputValidateResult Merge(params InputValidateResult[] results)
    {
        return Merge(DefaultSeparator, results);
    }
    public static InputValidateResult Merge(string separator, params InputValidateResult[] results)
    {
        var rs = new InputValidateResult(true, "");
        foreach (var item in results)
        {
            rs.Valid = rs.Valid && item.Valid;

            if (item.Valid == false)
            {
                if (rs.Message.Length > 0)
                {
                    rs.Message += separator + item.Message;
                }
                else
                {
                    rs.Message += item.Message;
                }
            }
        }
        return rs;
    }
}
