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
    public partial class T_fun_app
    {
        #region Primitive Properties
    	[Required]
    	public virtual int id
        {
            get;
            set;
        }
    	[Required]
        [MaxLength(200)]
    	public virtual string app_name
        {
            get;
            set;
        }
    	//[Required]
        [MaxLength(50)]
    	public virtual string app_author
        {
            get;
            set;
        }
    	//[Required]
    	public virtual Nullable<System.DateTime> app_adddate
        {
            get;
            set;
        }
    	[Required]
        [MaxLength(200)]
    	public virtual string app_imgurl
        {
            get;
            set;
        }
    	[Required]
    	public virtual double app_ver
        {
            get;
            set;
        }
    	[Required]
    	public virtual byte[] app_link
        {
            get;
            set;
        }
    	[Required]
    	public virtual double app_high
        {
            get;
            set;
        }
    	//[Required]
        [MaxLength(300)]
    	public virtual string app_upnote
        {
            get;
            set;
        }
    	//[Required]
    	public virtual Nullable<System.DateTime> app_lastdate
        {
            get;
            set;
        }
    	[Required]
    	public virtual int app_ind
        {
            get;
            set;
        }
    	[Required]
    	public virtual int app_is_hot
        {
            get;
            set;
        }
    	[Required]
    	public virtual int app_is_red
        {
            get;
            set;
        }
    	[Required]
    	public virtual int app_is_my
        {
            get;
            set;
        }
    	[Required]
    	public virtual int app_is_sys
        {
            get;
            set;
        }
    	[Required]
    	public virtual double app_price
        {
            get;
            set;
        }

        #endregion
    }
}
