using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinnoTech
{
    public class AccessToken{
        public string value {get; set;}
        public string refreshToken {get; set;}
        public string creationDate {get; set;}
        public ulong lifeTime {get; set;}
        public string[] scopes {get; set;}
    }
    public class Deposits
    {
        public string prefix {get; set;}
        public string[] resources {get; set;}
    }
    public class AccessOauthToken
    {
        public string value {get; set;}
        public string[] scopes {get; set;}
        public string refreshToken {get; set;}
        public ulong lifeTime {get; set;}
        public string creationDate {get; set;}
        public string userId {get; set;}
        public Deposits deposits {get; set;}
    }
    public class OauthToken
    {
        public AccessOauthToken access_token {get; set;}
        public string token_type‌ {get; set;}
    }
    public class Token{
        public AccessToken access_token {get; set;}
        public string token_type {get; set;}
    }
    public class ApplicationCredentials
    {
        public string ApplicationId { get; set; }
        public string ApplicationSecret { get; set; }
        public string NationalId { get; set; }
        public string GetPassword()
        {
            var temp = System.Text.Encoding.UTF8.GetBytes(ApplicationId + ":" + ApplicationSecret);
            return System.Convert.ToBase64String(temp);
        }
    }
    public class OauthParameters{
        public string client_id {get; set;}
        public string response_type {get; set;}
        public string redirect_uri {get; set;}
        public string scope {get; set;}
        public ulong limit {get; set;}
        public uint count {get; set;}
        public string destination {get; set;}
    }
    public class OauthRequestBody{
        public string grant_type {get;set;}
        public string code {get;set;}
        public string redirect_uri {get;set;}
    }
    public class TokenRequestBody
    {
        public string grant_type { get; set; }
        public string nid { get; set; }
    }
    public class WithdrawRequestBody{
        public string paymentNumber {get; set;}
        public string destinationNumber {get; set;}
        public string description {get; set;}
        public ulong amount {get; set;}
    }
    public class WithdrawResponse{
        public string amount {get; set;}
        public string description {get; set;}
        public string descriptionFirstName {get; set;}
        public string descriptionLastName {get; set;}
        public string descriptionNumber {get; set;}
        public string inquiryDate {get; set;}
        public string inquirySequence {get; set;}
        public string inquiryTime {get; set;}
        public string message {get; set;}
        public string paymentNumber {get; set;}
        public string refCode {get; set;}
        public string sourceFirstName {get; set;}
        public string sourceLastName {get; set;}
        public string state {get; set;}
        public string trackId {get; set;}

    }
    public class ChargeCardRequestBody{
            public string card {get; set;}
            public ulong amount {get; set;}
        }
    public class ChargeCardResponse{
        public string message {get; set;}
        public string card {get; set;}
        public string amount {get; set;}
        public string status {get; set;}
        public ulong orderId {get; set;}
        public ulong tracker {get; set;}
        public string trackId {get; set;}
    }
    public class CardBalanceRequestBody{
        public string card {get; set;}
    }
    public class CardBalanceResponse{
        public uint code {get; set;}
        public ulong balance {get; set;}
        public string trackId {get; set;}
        public string state {get; set;}
    }
    public class CardStatementRequestBody{
        public string card {get; set;}
        public string from {get; set;}
        public string to {get; set;}
    }
    public class Transaction{
        public ulong trace {get; set;}
        public string pan {get; set;}
        public string financialdate {get; set;}
        public string local_Date {get; set;}
        public string timein {get; set;}
        public string Local_Time {get; set;}
        public ulong acquinst {get; set;}
        public string acc_termid {get; set;}
        public string refnum {get; set;}
        public ulong prcode {get; set;}
        public uint pos_cond_code {get; set;}
        public string amount {get; set;}
        public string availble {get; set;}
    }
    public class CardStatementResponse{
        public uint code {get; set;}
        public Transaction[] transactions {get; set;}
        public string trackId {get; set;}
        public string state {get; set;}
    }
    public class IbanResponse{
        public ulong depositNumber {get; set;}
        public string bank {get; set;}
        public string IBAN {get; set;}
        public string trackId {get; set;}
        public string status {get; set;}
    }
    public class IbanInquiryResponse{
        public string requestedIBAN {get; set;}
        public string bankName {get; set;}
        public string accountNumber {get; set;}
        public string accountStatus {get; set;}
        public string accountDescription {get; set;}
        public string accountComment {get; set;}
        public AccountOwner[] accountOwners {get; set;}
        public string paymentCode {get; set;}
        public string paymentCodeValid {get; set;}
        public string alertCode {get; set;}
        public string errorDescription {get; set;}
        public string trackId {get; set;}
        public string state {get; set;}
    }
    public class AccountOwner{
        public string firstName {get; set;}
        public string lastName {get; set;}
    }
    public class TransferToRequestBody{
        public string amount {get; set;}
        public string description {get; set;}
        public string destinationFirstName {get; set;}
        public string destinationLastName {get; set;}
        public string paymentNumber {get; set;}
    }
    public class TransferToResponse{
        public string amount {get; set;}
        public string description {get; set;}
        public string destinationFirstName {get; set;}
        public string destinationLastName {get; set;}
        public string destinationNumber {get; set;}
        public string inquiryDate {get; set;}
        public string inquiryTime {get; set;}
        public string message {get; set;}
        public string paymentNumber {get; set;}
        public string refCode {get; set;}
        public string sourceFirstName {get; set;}
        public string sourceLastName {get; set;}
        public string sourceNumber {get; set;}
        public string state {get; set;}
        public string trackId {get; set;}
        public string type {get; set;}
    }
    public class FinnotechApplication
    {
        public TransferToRequestBody TransferToRequestBody {get; set;}
        public TransferToResponse TransferToResponse {get; private set;}
        public string[] deposits {get; private set;}
        public IbanInquiryResponse IbanInquiryResponse {get; private set;}
        public IbanResponse IbanResponse {get; private set;}
        public CardStatementRequestBody CardStatementRequestBody {get; set;}
        public CardStatementResponse CardStatementResponse {get; private set;}
        public CardBalanceRequestBody CardBalanceRequestBody {get; set;}
        public CardBalanceResponse CardBalanceResponse {get; private set;}
        public ChargeCardRequestBody ChargeCardRequestBody {get; set;}
        public ChargeCardResponse ChargeCardResponse {get; private set;}
        public WithdrawRequestBody WithdrawRequestBody {get; set;}
        public WithdrawResponse WithdrawResponse {get; private set;}
        public OauthToken OauthToken {get; private set;}
        public Token Token {get; private set;}
        public ApplicationCredentials ApplicationCredentials { get; set; }
        public OauthParameters OauthParameters {get; set;}
        public HttpWebRequest HttpWebRequest { get; private set; }
        public string tokenString { get; private set; }
        public FinnotechApplication()
        {
            ApplicationCredentials = new ApplicationCredentials();
        }
        public bool GetToken()
        {
            try
            {
                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/dev/v1/oauth2/token");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Basic " + ApplicationCredentials.GetPassword());

                var tempRequest = new TokenRequestBody()
                {
                    grant_type = "client_credentials",
                    nid = ApplicationCredentials.NationalId
                };

                var tempJsonBody = JsonConvert.SerializeObject(tempRequest);

                HttpWebRequest.ContentLength = tempJsonBody.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(tempJsonBody);

                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    tokenString = responseStream.ReadToEnd();
                    Token = JsonConvert.DeserializeObject<Token>(tokenString);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetRedirectLink()
        {
            if(OauthParameters == null)
                return string.Empty;
            
            return $"https://sandbox.finnotech.ir/dev/v1/oauth2/authorize?client_id={OauthParameters.client_id}&response_type={OauthParameters.response_type}&redirect_uri={OauthParameters.redirect_uri}&scope={OauthParameters.scope}&limit={OauthParameters.limit}&count={OauthParameters.count}&destination={OauthParameters.destination}";
        }
        public bool GetOauthToken(string code)
        {
            try
            {
                HttpWebRequest = (HttpWebRequest) WebRequest.Create("https://sandbox.finnotech.ir/dev/v1/oauth2/authorize");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Basic " + ApplicationCredentials.GetPassword());

                var requestBody = new OauthRequestBody(){
                    code = code,
                    redirect_uri = OauthParameters.redirect_uri,
                    grant_type = "authorization_code"
                };

                var requestBodyJson = JsonConvert.SerializeObject(requestBody);
                HttpWebRequest.ContentLength = requestBodyJson.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(requestBodyJson);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    tokenString = responseStream.ReadToEnd();
                    var temp = new Token(){
                        access_token = new AccessToken()
                    };
                    OauthToken = JsonConvert.DeserializeObject<OauthToken>(tokenString);
                    
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool WithdrawalFrom(string nid)
        {
            try{
                if(WithdrawRequestBody == null){
                    return false;
                }

                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/{nid}/withdrawalFrom?trackId={Guid.NewGuid()}");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.OauthToken.access_token.value);

                var requestBodyJson = JsonConvert.SerializeObject(WithdrawRequestBody);
                HttpWebRequest.ContentLength = requestBodyJson.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(requestBodyJson);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    
                    WithdrawResponse = JsonConvert.DeserializeObject<WithdrawResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }
        public bool ChargeCard(string clientId, string deposit)
        {
            try{
                if(ChargeCardRequestBody == null){
                    return false;
                }

                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/clients/{clientId}/deposits/{deposit}/chargeCard?trackId={Guid.NewGuid()}");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.Token.access_token.value);

                var requestBodyJson = JsonConvert.SerializeObject(ChargeCardRequestBody);
                HttpWebRequest.ContentLength = requestBodyJson.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(requestBodyJson);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    ChargeCardResponse = JsonConvert.DeserializeObject<ChargeCardResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }
        public bool CardBalance(string clientId)
        {
            try{
                if(CardBalanceRequestBody == null){
                    return false;
                }

                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/clients/{clientId}/card/balance?trackId={Guid.NewGuid()}");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.OauthToken.access_token.value);

                var requestBodyJson = JsonConvert.SerializeObject(CardBalanceRequestBody);
                HttpWebRequest.ContentLength = requestBodyJson.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(requestBodyJson);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    CardBalanceResponse = JsonConvert.DeserializeObject<CardBalanceResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }
        public bool IbanRequest(uint bank,string deposit)
        {
            try{
                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/clients/testClient/iban?trackId={Guid.NewGuid()}&bank={bank}&deposit={deposit}");
                HttpWebRequest.Method = "GET";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.Token.access_token.value);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    IbanResponse = JsonConvert.DeserializeObject<IbanResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }        
        public bool CardStatement(string clientId)
        {
            try{
                if(CardStatementRequestBody == null){
                    return false;
                }

                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/clients/{clientId}/card/statement?trackId={Guid.NewGuid()}");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.Token.access_token.value);

                var requestBodyJson = JsonConvert.SerializeObject(CardStatementRequestBody);
                HttpWebRequest.ContentLength = requestBodyJson.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(requestBodyJson);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    CardStatementResponse = JsonConvert.DeserializeObject<CardStatementResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }    
        public bool DepositsInquiry(string nid, string iban)
        {
            try{
                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/{nid}/deposits?trackId={Guid.NewGuid()}");
                HttpWebRequest.Method = "GET";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.Token.access_token.value);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    deposits = JsonConvert.DeserializeObject<string[]>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }    
        public bool IbanInquiry(string clientId, string iban)
        {
            try{
                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/clients/{clientId}/ibanInquiry?trackId={Guid.NewGuid()}&iban={iban}");
                HttpWebRequest.Method = "GET";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.Token.access_token.value);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    IbanInquiryResponse = JsonConvert.DeserializeObject<IbanInquiryResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }
        public bool TransferTo(string nid, string clientId)
        {
            try{
                if(TransferToRequestBody == null){
                    return false;
                }

                HttpWebRequest = (HttpWebRequest)WebRequest.Create($"https://sandbox.finnotech.ir/oak/v1/{nid}/clients/{clientId}/transferTo?trackId={Guid.NewGuid()}");
                HttpWebRequest.Method = "POST";
                HttpWebRequest.ContentType = "application/json";
                HttpWebRequest.Headers.Add(HttpRequestHeader.Authorization,"Bearer " + this.Token.access_token.value);

                var requestBodyJson = JsonConvert.SerializeObject(TransferToRequestBody);
                HttpWebRequest.ContentLength = requestBodyJson.Length;

                using (var writtingStream = new StreamWriter(HttpWebRequest.GetRequestStream()))
                    writtingStream.Write(requestBodyJson);
                
                using (var response = HttpWebRequest.GetResponse())
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    var withdrawResponse = responseStream.ReadToEnd();
                    
                    TransferToResponse = JsonConvert.DeserializeObject<TransferToResponse>(withdrawResponse);
                    
                }
                return true;
            }
            catch(Exception ex){
                throw ex;
            }
        }
    }
}