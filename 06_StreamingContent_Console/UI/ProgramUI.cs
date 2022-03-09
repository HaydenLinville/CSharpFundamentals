using _06_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly StreamingContentRepository _repo = new StreamingContentRepository();
        private readonly IConsole _console;

        public ProgramUI (IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedContentList();//Adding some movies before we even start
            //now do the proram stuff 
            RunMenu();

        }

        private void RunMenu() 
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();


            _console.WriteLine("Enter the number of the options you would like:\n" +
                "1. Show all content\n" +
                "2. Get content by title \n" +
                "3. Get content by minimum star rating\n" +
                "4. Add content to directory\n" +
                "5. Update content in directory\n" +
                "6. Remove content in directory\n" +
                "7. Exit");

            string userInput = _console.ReadLine();
            switch (userInput)
            {
                case "1":
                    ShowAllContent();
                    break;
                case "2":
                    GetContentByTitle();
                    break;
                case "3":
                    GetStarRatingByMinimum();
                    break;
                case "4":
                    AddContent();
                    break;
                case "5":
                    UpdateContent();
                    break;
                case "6":
                    RemoveContent();
                    break;
                case "7":
                case "e":
                case "exit":
                        continueToRun = false;
                    break;
                    default:
                        _console.WriteLine("Please enter a vaild number between 1 and 7.\n" +
                            "Prease any key to continue ...");
                        _console.ReadKey();
                        break;



            }


            }


        }

        private void AddContent()
        {
            _console.Clear(); //Clear the menu
            //Set aside a variable to hold the information from the user until I'm ready
            StreamingContent content = new StreamingContent();

            //Title
            _console.Write("Please enter a title: ");
            content.Title = _console.ReadLine();

            //Description
            _console.Write("Please enter a description: ");
            content.Description = _console.ReadLine();

            //star 
            _console.Write("Please enter a star rating 0-5: ");
            content.StarRating = double.Parse(_console.ReadLine());

            //Maturity Rating
            _console.Write("Select maturity rating:\n" +
            "1.  G\n" +
            "2.  PG\n" +
            "3.  PG-13\n" +
            "4.  R\n" +
            "5.  NC 17\n" +
            "6.  TV Y\n" +
            "7.  TV G\n" +
            "8.  TV PG\n" +
            "9.  TV 14\n" +
            "10. TV MA");

            string maturityRating = _console.ReadLine();
            
            switch (maturityRating)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_Y;
                    break;
                case "7":
                    content.MaturityRating = MaturityRating.TV_G;
                    break;
                case "8":
                    content.MaturityRating = MaturityRating.TV_PG;
                    break;
                case "9":
                    content.MaturityRating = MaturityRating.TV_14;
                    break;
                case "10":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;

                        
            }
            // GenreType
            //public enum genreType {horror =1, drama, fantasy, action, comedy, scifi, romance, broamance = 100)
            _console.WriteLine("Select a Genre:\n" +
                "1. Hororr\n" +
                "2. Drama\n" +
                "3. Fantasy\n" +
                "4. Action\n" +
                "5. Comedy\n" +
                "6. SciFi\n" +
                "7. Romance\n" +
                "8. Bromance\n");

            string genreInput = _console.ReadLine();

            int genreId = int.Parse(genreInput);

            content.GenreType = (GenreType)genreId;

            if (_repo.AddContentToDirecty(content))
            {
                _console.WriteLine("Success! Press anykey to contniue");
                _console.ReadKey();

            }
            else
            {
                _console.WriteLine("Failure! Press any key to contniue");
                _console.ReadKey();
            }

        }

        private void ShowAllContent()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _repo.GetContents();
            foreach(StreamingContent content in listOfContent)
            {
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Genre: {content.GenreType}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Star Ratin: {content.StarRating} Stars\n");

            }

            AnyKey();

        }

        private void GetContentByTitle()
        {
            _console.Clear();
            //prompt
            _console.Write("Enter a title: ");
            // capture input
            string title = _console.ReadLine();
            //Look up content
            StreamingContent content = _repo.GetContentByTitle(title);
            if(content != null)
            {
                DisplayContent(content);
            }
            else
            {
                _console.WriteLine("Couldn't find content by that title");
            }

            AnyKey();




        }

        private void GetStarRatingByMinimum()
        {
            _console.Clear();
            _console.Write("Please enter a minimum star rating: ");
            string ratingRaw = _console.ReadLine();
            double rating = double.Parse(ratingRaw);
            List<StreamingContent> listOfContent = _repo.GetStarRatingByMinimum(rating);
            foreach(StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            AnyKey();
        }

        private void UpdateContent()
        {
            _console.Clear();
            _console.Write("Please enter the title \n the movie you wish to update ");
            StreamingContent oldContent = _repo.GetContentByTitle(_console.ReadLine());
            if (oldContent != null)
            {

                //Copy add new content then modify 

                _console.Write("Please enter a title: ");
                string titleInput = _console.ReadLine();

                if (titleInput != "")
                {
                    oldContent.Title = titleInput;

                }




                //Description
                _console.Write("Please enter a description: ");

                string descInput = _console.ReadLine();
                if (descInput != "")
                {

                oldContent.Description = descInput;
                }

                //star 
                _console.Write("Please enter a star rating 0-5: ");
                string starInput = _console.ReadLine();
                if (starInput != "")
                {

                oldContent.StarRating = double.Parse(starInput);
                }

                //Maturity Rating
                _console.Write("Select maturity rating:\n" +
                "1.  G\n" +
                "2.  PG\n" +
                "3.  PG-13\n" +
                "4.  R\n" +
                "5.  NC 17\n" +
                "6.  TV Y\n" +
                "7.  TV G\n" +
                "8.  TV PG\n" +
                "9.  TV 14\n" +
                "10. TV MA");

                string maturityRating = _console.ReadLine();

                if (maturityRating != "")
                {


                switch (maturityRating)
                {
                    case "1":
                        oldContent.MaturityRating = MaturityRating.G;
                        break;
                    case "2":
                        oldContent.MaturityRating = MaturityRating.PG;
                        break;
                    case "3":
                        oldContent.MaturityRating = MaturityRating.PG13;
                        break;
                    case "4":
                        oldContent.MaturityRating = MaturityRating.R;
                        break;
                    case "5":
                        oldContent.MaturityRating = MaturityRating.NC_17;
                        break;
                    case "6":
                        oldContent.MaturityRating = MaturityRating.TV_Y;
                        break;
                    case "7":
                        oldContent.MaturityRating = MaturityRating.TV_G;
                        break;
                    case "8":
                        oldContent.MaturityRating = MaturityRating.TV_PG;
                        break;
                    case "9":
                        oldContent.MaturityRating = MaturityRating.TV_14;
                        break;
                    case "10":
                        oldContent.MaturityRating = MaturityRating.TV_MA;
                        break;


                }
                }
                // GenreType
                //public enum genreType {horror =1, drama, fantasy, action, comedy, scifi, romance, broamance = 100)
                _console.WriteLine("Select a Genre:\n" +
                    "1. Hororr\n" +
                    "2. Drama\n" +
                    "3. Fantasy\n" +
                    "4. Action\n" +
                    "5. Comedy\n" +
                    "6. SciFi\n" +
                    "7. Romance\n" +
                    "8. Bromance\n");

                string genreInput = _console.ReadLine();
                if (genreInput != "")
                {

                 int genreId = int.Parse(genreInput);

                    oldContent.GenreType = (GenreType)genreId;

                }



                //where I ended

            }
            else
                _console.WriteLine("No content by that name");

        }


        private void RemoveContent()
        {
            _console.Clear();

            List<StreamingContent> contentList = _repo.GetContents();
            int count = 0;

            foreach(StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}, {content.Title}");
            }

            _console.Write("What content do you want to remove?");
            int targetId = int.Parse(_console.ReadLine());
            int targetIndex = targetId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count())
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_repo.DeleteExistingContent(desiredContent)) 
                {
                    _console.WriteLine($"{desiredContent.Title} deleted successfully");
                }
                else
                    _console.WriteLine("Somthing went wrong.");
            
            }
            else
                _console.WriteLine("No content has that ID");

            AnyKey();
        }

        private void SeedContentList()
        {
            StreamingContent toyStory = new StreamingContent("ToyStory", "Its about toys and their story", 4, MaturityRating.PG, GenreType.Drama);
            StreamingContent batMan = new StreamingContent("Batman", "It is a man that is a bat", 5, MaturityRating.G, GenreType.Action);
            StreamingContent superMan = new StreamingContent("Superman", "Like Batmane but super", 3, MaturityRating.TV_G, GenreType.Comedy);
            _repo.AddContentToDirecty(batMan);
            _repo.AddContentToDirecty(superMan);
            _repo.AddContentToDirecty(toyStory);

        }


        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Genre: {content.GenreType}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Star Ratin: {content.StarRating} Stars\n");


        }



        private void AnyKey()
        {
            _console.WriteLine("Press any key to contniue...");
            _console.ReadKey();
        }

    }
}
