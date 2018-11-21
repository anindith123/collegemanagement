/*
    -------------------------------------------------------------------------
	                    JavaScript Form Validator 
                                Version 2.0.2
	Copyright 2003 JavaScript-coder.com. All rights reserved.
	You use this script in your Web pages, provided these opening credit
    lines are kept intact.
	The Form validation script is distributed free from JavaScript-Coder.com
	You may please add a link to JavaScript-Coder.com, 
	making it easy for others to find this script.
	Checkout the Give a link and Get a link page:
	http://www.javascript-coder.com/links/how-to-link.php
    You may not reprint or redistribute this code without permission from 
    JavaScript-Coder.com.	
	JavaScript Coder
	It precisely codes what you imagine!
	Grab your copy here: http://www.javascript-coder.com/
    -------------------------------------------------------------------------  
*/

function Validator(frmname,objcontrol)
{
    this.formobj=document.forms[frmname];
	if(!this.formobj)
	{
	    alert("Could not get form object "+frmname);
		return;
	}	
	
    if(document.getElementById!=undefined)
    {
        //alert(document.getElementById(objcontrol).onclick);
        if (document.getElementById(objcontrol).onclick)
	    {
		    this.formobj.old_onsubmit = this.formobj.elements[objcontrol].onclick;
		    this.formobj.elements[objcontrol].onclick=null;
	    }
	    else
	    {
		    this.formobj.old_onsubmit=null;
	    }
	    document.getElementById(objcontrol).onclick=form_submit_handler;
	    this.addValidation = add_validation;
	    this.setAddnlValidationFunction=set_addnl_vfunctionID;
	    this.clearAllValidations = clear_all_validations;
	    
        /*if (this.formobj.elements[objcontrol].onclick)
	    {
		    this.formobj.old_onsubmit = this.formobj.elements[objcontrol].onclick;
		    this.formobj.elements[objcontrol].onclick=null;
	    }
	    else
	    {
		    this.formobj.old_onsubmit=null;
	    }
	    //this.formobj.onsubmit=form_submit_handler;
	    this.formobj.elements[objcontrol].onclick=form_submit_handler;
	    this.addValidation = add_validation;
	    this.setAddnlValidationFunction=set_addnl_vfunction;
	    this.clearAllValidations = clear_all_validations;*/
    }
    else
    {
        if(document.all!=undefined)
        {
            alert("Could not get form object "+frmname);
        }
    }
}

function set_addnl_vfunctionID(functionname,objcontrol)
{
  document.getElementById(objcontrol).addnlvalidation = functionname;
}

function set_addnl_vfunction(functionname,objcontrol)
{
  this.formobj.elements[objcontrol].addnlvalidation = functionname;
}
function clear_all_validations()
{
	for(var itr=0;itr < this.formobj.elements.length;itr++)
	{
		this.formobj.elements[itr].validationset = null;
	}
}
function form_submit_handler()
{
	this.formobj=document.forms[this.form.name];
	for(var itr=0;itr < this.formobj.elements.length;itr++)
	{
		if(this.formobj.elements[itr].validationset &&
	   !this.formobj.elements[itr].validationset.validate())
		{
		//alert("hello");
		  return false;
		}
	}
	if(this.addnlvalidation)
	{
	  str =" var ret = "+this.addnlvalidation+"()";
	  eval(str);
	  //alert(str);
    if(!ret) return ret;
	}
	return false;
}
function add_validation(itemname,descriptor,errstr)
{
  if(!this.formobj)
	{
	  alert("The form object is not set properly");
		return;
	}//if
	var itemobj = this.formobj[itemname];
  if(!itemobj)
	{
	  alert("Could not get the input object named: "+itemname);
		return;
	}
	if(!itemobj.validationset)
	{
	  itemobj.validationset = new ValidationSet(itemobj);
	}
  itemobj.validationset.add(descriptor,errstr);
}
function ValidationDesc(inputitem,desc,error)
{
  this.desc=desc;
	this.error=error;
	this.itemobj = inputitem;
	this.validate=vdesc_validate;
}
function vdesc_validate()
{
 if(!V2validateData(this.desc,this.itemobj,this.error))
 {
    this.itemobj.focus();
		return false;
 }
 return true;
}
function ValidationSet(inputitem)
{
    this.vSet=new Array();
	this.add= add_validationdesc;
	this.validate= vset_validate;
	this.itemobj = inputitem;
}
function add_validationdesc(desc,error)
{
  this.vSet[this.vSet.length]= 
	  new ValidationDesc(this.itemobj,desc,error);
}
function vset_validate()
{
   for(var itr=0;itr<this.vSet.length;itr++)
	 {
	   if(!this.vSet[itr].validate())
		 {
		   return false;
		 }
	 }
	 return true;
}
function validateEmailv2(email)
{
// a very simple email validation checking. 
// you can add more complex email checking if it helps 
    if(email.length <= 0)
	{
	  return true;
	}
    var splitted = email.match("^(.+)@(.+)$");
    if(splitted == null) return false;
    if(splitted[1] != null )
    {
      var regexp_user=/^\"?[\w-_\.]*\"?$/;
      if(splitted[1].match(regexp_user) == null) return false;
    }
    if(splitted[2] != null)
    {
      var regexp_domain=/^[\w-\.]*\.[A-Za-z]{2,4}$/;
      if(splitted[2].match(regexp_domain) == null) 
      {
	    var regexp_ip =/^\[\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\]$/;
	    if(splitted[2].match(regexp_ip) == null) return false;
      }// if
      return true;
    }
return false;
}

