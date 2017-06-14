using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ComAssist" in code, svc and config file together.
public class ComAssist : IComAssist
{
    Community_AssistEntities db = new Community_AssistEntities();

    public List<GrantRequest> GetGrant(int personKey)
    {
        var grants = from g in db.GrantRequests
                     where g.PersonKey == personKey
                     select g;
        List<GrantRequest> L = new List<GrantRequest>();
        foreach(var gr in grants)
        {
            GrantRequest r = new GrantRequest();
            r.GrantRequestAmount = gr.GrantRequestAmount;
            r.GrantRequestDate = gr.GrantRequestDate;
            r.GrantRequestExplanation = gr.GrantRequestExplanation;
            r.GrantRequestKey = gr.GrantRequestKey;
            r.GrantReviews = gr.GrantReviews;
            r.GrantTypeKey = gr.GrantTypeKey;
            r.Person = gr.Person;
            r.PersonKey = gr.PersonKey;
            L.Add(r);
        }
        return L;
    }

    public List<GrantType> GetGrantTypes()
    {
        var types = from t in db.GrantTypes select t;
        List<GrantType> l = new List<GrantType>();
        foreach(var ty in types)
        {
            GrantType t = new GrantType();
            t.GrantTypeKey = ty.GrantTypeKey;
            t.GrantTypeName = ty.GrantTypeName;
            l.Add(t);
        }
        return l;
    }

    public int Login(string user, string password)
    {
        int key = 0;
        int result = db.usp_Login(user, password);
        if (result != -1)
        {
            key = result;
        }
        return key;
    }

    public bool RegisterUser(string lastName, string firstName, string email, string password, string apt, string street, string city, string state, string zip, string phoneNumber, string workPhone )
    {

        bool result = true;
        int userKey = db.usp_Register(lastName, firstName, email, password, apt,
            street, city, state, zip, phoneNumber, workPhone );
        return result;
    }

    public bool SubmitRequest( int GrantTypeKey, string GrantRequestExplanation, decimal GrantRequestAmount, int PersonKey)
    {
        int result = db.usp_AddRequest(GrantTypeKey, GrantRequestExplanation, GrantRequestAmount, PersonKey);
        if(result != -1)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
