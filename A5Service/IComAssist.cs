﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IComAssist" in both code and config file together.
[ServiceContract]
public interface IComAssist
{
    [OperationContract] 
     int Login(string user, string password);

    [OperationContract] 
     bool RegisterUser(string lastName, string firstName, string email, string password, string apt, string street, string city, string state, string zip, string phoneNumber, string workPhone);

    [OperationContract]
    bool SubmitRequest(int GrantTypeKey, string GrantRequestExplanation, decimal GrantRequestAmount, int PersonKey);

    [OperationContract] 
    List<GrantRequest> GetGrant(int personKey);

    [OperationContract]
    List<GrantType> GetGrantTypes();


}

/*
[DataContract]
public class GrantType
{
    [DataMember]

}
*/