function trim(strText)
 {
    // this will get rid of leading spaces
    while (strText.substring(0,1) == ' ')
        strText = strText.substring(1, strText.length);

    // this will get rid of trailing spaces
    while (strText.substring(strText.length-1,strText.length) == ' ')
        strText = strText.substring(0, strText.length-1);

   return strText;
}
function V2validateData(strValidateStr,objValue,strError) 
{ 
    var epos = strValidateStr.search("="); 
    var  command  = ""; 
    var  cmdvalue = ""; 
    if(epos >= 0) 
    { 
     command  = strValidateStr.substring(0,epos); 
     cmdvalue = strValidateStr.substr(epos+1); 
    } 
    else 
    { 
     command = strValidateStr; 
    } 
    switch(command) 
    { 
        case "req": 
        case "required": 
         { 
           objValue.value=trim(objValue.value);
           if(eval(objValue.value.length) == 0) 
           { 
              if(!strError || strError.length ==0) 
              { 
                //strError = objValue.name + " : Required Field"; 
                strError = "Required Field"; 
              }//if 
              alert(strError); 
              return false; 
           }//if 
           break;             
         }//case required 
        case "maxlength": 
        case "maxlen": 
          { 
             objValue.value=trim(objValue.value);
             if(eval(objValue.value.length) >  eval(cmdvalue)) 
             { 
               if(!strError || strError.length ==0) 
               { 
                 //strError = objValue.name + " : "+cmdvalue+" characters maximum "; 
                 strError = cmdvalue+" characters maximum "; 
               }//if 
               alert(strError + "\n[Current length = " + objValue.value.length + " ]"); 
               return false; 
             }//if 
             break; 
          }//case maxlen 
        case "minlength": 
        case "minlen": 
           { 
             objValue.value=trim(objValue.value);
             if(eval(objValue.value.length)>0  && eval(objValue.value.length)<  eval(cmdvalue)) 
             { 
               if(!strError || strError.length ==0) 
               { 
                 //strError = objValue.name + " : " + cmdvalue + " characters minimum  "; 
                 strError = cmdvalue + " characters minimum  "; 
               }//if               
               alert(strError + "\n[Current length = " + objValue.value.length + " ]"); 
               return false;                 
             }//if 
             break; 
            }//case minlen 
        case "alnum": 
        case "alphanumeric": 
           { 
             objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z0-9]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
               if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": Only alpha-numeric characters allowed "; 
                strError = "Only alpha-numeric characters are allowed"; 
                }//if 
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 
              break; 
           }//case alphanumeric 
        case "num": 
        case "numeric": 
           { 
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^0-9]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": Only digits allowed "; 
                  strError = "Only numerics are allowed"; 
                }//if               
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 
              break;               
           }//numeric 
        case "numericspacehyphen": 
           { 
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^0-9\ -_]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": Only digits allowed "; 
                  strError = "Only numerics, space and '-' are allowed"; 
                }//if               
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 
              break;               
           }//numeric 
        case "numericdot": 
           { 
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^0-9\.]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": Only digits allowed "; 
                  strError = "Only numerics and decimal are allowed"; 
                }//if               
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 
              break;               
           }//numeric 
        case "phone": 
           { 
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^0-9\-+ ]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": Only digits allowed "; 
                  strError = "Only numerics, '+' and '-' are allowed"; 
                }//if               
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 
              break;               
           }//numeric 
        case "alphabetic": 
        case "alpha": 
           { 
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": Only alphabetic characters allowed "; 
                  strError = "Only alphabetic characters are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 
              break; 
           }//alpha 
		case "alnumhyphen":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z0-9\-_]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": characters allowed are A-Z,a-z,0-9,- and _"; 
                  strError = "Only alpha-numeric characters and '-' are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}
		case "alnumhyphenamp":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z\ -&_]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": characters allowed are A-Z,a-z,0-9,- and _"; 
                  strError = "Only alpha-numeric characters, space, '&', '_' and '-' are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}
		case "alnumscore":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z0-9\_]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": characters allowed are A-Z,a-z,0-9, and _"; 
                  strError = "Only alpha-numeric characters, space and '_' are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}
		
		case "alnumspace":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z0-9\ ]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                  //strError = objValue.name+": characters allowed are A-Z,a-z,0-9, and space"; 
                  strError = "Only alpha-numeric characters and space are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}

			case "alspace":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z\ ]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                 // strError = objValue.name+": characters allowed are A-Z,a-z, and space"; 
                 strError = "Only alphabetic characters and space are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}
			
			case "aldotspace":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z\. ]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                 // strError = objValue.name+": characters allowed are A-Z,a-z, and space"; 
                 strError = "Only alphabetic characters, '.' and space are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}
			
		case "alspacecomma":
			{
              objValue.value=trim(objValue.value);
              var charpos = objValue.value.search("[^A-Za-z\, ]"); 
              if(objValue.value.length > 0 &&  charpos >= 0) 
              { 
                  if(!strError || strError.length ==0) 
                { 
                 // strError = objValue.name+": characters allowed are A-Z,a-z, and space"; 
                 strError = "Only alphabetic characters, ',' and space are allowed"; 
                }//if                             
                //alert(strError + "\n [Error character position " + eval(charpos+1)+"]"); 
                alert(strError); 
                return false; 
              }//if 			
			break;
			}

		case "validFile":
		{
			objValue.value=trim(objValue.value);
			if(objValue.value.length>0)
			{
				var k=objValue.value.indexOf('.');
				var sub=objValue.value.substring(k+1,objValue.value.length);
				var sub=sub.toLowerCase();
				//alert(sub);
				//return false;
				if((sub!="doc")&&(sub!="rtf")&&(sub!="pdf"))
				{
					//alert(sub);
					alert("Not a valid file format, Please Attach a document of type doc,rtf or pdf");
					return false;
				}
			}	
				break;
		}
		
		case "validImageFile":
		{
		    if (objValue.value.length>0)
			{
				var k=objValue.value.lastIndexOf('.');
				var sub=objValue.value.substring(k+1,objValue.value.length);
				var sub=sub.toLowerCase();
				//alert(sub);
				//return false;
				if((sub!="jpeg")&&(sub!="jpg")&&(sub!="gif")&&(sub!="tiff")&&(sub!="bmp") )
				{
					//alert(sub);
					alert("Not a valid file format, Please Attach a image of type jpg,jpeg,gif,bmp or png");
					return false;
				}
			}		
			break;
		}
		
		case "validImageFileCompulsory":
		{
			objValue.value=trim(objValue.value);
			
				var k=objValue.value.lastIndexOf('.');
				var sub=objValue.value.substring(k+1,objValue.value.length);
				var sub=sub.toLowerCase();
				//alert(sub);
				//return false;
				if((sub!="jpeg")&&(sub!="jpg")&&(sub!="gif")&&(sub!="png"))
				{
					//alert(sub);
					alert("Not a valid file format, Please Attach a image of type jpg,jpeg,gif or png");
					return false;
				}
			
			break;
		}
		case "url":
		{ 
               objValue.value=trim(objValue.value);
               var url
               url = objValue.value               
               if(url.length > 0)
				{
					if(url!= null )
					{					
						var urlRegxp =/^(http:\/\/www.|https:\/\/www.|ftp:\/\/www.|www.){1}([\w]+)(.[\w]+){1,2}$/;
						if(url.match(urlRegxp) == null) 
							{
							alert("Invalid URL format.\n Enter in the 'http://www.domainname.com' format.")							
							return false;
							}
						return true;
					}
				}
           break; 
          }//case URL 
		
		   case "email": 
          { 
               objValue.value=trim(objValue.value);
               if(!validateEmailv2(objValue.value)) 
               { 
                 if(!strError || strError.length ==0) 
                 { 
                    //strError = objValue.name+": Enter a valid Email address "; 
                    strError = "Enter a valid Email address "; 
                 }//if                                               
                 alert(strError); 
                 return false; 
               }//if 
           break; 
          }//case email 
        case "lt": 
        case "lessthan": 
         { 
            objValue.value=trim(objValue.value);
            if(isNaN(objValue.value)) 
            { 
              //alert(objValue.name+": Should be a number "); 
              alert("Should be a number"); 
              return false; 
            }//if 
            if(eval(objValue.value) >=  eval(cmdvalue)) 
            { 
              if(!strError || strError.length ==0) 
              { 
               // strError = objValue.name + " : value should be less than "+ cmdvalue; 
               strError =  "value should be less than "+ cmdvalue; 
              }//if               
              alert(strError); 
              return false;                 
             }//if             
            break; 
         }//case lessthan 
        case "gt": 
        case "greaterthan": 
         { 
            objValue.value=trim(objValue.value);
            if(isNaN(objValue.value)) 
            { 
              //alert(objValue.name+": Should be a number "); 
              alert("Should be a number "); 
              return false; 
            }//if 
             if(eval(objValue.value) <=  eval(cmdvalue)) 
             { 
               if(!strError || strError.length ==0) 
               { 
                 //strError = objValue.name + " : value should be greater than "+ cmdvalue; 
                 strError = "value should be greater than "+ cmdvalue; 
               }//if               
               alert(strError); 
               return false;                 
             }//if             
            break; 
         }//case greaterthan 
        case "regexp": 
         { 
		 	objValue.value=trim(objValue.value);
		 	if(objValue.value.length > 0)
			{
	            if(!objValue.value.match(cmdvalue)) 
	            { 
	              if(!strError || strError.length ==0) 
	              { 
	                //strError = objValue.name+": Invalid characters found "; 
	                strError = "Invalid characters found "; 
	              }//if                                                               
	              alert(strError); 
	              return false;                   
	            }//if 
			}
           break; 
         }//case regexp 
         
        case "dontselect": 
         { 
            if(objValue.selectedIndex == null) 
            { 
              alert("BUG: dontselect command for non-select Item"); 
              return false; 
            } 
            if(objValue.selectedIndex == eval(cmdvalue)) 
            { 
             if(!strError || strError.length ==0) 
              { 
              //strError = objValue.name+": Please Select one option "; 
              strError = "Please select one option "; 
              }//if                                                               
              alert(strError); 
              return false;                                   
             } 
             break; 
         }//case dontselect
          case "mulitlistbox": 
         { 
            if(objValue.options.length == null) 
            { 
              alert("BUG: dontselect command for non-select Item"); 
              return false; 
            } 
            for (i = 0; i < objValue.options.length; i++) 
            {
                if (objValue.options[i].selected)
                { 
                    var b = 1 
                }
            }
            if (!b)
            { 
                    alert("Select one option!");
                    objValue.focus();
                    return false; 
            }          
             break; 
         }//case dontselect  
    }//switch 
    return true; 
}



function windowopen(str)
{
    alert();
    window.open(str ,'prdadd','scrollbars=yes,width=400,height=500');
}
/*
	Copyright 2003 JavaScript-coder.com. All rights reserved.
*/