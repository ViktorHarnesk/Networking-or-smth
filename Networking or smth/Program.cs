using System.Linq.Expressions;
using System.Net.Http;

class Program{
  static async void GetJoke(){
    using(HttpClient dog = new HttpClient()){
    dog.BaseAddress = new Uri("https://api.chucknorris.io");
      try{
        HttpResponseMessage response = await dog.GetAsync("jokes/random");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
      }
      catch (HttpRequestException e){
      Console.WriteLine(e.Message);
      }
    }
  }
  static void Main(){
  GetJoke();
}
}

