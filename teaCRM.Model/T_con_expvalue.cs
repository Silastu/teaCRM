//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace teaCRM.Model
{
    public partial class T_con_expvalue
    {
        #region Primitive Properties
    	[Required]
    	public virtual int con_id
        {
            get;
            set;
        }
    	//[Required]
        [MaxLength(100)]
    	public virtual string exp_address
        {
            get;
            set;
        }

        #endregion
    }
}
