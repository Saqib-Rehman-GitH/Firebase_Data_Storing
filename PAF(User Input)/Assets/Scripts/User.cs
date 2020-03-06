using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    
    
     public string userName ;
    
     public string userEmail ;
    
     public string userPassword ;


     public User(RegisterUser ri)
     {

          userName = ri.sUserName;

          userEmail = ri.sUserEmail;

          userPassword = ri.sUserPassword;


     }

}
