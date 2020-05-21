Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Home() As ActionResult
        Return View()
    End Function

    <HttpGet>
    Public Function Weather() As JsonResult
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("http://ip-api.com/json/"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()
        Dim jsonResult = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(rawresp)
        Dim City As String = jsonResult.Item("regionName").ToString()
        Dim Country As String = jsonResult.Item("country").ToString()



        Dim WeatherData As New WeatherAPIModel

        request = DirectCast(WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" & City & "&units=metric&lang=th&appid=19257c7ba8475d851d003dc850458cc8"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawWeather As String
        rawWeather = reader.ReadToEnd()
        Dim jResults As Object = New JavaScriptSerializer().Deserialize(Of Object)(rawWeather)
        WeatherData.Temp = jResults("main")("temp")
        WeatherData.FeelTemp = jResults("main")("feels_like")
        WeatherData.WeatherHead = jResults("weather")(0)("main")
        WeatherData.WeatherDetail = jResults("weather")(0)("description")
        WeatherData.CityinThai = jResults("name")
        WeatherData.Country = Country

        Return Json(WeatherData, JsonRequestBehavior.AllowGet)
    End Function

End Class
