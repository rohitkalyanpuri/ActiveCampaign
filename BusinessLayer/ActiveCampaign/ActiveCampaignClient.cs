using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Linq;
using System.Diagnostics;

namespace ActiveCampaignNet
{
    public class ActiveCampaignClient
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["ActiveCampaignAPIKey"];
        private readonly string _baseUrl = ConfigurationManager.AppSettings["ActiveCampaignURL"];

        private static readonly HttpClientHandler handler = new HttpClientHandler();
        //private static HttpClient HttpClient;
        private static List<ActiveCampaignField> activeCampaignFields;

        public ActiveCampaignClient(string apiKey = "", string baseUrl = "")
        {

            if (!string.IsNullOrEmpty(apiKey))
                _apiKey = apiKey;

            if (!string.IsNullOrEmpty(baseUrl))
                _baseUrl = baseUrl;

            //HttpClient.DefaultRequestHeaders.Add("Api-Token", _apiKey);
            //activeCampaignFields = GetFieldsNameAndType();
        }

        private string CreateBaseUrl(string apiAction)
        {
            return $"{_baseUrl}/admin/api.php?api_action={apiAction}&api_key={_apiKey}&api_output=json";

        }

        #region Excute API Functions 

        public ApiResult<List<ContactObject>> GetContactList(string apiAction, Dictionary<string, string> parameters)
        {

            var result = new ApiResult<List<ContactObject>>();
            List<ContactObject> contactObjects = new List<ContactObject>();
            ContactObject contactObject;
            var uri = CreateBaseUrl(apiAction);
            foreach (KeyValuePair<string, string> item in parameters)
            {
                uri += "&" + item.Key + "=" + item.Value;
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using(HttpClient HttpClient = new HttpClient(handler, false))
            {
                using (HttpResponseMessage response = HttpClient.GetAsync(uri).Result)
                {
                    response.EnsureSuccessStatusCode(); //throw if httpcode is an error
                    using (HttpContent content = response.Content)
                    {
                        string rawData = content.ReadAsStringAsync().Result;


                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };

                        var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawData, settings);
                        if (values.ContainsKey("result_message"))
                        {
                            result.Message = values["result_message"].ToString();
                        }
                        if (result.Message == "Success: Something is returned")
                        {
                            foreach (KeyValuePair<string, object> item in values)
                            {
                                if (item.Key != "result_code" && item.Key != "result_message" && item.Key != "result_output")
                                {
                                    contactObject = new ContactObject();
                                    string text = Convert.ToString(values[item.Key]);
                                    contactObject = JsonConvert.DeserializeObject<ContactObject>(text);
                                    contactObjects.Add(contactObject);
                                }

                            }
                            result.model = contactObjects;
                        }

                        return result;
                    }
                }
            }
            
        }

        public ContactObject GetContactByEmail(string Email)
        {

            ContactObject contactObject = new ContactObject();

            var uri = CreateBaseUrl("contact_view_email");
            uri += "&email=" + Email;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (HttpClient HttpClient = new HttpClient(handler, false))
            {
                using (HttpResponseMessage response = HttpClient.GetAsync(uri).Result)
                {
                    response.EnsureSuccessStatusCode(); //throw if httpcode is an error
                    using (HttpContent content = response.Content)
                    {
                        string rawData = content.ReadAsStringAsync().Result;


                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };

                        var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawData, settings);
                        if (values.ContainsKey("result_message"))
                        {
                            if (values["result_message"].ToString() == "Success: Something is returned")
                            {
                                contactObject = JsonConvert.DeserializeObject<ContactObject>(rawData, settings);
                            }
                        }
                        return contactObject;
                    }
                }
            }
        }

        public Dictionary<string, FieldObject> GetFields(string apiAction, Dictionary<string, string> parameters)
        {

            Dictionary<string, FieldObject> keyValuePairs = new Dictionary<string, FieldObject>();
            FieldObject fieldObject;
            var uri = CreateBaseUrl(apiAction);

            foreach (KeyValuePair<string, string> item in parameters)
            {
                uri += "&" + item.Key + "=" + item.Value;
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (HttpClient HttpClient = new HttpClient(handler, false))
            {
                using (HttpResponseMessage response = HttpClient.GetAsync(uri).Result)
                {
                    response.EnsureSuccessStatusCode(); //throw if httpcode is an error
                    using (HttpContent content = response.Content)
                    {
                        string rawData = content.ReadAsStringAsync().Result;

                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawData, settings);
                        if (values.ContainsKey("result_message"))
                        {
                            if (values["result_message"].ToString() == "Success: Something is returned")
                            {
                                foreach (KeyValuePair<string, object> item in values)
                                {
                                    if (item.Key != "result_code" && item.Key != "result_message" && item.Key != "result_output")
                                    {
                                        fieldObject = new FieldObject();
                                        string text = Convert.ToString(values[item.Key]);
                                        fieldObject = JsonConvert.DeserializeObject<FieldObject>(text);
                                        keyValuePairs.Add(item.Key, fieldObject);
                                    }
                                }
                            }
                        }
                        return keyValuePairs;
                    }
                }
            }
            
        }

        public List<Deal> GetDealListByContactEmail(string apiAction, Dictionary<string, string> parameters)
        {

            List<Deal> deals = new List<Deal>();

            var uri = CreateBaseUrl(apiAction);
            foreach (KeyValuePair<string, string> item in parameters)
            {
                uri += "&" + item.Key + "=" + item.Value;
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (HttpClient HttpClient = new HttpClient(handler, false))
            {
                using (HttpResponseMessage response = HttpClient.GetAsync(uri).Result)
                {
                    response.EnsureSuccessStatusCode(); //throw if httpcode is an error
                    using (HttpContent content = response.Content)
                    {
                        string rawData = content.ReadAsStringAsync().Result;


                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };

                        var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawData, settings);
                        if (values.ContainsKey("result_message"))
                        {
                            if (values["result_message"].ToString() == "Deals retrieved.")
                            {
                                string text = Convert.ToString(values["deals"]);
                                deals = JsonConvert.DeserializeObject<List<Deal>>(text);

                            }
                        }
                        return deals;
                    }
                }
            }
            
        }

        public List<ContactNotesDetail> GetDealNotes(string email,DateTime? dateTime)
        {
            List<Deal> deals = GetDealListByContactEmail("deal_list", new Dictionary<string, string>
                                        {

                                            { "filters[email]",email}
                                        });


            var uri = CreateBaseUrl("deal_get");
            string id = "";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            


            for (int i=0;i<deals.Count;i++)
            {
                try
                {
                    id = "&id=" + deals[i].Id;
                    using (HttpClient HttpClient = new HttpClient(handler, false))
                    {
                        using (HttpResponseMessage response = HttpClient.GetAsync(uri + id).Result)
                        {
                            response.EnsureSuccessStatusCode(); //throw if httpcode is an error
                            using (HttpContent content = response.Content)
                            {
                                string rawData = content.ReadAsStringAsync().Result;
                                var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawData, settings);
                                if (values.ContainsKey("result_message"))
                                {
                                    if (values["result_message"].ToString() == "Deal successfully retrieved.")
                                    {
                                        string text = Convert.ToString(values["deal_notes"]);
                                        if (text != "[]")
                                        {
                                            deals[i].DealNotes = JsonConvert.DeserializeObject<Dictionary<string, DealNote>>(text);
                                        }

                                    }
                                }
                            }
                        }
                    }
                    
                }
                catch (Exception Ex)
                {

                }

            }

            while (deals.Any(s => s.DealNotes == null))
            {
                deals.Remove(deals.Single(s => s.DealNotes == null));
            }


            if (dateTime == null)
                dateTime = DateTime.Now.AddHours(-2);

            List<ContactNotesDetail> notesList = (from d in deals
                                                  from notes in d.DealNotes
                                                  where notes.Value.Cdate >= dateTime
                                                  select new ContactNotesDetail { Notes = d.Orgname + d.Orgname == null ? "-" : "" + notes.Value.Note, 
                                                      NoteDateTime = notes.Value.Cdate.DateTime ,
                                                      CreatedBy = notes.Value.FirstName+" "+notes.Value.LastName
                                                  }).ToList();

            return notesList;
        }
        public List<ActiveCampaignField> GetFieldsNameAndType()
        {

            List<ActiveCampaignField> activeCampaignFields = new List<ActiveCampaignField>();
            ActiveCampaignField activeCampaignField;
            var uri = CreateBaseUrl("list_field_view");
            uri += "&ids=all";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (HttpClient HttpClient = new HttpClient(handler, false))
            {
                using (HttpResponseMessage response = HttpClient.GetAsync(uri).Result)
                {
                    response.EnsureSuccessStatusCode(); //throw if httpcode is an error
                    using (HttpContent content = response.Content)
                    {
                        string rawData = content.ReadAsStringAsync().Result;
                        // var result = JsonConvert.DeserializeObject<ApiResult>(rawData);

                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawData, settings);
                        if (values.ContainsKey("result_message"))
                        {
                            foreach (KeyValuePair<string, object> item in values)
                            {
                                if (item.Key != "result_code" && item.Key != "result_message" && item.Key != "result_output")
                                {
                                    activeCampaignField = new ActiveCampaignField();
                                    string text = Convert.ToString(values[item.Key]);
                                    activeCampaignField = JsonConvert.DeserializeObject<ActiveCampaignField>(text);
                                    activeCampaignFields.Add(activeCampaignField);
                                }
                            }
                        }
                        return activeCampaignFields;
                    }
                }
            }
           
        }

        public void RemoveContacsTagInBulk(List<string> emails, string TagsCommaSeparated)
        {
            var uri = CreateBaseUrl("contact_tag_remove");
            List<KeyValuePair<string, string>> body;
            using (HttpClient HttpClient = new HttpClient(handler, false))
            {
                using (var client = HttpClient)
                {
                    foreach (string str in emails)
                    {
                        try
                        {
                            body = new List<KeyValuePair<string, string>>();
                            body.Add(new KeyValuePair<string, string>(ActiveCampaignMembers.Email, str));
                            body.Add(new KeyValuePair<string, string>(ActiveCampaignMembers.Tags, TagsCommaSeparated));
                            var res = client.PostAsync(uri, new FormUrlEncodedContent(body)).Result;
                            
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
           

        }

        #endregion



        #region Sync Notes From ActiveCampaign to CAM Notes
        public void SyncActiveCampaignContactNotes()
        {

            //Logic to sync notes from ActiveCampaign based on TAG on ActiveCampaign
            //So that It will fetch only those contacts which are Tagged with any particular tag.
            //It's help to reduce the load on the system and will sync only that which is needed/
            //Tag Could be added by admin user in Activecampaign.
            //Step 1:- Need to fetch all the contacts based on Tag. Call GetContactList with filter filters[tagname]
            ///ApiResult<List<ContactObject>> apiResult = GetContactList("contact_list", new Dictionary<string, string>
            //{

            //    { "filters[tagname]",ActiveCampaignMembers.SyncTag}
            //});

            //Step 2:- Get the contacts from yourdatabse based on Email in result of above step
            ///(from c in yourcontacttable.ToList()
            //join ac in contactObjects.ToList() on c.PrimaryEmail equals ac.Email
            //select new ContactIdEmail { ContactId = c.ContactId, PrimaryEmail = c.PrimaryEmail }).ToList();

            //Step 3:- For Loop on above result to call GetDealNotes(email,datetime)


            

        }

        #endregion



    }
}
