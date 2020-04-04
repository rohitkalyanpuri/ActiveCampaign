using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ActiveCampaignNet
{
    public class ApiResult<TModel>
    {
       
        [JsonProperty("result_code")]
        public int Code { get; set; }

        [JsonProperty("result_message")]
        public string Message { get; set; }

        [JsonProperty("result_output")]
        public string Output { get; set; }

        public TModel model { get; set; }
    }

    public class ContactObject 
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Subscriberid { get; set; }

        [JsonProperty("listid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Listid { get; set; }

        [JsonProperty("formid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Formid { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Seriesid { get; set; }

        [JsonProperty("sdate")]
        public DateTimeOffset Sdate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset Udate { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("responder")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Responder { get; set; }

        [JsonProperty("sync")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Sync { get; set; }

        [JsonProperty("unsubreason")]
        public object Unsubreason { get; set; }

        [JsonProperty("unsubcampaignid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Unsubcampaignid { get; set; }

        [JsonProperty("unsubmessageid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Unsubmessageid { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip4_sub")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4Sub { get; set; }

        [JsonProperty("sourceid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Sourceid { get; set; }

        [JsonProperty("sourceid_autosync")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SourceidAutosync { get; set; }

        [JsonProperty("ip4_last")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4Last { get; set; }

        [JsonProperty("ip4_unsub")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4Unsub { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long UpdatedBy { get; set; }

        [JsonProperty("listname")]
        public string Listname { get; set; }

        [JsonProperty("sdate_iso")]
        public DateTimeOffset SdateIso { get; set; }

        [JsonProperty("lid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Lid { get; set; }

        [JsonProperty("ip4")]
        public string Ip4 { get; set; }

        [JsonProperty("a_unsub_date")]
        public string AUnsubDate { get; set; }

        [JsonProperty("a_unsub_time")]
        public string AUnsubTime { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset Cdate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("customer_acct_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CustomerAcctId { get; set; }

        [JsonProperty("customer_acct_name")]
        public string CustomerAcctName { get; set; }

        [JsonProperty("segmentio_id")]
        public string SegmentioId { get; set; }

        [JsonProperty("bounced_hard")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long BouncedHard { get; set; }

        [JsonProperty("bounced_soft")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long BouncedSoft { get; set; }

        [JsonProperty("bounced_date")]
        public string BouncedDate { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("ua")]
        public string Ua { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("socialdata_lastcheck")]
        public string SocialdataLastcheck { get; set; }

        [JsonProperty("email_local")]
        public string EmailLocal { get; set; }

        [JsonProperty("email_domain")]
        public string EmailDomain { get; set; }

        [JsonProperty("sentcnt")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Sentcnt { get; set; }

        [JsonProperty("rating")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Rating { get; set; }

        [JsonProperty("rating_tstamp")]
        public string RatingTstamp { get; set; }

        [JsonProperty("gravatar")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gravatar { get; set; }

        [JsonProperty("deleted")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Deleted { get; set; }

        [JsonProperty("anonymized")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Anonymized { get; set; }

        [JsonProperty("adate")]
        public string Adate { get; set; }

        [JsonProperty("edate")]
        public string Edate { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_utc_timestamp")]
        public DateTimeOffset CreatedUtcTimestamp { get; set; }

        [JsonProperty("updated_utc_timestamp")]
        public DateTimeOffset UpdatedUtcTimestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("lists")]
        //public Dictionary<string, Lists> Lists { get; set; }



        [JsonProperty("listslist")]
        
        public string Listslist { get; set; }

        [JsonProperty("fields")]
        public Dictionary<string, FieldObject> Fields { get; set; }

        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }

        [JsonProperty("automation_history")]
        public List<AutomationHistory> AutomationHistory { get; set; }

        [JsonProperty("campaign_history")]
        public List<object> CampaignHistory { get; set; }

        [JsonProperty("bounces")]
        public Bounces Bounces { get; set; }

        [JsonProperty("bouncescnt")]
        public long Bouncescnt { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("orgid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Orgid { get; set; }

        [JsonProperty("orgname")]
        public string Orgname { get; set; }

        [JsonProperty("geo")]
        public List<Geo> Geo { get; set; }
    }
    
    public partial class AutomationHistory
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("adddate")]
        public DateTimeOffset Adddate { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }
    }
    public partial class Geo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Tstamp { get; set; }

        [JsonProperty("ip4")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4 { get; set; }

        [JsonProperty("country2")]
        public string Country2 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("area")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Area { get; set; }

        [JsonProperty("lat")]
        public Lat Lat { get; set; }

        [JsonProperty("lon")]
        public Lat Lon { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("tz_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string TzOffset { get; set; }

        [JsonProperty("tstamp_ago")]
        public string TstampAgo { get; set; }

        [JsonProperty("subscriberid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Subscriberid { get; set; }

        [JsonProperty("campaignid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Campaignid { get; set; }

        [JsonProperty("messageid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Messageid { get; set; }

        [JsonProperty("geoaddrid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Geoaddrid { get; set; }
    }

    public partial class Action
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Tstamp { get; set; }
    }
    public partial class Bounces
    {
        [JsonProperty("mailing")]
        public List<Mailing> Mailing { get; set; }

        [JsonProperty("mailings")]
        public long Mailings { get; set; }

        [JsonProperty("responder")]
        public List<object> Responder { get; set; }

        [JsonProperty("responders")]
        public long Responders { get; set; }
    }
    public partial class Mailing
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Subscriberid { get; set; }

        [JsonProperty("listid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Listid { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Campaignid { get; set; }

        [JsonProperty("messageid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Messageid { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Tstamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("counted")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Counted { get; set; }

        [JsonProperty("reason")]
        public object Reason { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("tstamp_iso")]
        public DateTimeOffset TstampIso { get; set; }
    }

    public partial class Message
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("listid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Listid { get; set; }

        [JsonProperty("listname")]
        public string Listname { get; set; }

        [JsonProperty("campaignname")]
        public string Campaignname { get; set; }

        [JsonProperty("sdate")]
        public string Sdate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Subscriberid { get; set; }

        [JsonProperty("reads")]
        public List<Read> Reads { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("forwards")]
        public List<object> Forwards { get; set; }
    }
    public partial class Link
    {
        [JsonProperty("link")]
        public Uri LinkLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("times")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Times { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Tstamp { get; set; }

        [JsonProperty("tstamp_settings")]
        public string TstampSettings { get; set; }
    }
    public partial class Read
    {
        [JsonProperty("tstamp")]
        public DateTimeOffset Tstamp { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("times")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Times { get; set; }

        [JsonProperty("tstamp_settings")]
        public string TstampSettings { get; set; }
    }
    public partial class Lists
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Subscriberid { get; set; }

        [JsonProperty("listid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Listid { get; set; }

        [JsonProperty("formid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Formid { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Seriesid { get; set; }

        [JsonProperty("sdate")]
        public DateTimeOffset Sdate { get; set; }

        [JsonProperty("udate")]
        public object Udate { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("responder")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Responder { get; set; }

        [JsonProperty("sync")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Sync { get; set; }

        [JsonProperty("unsubreason")]
        public object Unsubreason { get; set; }

        [JsonProperty("unsubcampaignid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Unsubcampaignid { get; set; }

        [JsonProperty("unsubmessageid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Unsubmessageid { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip4_sub")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4Sub { get; set; }

        [JsonProperty("sourceid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Sourceid { get; set; }

        [JsonProperty("sourceid_autosync")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SourceidAutosync { get; set; }

        [JsonProperty("ip4_last")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4Last { get; set; }

        [JsonProperty("ip4_unsub")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ip4Unsub { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("listname")]
        public string Listname { get; set; }

        [JsonProperty("sdate_iso")]
        public DateTimeOffset SdateIso { get; set; }
    }

    
    public partial struct Lat
    {
        public double? Double;
        public string String;

        public static implicit operator Lat(double Double) => new Lat { Double = Double };
        public static implicit operator Lat(string String) => new Lat { String = String };
    }
    public class FieldObject 
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("descript")]
        public string Descript { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isrequired")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Isrequired { get; set; }

        [JsonProperty("perstag")]
        public string Perstag { get; set; }

        [JsonProperty("defval")]
        public string Defval { get; set; }

        [JsonProperty("show_in_list")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ShowInList { get; set; }

        [JsonProperty("rows")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Rows { get; set; }

        [JsonProperty("cols")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Cols { get; set; }

        [JsonProperty("visible")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Visible { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("ordernum")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ordernum { get; set; }

        [JsonProperty("cdate")]
        public string Cdate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset Udate { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? UpdatedBy { get; set; }

        [JsonProperty("relid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Relid { get; set; }

        [JsonProperty("val")]
        public string Val { get; set; }

        [JsonProperty("dataid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Dataid { get; set; }

        [JsonProperty("element")]
        public string Element { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<Option> Options { get; set; }

        [JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
        public string Selected { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        

    }

    public partial class Option
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("isdefault")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Isdefault { get; set; }
    }

    public class ActiveCampaignField
    {
      public string title { get; set; }
      public string selected { get; set; }

      public string type { get; set; }

      public string tag { get; set; }

    }

    public partial class Deal
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("owner")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Owner { get; set; }

        [JsonProperty("value")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Value { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("orgid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Orgid { get; set; }

        [JsonProperty("customer_acct_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CustomerAcctId { get; set; }

        //[JsonProperty("winProbability")]
        //public long WinProbability { get; set; }

        //[JsonProperty("winProbabilityMdate")]
        //public DateTimeOffset WinProbabilityMdate { get; set; }
    }
    public partial class Deal
    {
        //[JsonProperty("owner")]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long Owner { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Contact { get; set; }

        //[JsonProperty("contact_email")]
        //public string ContactEmail { get; set; }

        //[JsonProperty("orgid")]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long Orgid { get; set; }

        [JsonProperty("orgname")]
        public string Orgname { get; set; }

        [JsonProperty("pipeline")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pipeline { get; set; }

        [JsonProperty("stage")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Stage { get; set; }

        //[JsonProperty("title")]
        //public string Title { get; set; }

        //[JsonProperty("value")]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("nextdate")]
        public DateTimeOffset Nextdate { get; set; }

        //[JsonProperty("winProbability")]
        //public long WinProbability { get; set; }

        //[JsonProperty("winProbabilityMdate")]
        //public DateTimeOffset WinProbabilityMdate { get; set; }

        [JsonProperty("deal_notes")]
        public Dictionary<string, DealNote> DealNotes { get; set; }

       }


    public partial class DealNote
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset Cdate { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }
    }

    public class ContactIdEmail
    {
        public long ContactId { get; set; }
        public string PrimaryEmail { get; set; }
    }

    public class ContactNotesDetail
    {
        public string Notes { get; set; }
        public DateTime NoteDateTime{ get; set; }

        public string CreatedBy { get; set; }
    }
    #region Helpers

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    #endregion

    #region StaticVariables
    public static class ActiveCampaignMembers
    {
        public const string SyncTag = "System Sync";
        public const string Email = "email";
        public const string FirstName = "first_name";
        public const string LastName = "last_name";
        public const string Type = "type";
        public const string Program = "program";
        public const string DOB = "dob";
        public const string language = "language";
        public const string Phone = "phone";
        public const string CreditAdvisor = "credit advisor";
        public const string AccountManager = "account manager";
        public const string Round = "round";
        public const string Status = "status"; 
        public const string BillingStatus = "billing status"; 
        public const string Goal = "goal";
        public const string Package = "package";
        public const string CommContact = "comm (contact)";
        public const string Portal_UserName = "portal_username";
        public const string Portal_Password = "portal_password";
        public const string AffiliateName = "affiliate name";
        public const string RelationshipManager = "relationship manager";
        public const string MarketingDirector = "marketing director";
        public const string DateEnrolled = "date enrolled";
        public const string IdIq_Username = "idiq username";
        public const string IdIq_Password = "idiq_password";
        public const string AffiliateCompany = "affiliate company";
        public const string Temperature = "temperature";
        public const string Pay = "pay";
        public const string JobTitle = "job title";
        public const string Industry = "industry";
        public const string Business = "business";
        public const string Team = "team";
        public const string TrackingLink = "tracking link";
        public const string NoOfLeads = "# of leads";
        public const string LastLead = "last lead"; 
        public const string NoOfCustomers = "# of customers"; 
        public const string LastCustomer = "last customer";
        public const string AffiliateMessage = "affiliate message";

        public const string NoteGeneralType = "1) General Note (Internal)";
        public const string NoteAffiliateOnlyType = "5) Affiliate Only (affiliate)";
        public const string PortalName = "ActiveCampaign";
        public const string Tags = "tags";
        
    }
    #endregion
}
