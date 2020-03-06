using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Models;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour


{
    public InputField userName;
    public InputField userEmail;

    public InputField userPassword;

    
    public InputField checkPassword;
    public InputField checkEmail;


    public string uCheckEmail;
    public string uCheckPassword;
    public string sUserName;
    public string sUserEmail;
    public string sUserPassword;
    
    
    
    
    public void onRegister() {
sUserEmail = userEmail.text; 
sUserName = userName.text;
sUserPassword= userPassword.text;



Debug.Log("UserName == " + sUserName );


Debug.Log("User email  == " + sUserEmail );


Debug.Log("Userpassword == " + sUserPassword );

postToDatabase();

    }

    void postToDatabase()
    {
        RegisterUser r2 = new RegisterUser();
        
        r2.sUserEmail = userEmail.text; 
        r2.sUserName = userName.text;
        r2.sUserPassword= userPassword.text;
        User u3 = new User(r2);
      
        RestClient.Post("https://pafappdatabase.firebaseio.com/"+u3.userEmail+".json" ,u3 );


    }

    // void methodCheckUser()

   // {

      //  uCheckEmail = checkEmail.text;
       // 
       // uCheckPassword = checkPassword.text;

        
       // retreiveFromDatabase(uCheckEmail).sUserName.ToString();
        
       // retreiveFromDatabase(uCheckEmail).sUserEmail.ToString();
 
       // retreiveFromDatabase(uCheckEmail).sUserPassword.ToString();


       // }
//


   // void  retreiveFromDatabase(string dataBaseEmail )
   // {

   //     RestClient.Get<User>("https://pafappdatabase.firebaseio.com/"+dataBaseEmail+".json").Then(response => { return response; });
  //  }







}


