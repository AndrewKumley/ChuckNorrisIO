using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ChuckNorrisIO
{
    class MainWindowViewModel
    {
        private string _joke;
        private Services.ChuckNorrisJokeClient Client { get; }
        private IEnumerable<string> _categories;

        public MainWindowViewModel()
        {
            Client = new Services.ChuckNorrisJokeClient();
            GetRandomJoke();
            _categories = Client.Categories();
        }

        private void GetRandomJoke()
        {
            Services.ChuckNorrisJokeClient jokeClient = new Services.ChuckNorrisJokeClient();
            IEnumerable<string> jokes = jokeClient.Random();
            _joke = jokes.First();
        }

        public IEnumerable<string> Categories
        {
            get { return _categories; }
        }
        public string CurrentJoke
        {
            get { return _joke; }
        }

        private void SetRandomJoke()
        {

        }
    }


}
