using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    class validation
    {
        //**********************************************validating User ID***************************************************
        public static bool checkUserID(String UID, String startLetter,String required, TextBox obj, ErrorProvider ep)
        {
            //String st = null;
            //st = txtUserID.Text;
            string ch;
            bool flag = false;

            if (UID == "")
            {
                ep.SetError(obj, required +" is required");
                return false;
            }
            else
            {
                if (UID.Length == 5)
                {
                    if ((UID.IndexOf(startLetter) == 0))
                    {
                        for (int i = 0; i < 4; i++)//check each char to see if it is a Number
                        {
                            ch = UID.ToCharArray(1, 4).GetValue(i).ToString();
                            flag = false;
                            for (int j = 0; j < 10; j++)
                            {
                                if (ch == j.ToString())
                                {
                                    flag = false;
                                    break;
                                }
                                else
                                {
                                    flag = true;
                                }
                            } //***************end of j loop
                            if (flag) break;
                        } //*******************end of i loop

                        if (flag)
                        {
                            ep.SetError(obj, "Incorrect "+ required + "\n" + "E.g- "+startLetter+"xxxx");
                            return false;
                        }
                        else
                        {
                            ep.SetError(obj, "");
                            return true;
                        }
                    }
                    else
                    {
                        ep.SetError(obj, "Incorrect " + required + "\n" + "E.g- " + startLetter + "xxxx");
                        return false;
                    }
                }
                else
                {
                    ep.SetError(obj, "Incorrect " + required + "\n" + "E.g- " + startLetter + "xxxx");
                    return false;
                }
            }

        }//**************************************End  validating User ID****************************************************

        //*******************************************validating NIC no*******************************************************
        public static bool checkNIC(String NIC, TextBox Obj, ErrorProvider er)
        {
            //string st;
            string ch;
            bool flag = false;
            //st = txtNIC.Text;
            if (NIC == "")
            {
                er.SetError(Obj, "NIC Is required.");
                return false;
            }

            if ((NIC.Length == 10) && (NIC.EndsWith("V")))
            {
                for (int i = 0; i < 8; i++)
                {
                    ch = NIC.ToCharArray(0, 8).GetValue(i).ToString();
                    flag = false;
                    for (int j = 0; j < 10; j++)//******
                    {
                        if (ch == j.ToString())
                        {
                            flag = true;
                            break;
                        }
                    }//************end of loop j
                    if (!flag)
                    {
                        er.SetError(Obj, "Invalid NIC Number !");
                        return false;
                    }
                    else
                    {
                        er.SetError(Obj, "");

                    }
                }//************end of loop i*********
            }
            else
            {
                er.SetError(Obj, "Invalid NIC Number !");
                return false;
            }
            return flag;
        }//*******************************************End of validating NIC no***********************************************

        public static bool checkNIC(string NIC)
        {
            //string st;
            string ch;
            bool flag = false;
            //st = txtNIC.Text;
            if (NIC == "")
            {
                //er.SetError(Obj, "NIC Is required.");
                return false;
            }

            if ((NIC.Length == 10) && ((NIC.EndsWith("V"))||(NIC.EndsWith("v"))))
            {
                for (int i = 0; i < 8; i++)
                {
                    ch = NIC.ToCharArray(0, 8).GetValue(i).ToString();
                    flag = false;
                    for (int j = 0; j < 10; j++)//******
                    {
                        if (ch == j.ToString())
                        {
                            flag = true;
                            break;
                        }
                    }//************end of loop j
                    if (!flag)
                    {
                        //er.SetError(Obj, "Invalid NIC Number !");
                        return false;
                    }
                    else
                    {
                        //er.SetError(Obj, "");

                    }
                }//************end of loop i*********
            }
            else
            {
                //er.SetError(Obj, "Invalid NIC Number !");
                return false;
            }
            return flag;
        }

        //**************************************************E-Mail Validation**************************************************
        public static bool checkEmail(String mail, TextBox obj, ErrorProvider er)
        {
            //String st = null;
            //st = txtEMail.Text;
            if (mail.Length != 0)
            {
                if ((mail.IndexOf("@") == -1) || (mail.IndexOf(".") == -1))
                {
                    er.SetError(obj, "Invalid E-Main Address");
                    return false;
                }
                else
                {
                    if (mail.IndexOf("@") > mail.IndexOf("."))
                    {
                        er.SetError(obj, "Invalid E-Main Address");
                        return false;

                    }
                    else
                    {
                        er.SetError(obj, "");
                        return true;
                    }

                }

            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }
        //*********************************************End of E-Mail Validation**************************************************

        //*********************************************validate Address1******************************************************
        public static bool checkAddress1(TextBox obj,ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "Street No. is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************end of validate Address1*********************************************


        //*************************************validate Address2*********************************************************
        public static bool checkAddress2(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "Street Name is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************end of validate Address2***************************************

        //*************************************validate Address3*********************************************************
        public static bool checkAddress3(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "City is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************end of validate Address3*****************************************************

        //*************************************validate Last name*********************************************************
        public static bool checkLastName(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "Last name is required");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************vEnd of alidate Last name************************************************

        //*******************************************validating First name****************************************************
        public static bool checkFirstName(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "First name is required");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*******************************************End of validating First name*************************************

        //*********************************************validate Mobile no***********************************************
        public static bool checkMobile(TextBox obj, ErrorProvider er)
        {
            if ((obj.Text.Length == 10) || (obj.Text.Length == 0))
            {
                er.SetError(obj, "");
                return true;
            }
            else
            {
                er.SetError(obj, "invalid Mobile Number");
                return false;
            }

        }//*************************************end of validate Mobile no******************************************

        //*************************************validate Tel no**********************************************************
        public static bool checkTel(TextBox obj, ErrorProvider er1, ErrorProvider er2)
        {

            if (obj.Text.Length == 0)
            {
                er1.SetError(obj, "Telephone Number is Required");
                return false;
            }
            else
            {
                if (obj.Text.Length == 10)
                {
                    er2.SetError(obj, "");
                    return true;
                }
                else
                {
                    er2.SetError(obj, "invalid Telephone Number");
                    return false;
                }
            }
        } //*************************************End of validate Tel no*************************************************

        public static bool checkTelLength(TextBox obj)
        {

           if (obj.Text.Length == 10)
            {
                 return true;
            }
           else
            {
                  return false;
            }
            
        } //*************************************End of validate Tel no*************************************************

        public static void clearErrors(ErrorProvider er1, ErrorProvider er2)
        {
            er1.Clear();
            er2.Clear();

        }
        //*************************************validate Age*********************************************************
        public static bool checkAge(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "Age is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************end of validate Age*****************************************************

        //*************************************validate Designation*********************************************************
        public static bool checkDesignation(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, "Designation is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************end of validate Age*****************************************************

        //*************************************validate Designation*********************************************************
        public static bool general(TextBox obj, ErrorProvider er,string req)
        {
            if (obj.Text == "")
            {
                er.SetError(obj, req + "  is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }//*************************************end of validate Age*****************************************************

        public static bool general(TextBox obj, ErrorProvider er)
        {
            if (obj.Text == "")
            {
                er.SetError(obj,  " This field is required.");
                return false;
            }
            else
            {
                er.SetError(obj, "");
                return true;
            }
        }


        //*****************These methods are overloaded********************************************
        public static void checkKeysForNumbers (TextBox obj, KeyEventArgs e, ErrorProvider er1, ErrorProvider er2, bool dot)
        {
            //Allows "." to be printed
            if (((e.KeyValue > 95) && (e.KeyValue < 106)) || ((e.KeyValue > 47) && (e.KeyValue < 58)) || (e.KeyValue == 8) || (e.KeyValue == 46) || (e.KeyValue == 110))
            {
                er2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
                er2.SetError(obj, "");
                obj.ReadOnly = false;
            }
            else
            {
                er1.SetError(obj, "");
                obj.ReadOnly = true;
                er2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
                er2.SetError(obj, "Only Numbers are allowed !");
            }
        }
        public static void checkKeysForNumbers(TextBox obj, KeyEventArgs e, ErrorProvider er1, ErrorProvider er2)
        {
            //Does NOT allows "." to be printed
            if (((e.KeyValue > 95) && (e.KeyValue < 106)) || ((e.KeyValue > 47) && (e.KeyValue < 58)) || (e.KeyValue == 8) || (e.KeyValue == 46))
            {
                er2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
                er2.SetError(obj, "");
                obj.ReadOnly = false;
            }
            else
            {
                er1.SetError(obj, "");
                obj.ReadOnly = true;
                er2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
                er2.SetError(obj, "Only Numbers are allowed !");
            }
        }


        public static void checkKeysForNumbers(TextBox obj, KeyEventArgs e, ErrorProvider er1)
        {
            //Does NOT allows "." to be printed
            if (((e.KeyValue > 95) && (e.KeyValue < 106)) || ((e.KeyValue > 47) && (e.KeyValue < 58)) || (e.KeyValue == 8) || (e.KeyValue == 46))
            {
                er1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
                er1.SetError(obj, "");
                obj.ReadOnly = false;
            }
            else
            {
                er1.SetError(obj, "");
                obj.ReadOnly = true;
                er1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
                er1.SetError(obj, "Only Numbers are allowed !");
            }
        }

        public static bool checkKeysForText(TextBox obj, KeyEventArgs e, ErrorProvider er1)
        {
            // Summary:
            //Does NOT allows "." to be printed

            if (((e.KeyValue > 95) && (e.KeyValue < 106)) || ((e.KeyValue > 47) && (e.KeyValue < 58)))//|| (e.KeyValue != 8) || (e.KeyValue != 46))
            {
                er1.SetError(obj, "");
                obj.ReadOnly = true;
                er1.SetError(obj, "Only Characters are allowed !");
                return false;
            }
            else
            {
                er1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
                er1.SetError(obj, "");
                obj.ReadOnly = false;
                return true;

            }
        }

        public static void checkKeys(TextBox obj, ErrorProvider er2)
        {
            if (obj.Text == "")
                er2.SetError(obj, "");
        }

        public static bool checkTextForNumbers(string textToCheck)
        {
            try 
            { 
                float xxx = float.Parse(textToCheck); 
                return true; 
            }
            catch 
            { 
                return false; 
            }
        }
        public static bool checkTextForNumbersAndLength(string textToCheck,int length)
        {
            if (textToCheck.Length < length||textToCheck=="")
                return false;
            try
            {
                float xxx = float.Parse(textToCheck);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool checkTextForCharacters(string textToCheck)
        {
            try
            {
                float xxx = float.Parse(textToCheck);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public static bool checkTextForCharactersAndLength(string textToCheck, int length)
        {
            if (textToCheck.Length < length || textToCheck == "")
                return false;
            try
            {
                float xxx = float.Parse(textToCheck);
                return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
