namespace MarvelMovies.Migrations
{
    using MarvelMovies.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MarvelMovies.Models.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MarvelMovies.Models.MovieContext";
        }

        protected override void Seed(MarvelMovies.Models.MovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            List<Movie> movies = GetMovies();
            movies.ForEach(m => context.Movies.AddOrUpdate(i => i.ID, m));
            //Movie movie = new Movie
            //{
            //    Title = "Iron Man",

            //    Rated = "PG-13",
            //    Released = DateTime.Parse("02 May 2008"),
            //    Runtime = 126,
            //    Genre = "Action, Adventure, Drama",
            //    Director = "Jeffrey Tseng",
            //    Actors = "Robert Downey Jr., Terrence Howard, Shaun Toub, Dimitri Diatchenko",
            //    Plot = "Tony Stark had it all: a genius mind, fame, and even multinational corporation. But his life would soon change forever...",
            //    Poster = "tt1233205.jpg",
            //    ImdbRating = 6.5M,
            //    ImdbVotes = 697,
            //    ImdbID = "tt1233205"
            //};
            //context.Movies.Add(movie);

        }
        public static List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {

                new Movie
                {
                    Title = "Iron Man",

                    Rated = "PG-13",
                    Released = DateTime.Parse("02 May 2008"),
                    Runtime = 126,
                    Genre = "Action, Adventure, Drama",
                    Director = "Jeffrey Tseng",
                    Actors = "Robert Downey Jr., Terrence Howard, Shaun Toub, Dimitri Diatchenko",
                    Plot = "Tony Stark had it all: a genius mind, fame, and even multinational corporation. But his life would soon change forever...",
                    Poster = "tt1233205.jpg",
                    ImdbRating = 6.5M,
                    ImdbVotes = 697,
                    ImdbID = "tt1233205"
                },
                new Movie
                {
                    Title = "The Incredible Hulk",

                    Rated = "PG-13",
                    Released = DateTime.Parse("13 Jun 2008"),
                    Runtime = 112,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director = "Louis Leterrier",
                    Actors = "Edward Norton, Liv Tyler, Tim Roth, William Hurt",
                    Plot = "Depicting the events after the Gamma Bomb. 'The Incredible Hulk' tells the story of Dr Bruce Banner, who seeks a cure to his unique condition, which causes him to turn into a giant green monster under emotional stress. Whilst on the run from military which seeks his capture, Banner comes close to a cure. But all is lost when a new creature emerges; The Abomination.",
                    Poster = "tt0800080.jpg",
                    ImdbRating = 6.8M,
                    ImdbVotes = 374109,
                    ImdbID = "tt0800080"
                },
                new Movie{
                    Title =  "Iron Man 2",

                    Rated ="PG-13",
                    Released = DateTime.Parse("07 May 2010"),
                    Runtime = 124,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Jon Favreau",
                    Actors= "Robert Downey Jr., Gwyneth Paltrow, Don Cheadle, Scarlett Johansson",
                    Plot = "With the world now aware of his dual life as the armored superhero Iron Man, billionaire inventor Tony Stark faces pressure from the government, the press, and the public to share his technology with the military. Unwilling to let go of his invention, Stark, along with Pepper Potts, and James \"Rhodey\" Rhodes at his side, must forge new alliances - and confront powerful enemies.",
                    Poster = "tt1228705.jpg",
                    ImdbRating = 7.0M,
                    ImdbVotes= 612890,
                    ImdbID = "tt1228705"
                },
                new Movie{
                    Title =  "Thor",

                    Rated ="PG-13",
                    Released = DateTime.Parse("06 May 2011"),
                    Runtime = 115,
                    Genre = "Action, Adventure, Fantasy",
                    Director= "Kenneth Branagh",
                    Actors= "Chris Hemsworth, Natalie Portman, Tom Hiddleston, Anthony Hopkins",
                    Plot = "The warrior Thor (Hemsworth) is cast out of the fantastic realm of Asgard by his father Odin (Hopkins) for his arrogance and sent to Earth to live among humans. Falling in love with scientist Jane Foster (Portman) teaches Thor much-needed lessons, and his new-found strength comes into play as a villain from his homeland sends dark forces toward Earth.",
                    Poster = "tt0800369.jpg",
                    ImdbRating = 7.0M,
                    ImdbVotes= 634511,
                    ImdbID = "tt0800369"
                },
                new Movie{
                    Title =  "Captain America: The First Avenger",

                    Rated ="PG-13",
                    Released = DateTime.Parse("22 Jul 2011"),
                    Runtime = 124,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Joe Johnston",
                    Actors= "Chris Evans, Hayley Atwell, Sebastian Stan, Tommy Lee Jones",
                    Plot = "It is 1942, America has entered World War II, and sickly but determined Steve Rogers is frustrated at being rejected yet again for military service. Everything changes when Dr. Erskine recruits him for the secret Project Rebirth. Proving his extraordinary courage, wits and conscience, Rogers undergoes the experiment and his weak body is suddenly enhanced into the maximum human potential. When Dr. Erskine is then immediately assassinated by an agent of Nazi Germany's secret HYDRA research department (headed by Johann Schmidt, a.k.a. the Red Skull), Rogers is left as a unique man who is initially misused as a propaganda mascot; however, when his comrades need him, Rogers goes on a successful adventure that truly makes him Captain America, and his war against Schmidt begins.",
                    Poster = "tt0458339.jpg",
                    ImdbRating = 6.9M,
                    ImdbVotes= 610095,
                    ImdbID = "tt0458339"
                },
                new Movie{
                    Title =  "The Avengers",

                    Rated ="PG-13",
                    Released = DateTime.Parse("04 May 2012"),
                    Runtime = 143,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Joss Whedon",
                    Actors= "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth",
                    Plot = "Nick Fury is the director of S.H.I.E.L.D., an international peace-keeping agency. The agency is a who's who of Marvel Super Heroes, with Iron Man, The Incredible Hulk, Thor, Captain America, Hawkeye and Black Widow. When global security is threatened by Loki and his cohorts, Nick Fury and his team will need all their powers to save the world from disaster.",
                    Poster = "tt0848228.jpg",
                    ImdbRating = 8.1M,
                    ImdbVotes= 1122811,
                    ImdbID = "tt0848228"
                },
                new Movie{
                    Title =  "Iron Man 3",

                    Rated ="PG-13",
                    Released = DateTime.Parse("03 May 2013"),
                    Runtime = 130,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Shane Black",
                    Actors= "Robert Downey Jr., Gwyneth Paltrow, Don Cheadle, Guy Pearce",
                    Plot = "Marvel's \"Iron Man 3\" pits brash-but-brilliant industrialist Tony Stark/Iron Man against an enemy whose reach knows no bounds. When Stark finds his personal world destroyed at his enemy's hands, he embarks on a harrowing quest to find those responsible. This journey, at every turn, will test his mettle. With his back against the wall, Stark is left to survive by his own devices, relying on his ingenuity and instincts to protect those closest to him. As he fights his way back, Stark discovers the answer to the question that has secretly haunted him: does the man make the suit or does the suit make the man?",
                    Poster = "tt1300854.jpg",
                    ImdbRating = 7.2M,
                    ImdbVotes= 643821,
                    ImdbID = "tt1300854"
                },
                new Movie{
                    Title =  "Thor: The Dark World",

                    Rated ="PG-13",
                    Released = DateTime.Parse("08 Nov 2013"),
                    Runtime = 112,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Alan Taylor",
                    Actors= "Chris Hemsworth, Natalie Portman, Tom Hiddleston, Anthony Hopkins",
                    Plot = "Thousands of years ago, a race of beings known as Dark Elves tried to send the universe into darkness by using a weapon known as the Aether. Warriors from Asgard stop them but their leader Malekith escapes to wait for another opportunity. The warriors find the Aether and since it cannot be destroyed, they try to hide it. In the present day, Jane Foster awaits the return of Thor although it has been two years since they last saw once another. In the meantime, Thor has been trying to bring peace to the nine realms. Jane discovers an anomaly similar to the one that brought Thor to Earth. She goes to investigate, finds a wormhole, and is sucked into it. Back on Asgard, Thor wishes to return to Earth but his father, Odin refuses to let him. Thor learns from Heimdall, who can see into all of the realms, that Jane disappeared. Thor then returns to Earth just as Jane reappears. However, when some policemen try to arrest her, an unknown energy repulses them. Thor then brings Jane to Asgard to find out what happened to her. When the energy is released again, they discover that when Jane disappeared, she crossed paths with the Aether and it entered her. Malekith, upon sensing that the time to strike is now, seeks out the Aether. He attacks Asgard and Thor's mother Frigga is killed protecting Jane. Odin wants to keep Jane on Asgard so that Malekith will come. Thor disagrees with his plan, so with his cohorts, he decides to take Jane away. He enlists the aid of his brother, Loki. Unfortunately, Loki's motivations remain unknown.",
                    Poster = "tt1981115.jpg",
                    ImdbRating = 7.0M,
                    ImdbVotes= 497823,
                    ImdbID = "tt1981115"
                },
                new Movie{
                    Title =  "Captain America: The Winter Soldier",

                    Rated ="PG-13",
                    Released = DateTime.Parse("04 Apr 2014"),
                    Runtime = 136,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Anthony Russo, Joe Russo",
                    Actors= "Chris Evans, Samuel L. Jackson, Scarlett Johansson, Robert Redford",
                    Plot = "For Steve Rogers, awakening after decades of suspended animation involves more than catching up on pop culture; it also means that this old school idealist must face a world of subtler threats and difficult moral complexities. That becomes clear when Director Nick Fury is killed by the mysterious assassin, the Winter Soldier, but not before warning Rogers that SHIELD has been subverted by its enemies. When Rogers acts on Fury's warning to trust no one there, he is branded as a traitor by the organization. Now a fugitive, Captain America must get to the bottom of this deadly mystery with the help of the Black Widow and his new friend, The Falcon. However, the battle will be costly for the Sentinel of Liberty, with Rogers finding enemies where he least expects them while learning that the Winter Soldier looks disturbingly familiar.",
                    Poster = "tt1843866.jpg",
                    ImdbRating = 7.8M,
                    ImdbVotes= 613445,
                    ImdbID = "tt1843866"
                },
                new Movie{
                    Title =  "Guardians of the Galaxy",

                    Rated ="PG-13",
                    Released = DateTime.Parse("01 Aug 2014"),
                    Runtime = 121,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "James Gunn",
                    Actors= "Chris Pratt, Zoe Saldana, Dave Bautista, Vin Diesel",
                    Plot = "After stealing a mysterious orb in the far reaches of outer space, Peter Quill from Earth, is now the main target of a manhunt led by the villain known as Ronan the Accuser. To help fight Ronan and his team and save the galaxy from his power, Quill creates a team of space heroes known as the \"Guardians of the Galaxy\" to save the world.",
                    Poster = "tt2015381.jpg",
                    ImdbRating = 8.1M,
                    ImdbVotes= 862056,
                    ImdbID = "tt2015381"
                },
                new Movie{
                    Title =  "Avengers: Age of Ultron",

                    Rated ="PG-13",
                    Released = DateTime.Parse("01 May 2015"),
                    Runtime = 141,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Joss Whedon",
                    Actors= "Robert Downey Jr., Chris Hemsworth, Mark Ruffalo, Chris Evans",
                    Plot = "Tony Stark creates the Ultron Program to protect the world, but when the peacekeeping program becomes hostile, The Avengers go into action to try and defeat a virtually impossible enemy together. Earth's mightiest heroes must come together once again to protect the world from global extinction.",
                    Poster = "tt2395427.jpg",
                    ImdbRating = 7.4M,
                    ImdbVotes= 598311,
                    ImdbID = "tt2395427"
                },
                new Movie{
                    Title =  "Ant-Man",

                    Rated ="PG-13",
                    Released = DateTime.Parse("17 Jul 2015"),
                    Runtime = 117,
                    Genre = "Action, Adventure, Comedy",
                    Director= "Peyton Reed",
                    Actors= "Paul Rudd, Michael Douglas, Evangeline Lilly, Corey Stoll",
                    Plot = "Armed with the astonishing ability to shrink in scale but increase in strength, con-man Scott Lang must embrace his inner-hero and help his mentor, Dr. Hank Pym, protect the secret behind his spectacular Ant-Man suit from a new generation of towering threats. Against seemingly insurmountable obstacles, Pym and Lang must plan and pull off a heist that will save the world.",
                    Poster = "tt0478970.jpg",
                    ImdbRating = 7.3M,
                    ImdbVotes= 443392,
                    ImdbID = "tt0478970"
                },
                new Movie{
                    Title =  "Captain America: Civil War",

                    Rated ="PG-13",
                    Released = DateTime.Parse("06 May 2016"),
                    Runtime = 147,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Anthony Russo, Joe Russo",
                    Actors= "Chris Evans, Robert Downey Jr., Scarlett Johansson, Sebastian Stan",
                    Plot = "With many people fearing the actions of super heroes, the government decides to push for the Hero Registration Act, a law that limits a hero's actions. This results in a division in The Avengers. Iron Man stands with this Act, claiming that their actions must be kept in check otherwise cities will continue to be destroyed, but Captain America feels that saving the world is daring enough and that they cannot rely on the government to protect the world. This escalates into an all-out war between Team Iron Man (Iron Man, Black Panther, Vision, Black Widow, War Machine, and Spider-Man) and Team Captain America (Captain America, Bucky Barnes, Falcon, Scarlet Witch, Hawkeye, and Ant Man) while a new villain emerges.",
                    Poster = "tt3498820.jpg",
                    ImdbRating = 7.8M,
                    ImdbVotes= 521062,
                    ImdbID = "tt3498820"
                },
                new Movie{
                    Title =  "Doctor Strange",

                    Rated ="PG-13",
                    Released = DateTime.Parse("04 Nov 2016"),
                    Runtime = 115,
                    Genre = "Action, Adventure, Fantasy",
                    Director= "Scott Derrickson",
                    Actors= "Benedict Cumberbatch, Chiwetel Ejiofor, Rachel McAdams, Benedict Wong",
                    Plot = "Marvel's \"Doctor Strange\" follows the story of the talented neurosurgeon Doctor Stephen Strange who, after a tragic car accident, must put ego aside and learn the secrets of a hidden world of mysticism and alternate dimensions. Based in New York City's Greenwich Village, Doctor Strange must act as an intermediary between the real world and what lies beyond, utilising a vast array of metaphysical abilities and artifacts to protect the Marvel Cinematic Universe.",
                    Poster = "tt1211837.jpg",
                    ImdbRating = 7.5M,
                    ImdbVotes= 442460,
                    ImdbID = "tt1211837"
                },
                new Movie{
                    Title =  "Guardians of the Galaxy Vol. 2",

                    Rated ="PG-13",
                    Released = DateTime.Parse("05 May 2017"),
                    Runtime = 136,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "James Gunn",
                    Actors= "Chris Pratt, Zoe Saldana, Dave Bautista, Vin Diesel",
                    Plot = "After saving Xandar from Ronan's wrath, the Guardians are now recognized as heroes. Now the team must help their leader Star Lord (Chris Pratt) uncover the truth behind his true heritage. Along the way, old foes turn to allies and betrayal is blooming. And the Guardians find that they are up against a devastating new menace who is out to rule the galaxy.",
                    Poster = "tt3896198.jpg",
                    ImdbRating = 7.7M,
                    ImdbVotes= 397820,
                    ImdbID = "tt3896198"
                },
                new Movie{
                    Title =  "Thor: Ragnarok",

                    Rated ="PG-13",
                    Released = DateTime.Parse("03 Nov 2017"),
                    Runtime = 130,
                    Genre = "Action, Adventure, Comedy",
                    Director= "Taika Waititi",
                    Actors= "Chris Hemsworth, Tom Hiddleston, Cate Blanchett, Idris Elba",
                    Plot = "Thor is imprisoned on the other side of the universe and finds himself in a race against time to get back to Asgard to stop Ragnarok, the destruction of his homeworld and the end of Asgardian civilization, at the hands of an all-powerful new threat, the ruthless Hela.",
                    Poster = "tt3501632.jpg",
                    ImdbRating = 7.9M,
                    ImdbVotes= 380599,
                    ImdbID = "tt3501632"
                },
                new Movie{
                    Title =  "Black Panther",

                    Rated ="PG-13",
                    Released = DateTime.Parse("16 Feb 2018"),
                    Runtime = 134,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Ryan Coogler",
                    Actors= "Chadwick Boseman, Michael B. Jordan, Lupita Nyong'o, Danai Gurira",
                    Plot = "After the events of Captain America: Civil War, King T'Challa returns home to the reclusive, technologically advanced African nation of Wakanda to serve as his country's new leader. However, T'Challa soon finds that he is challenged for the throne from factions within his own country. When two foes conspire to destroy Wakanda, the hero known as Black Panther must team up with C.I.A. agent Everett K. Ross and members of the Dora Milaje, Wakanadan special forces, to prevent Wakanda from being dragged into a world war.",
                    Poster = "tt1825683.jpg",
                    ImdbRating = 7.4M,
                    ImdbVotes= 369850,
                    ImdbID = "tt1825683"
                },
                new Movie{
                    Title =  "Avengers: Infinity War",

                    Rated ="PG-13",
                    Released = DateTime.Parse("27 Apr 2018"),
                    Runtime = 149,
                    Genre = "Action, Adventure, Fantasy",
                    Director= "Anthony Russo, Joe Russo",
                    Actors= "Robert Downey Jr., Chris Hemsworth, Mark Ruffalo, Chris Evans",
                    Plot = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.",
                    Poster = "tt4154756.jpg",
                    ImdbRating = 8.7M,
                    ImdbVotes= 441693,
                    ImdbID = "tt4154756"
                },
                new Movie{
                    Title =  "Ant-Man and the Wasp",

                    Rated ="PG-13",
                    Released = DateTime.Parse("06 Jul 2018"),
                    Runtime = 118,
                    Genre = "Action, Adventure, Sci-Fi",
                    Director= "Peyton Reed",
                    Actors= "Paul Rudd, Evangeline Lilly, Michael Peña, Walton Goggins",
                    Plot = "In the aftermath of 'Captain America: Civil War,' Scott Lang grapples with the consequences of his choices as both a Super Hero and a father. As he struggles to re-balance his home life with his responsibilities as Ant-Man, he's confronted by Hope van Dyne and Dr. Hank Pym with an urgent new mission. Scott must once again put on the suit and learn to fight alongside The Wasp as the team works together to uncover secrets from their past.",
                    Poster = "tt5095030.jpg",
                    ImdbRating = 7.4M,
                    ImdbVotes= 90901,
                    ImdbID = "tt5095030"
                }
            };
            return movies;
        }
    }
}
