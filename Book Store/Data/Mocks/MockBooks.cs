using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory booksCategory = new MockCategory();
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book 
                    { 
                        Name = "Star Wars: Kenobi", 
                        ShortDescription = "The greatest hero in the galaxy faces his toughest challenge yet: He must stop being Obi-Wan-and become Crazy Old Ben.", 
                        Author = "Jochn Jackson Miller", 
                        Image = "/img/Kenobi Cover.jpg", 
                        Price = 23.99M,
                        LongDescription = "The greatest hero in the galaxy faces his toughest challenge yet: " +
                        "He must stop being Obi-Wan-and become Crazy Old Ben. For fans of movie-related novels like Darth Plagueis!" +
                        "In this original novel set between the events of Star Wars: Episode III Revenge of the Sith and Episode IV A New Hope, " +
                        "Obi-Wan Kenobi comes to the aid of the residents of Tatooine during his exile. But he struggles with his new mission when he realizes that protecting " +
                        "Luke Skywalker-the last hope of the galaxy-means setting aside his compassion and his Jedi warrior training, for the future of the galaxy lies not with " +
                        "Obi - Wan Kenobi, but with a mystical desert recluse known only by the name of Crazy Old Ben.",
                        isFavourite = true, 
                        Available = true, 
                        Category = booksCategory.AllCategories.First()
                    },
                    new Book
                    {
                        Name = "Lord of the Rings",
                        ShortDescription = "Continuing the story begun in The Hobbit, all three parts of the epic masterpiece, The Lord of the Rings, in one paperback.",
                        Author = "J. R. R. Tolkien",
                        Image = "/img/Lotr Cover.jpg",
                        Price = 29.99M,
                        LongDescription = "Continuing the story begun in The Hobbit, all three parts of the epic masterpiece, The Lord of the Rings, in one paperback. Features the definitive edition of the text, fold-out flaps with the original two-colour maps, and a revised and expanded index. " +
                        "Sauron, the Dark Lord, has gathered to him all the Rings of Power – the means by which he intends to rule Middle-earth. " +
                        "All he lacks in his plans for dominion is the One Ring – the ring that rules them all – which has fallen into the hands of the hobbit, Bilbo Baggins. In a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, " +
                        "as the Ring is entrusted to his care.He must leave his home and make a perilous journey across the realms of Middle - earth to the Crack of Doom, deep inside the territories of the Dark Lord.There he must destroy the Ring forever and foil the Dark Lord in his evil purpose. " +
                        "Since it was first published in 1954, The Lord of the Rings has been a book people have treasured." +
                        "Steeped in unrivalled magic and otherworldliness, its sweeping fantasy has touched the hearts of young and old alike. " +
                        "This single - volume paperback edition is the definitive text, fully restored with almost 400 corrections – with the full co - operation of Christopher Tolkien – and features a striking new cover.",
                        isFavourite = true,
                        Available = true,
                        Category = booksCategory.AllCategories.First()
                    },
                    new Book
                    {
                        Name = "Mamba Mentality",
                        ShortDescription = "The first book from the basketball superstar Kobe Bryant―a lavish, deep dive inside the mind of one of the most revered athletes of all timeIn the wake of his retirement from professional basketball.",
                        Author = "Kobe Bryant",
                        Image = "/img/Mamba Mentality Cover.jpg",
                        Price = 18.44M,
                        LongDescription = "The first book from the basketball superstar Kobe Bryant―a lavish, deep dive inside the mind of one of the most revered athletes of all timeIn the wake of his retirement from professional basketball, " +
                        "Kobe “The Black Mamba” Bryant has decided to share his vast knowledge and understanding of the game to take readers on an unprecedented journey to the core of the legendary “Mamba mentality.” " +
                        "Citing an obligation and an opportunity to teach young players, hardcore fans, and devoted students of the game how to play it “the right way,” The Mamba Mentality takes us inside the mind of one of the most intelligent, analytical, and creative basketball players ever." +
                        "For the first time, and in his own words, Bryant reveals his famously detailed approach and the steps he took to prepare mentally and physically to not just succeed at the game, but to excel. " +
                        "Readers will learn how Bryant studied an opponent, how he channeled his passion for the game, how he played through injuries.They’ll also get fascinating granular detail as he breaks down specific plays and match - ups from throughout his career." +
                        "Bryant’s detailed accounts are paired with stunning photographs by the Hall of Fame photographer Andrew D.Bernstein.Bernstein, long the Lakers and NBA official photographer, captured Bryant’s very first NBA photo in 1996 and his last in 2016―and hundreds of thousands in between, the record of a unique, twenty - year relationship between one athlete and one photographer." +
                        "The combination of Bryant’s narrative and Bernstein’s photos make The Mamba Mentality an unprecedented look behind the curtain at the career of one of the world’s most celebrated and fascinating athletes.",
                        isFavourite = true,
                        Available = true,
                        Category = booksCategory.AllCategories.First()
                    },
                    new Book
                    {
                        Name = "Unity 2018: Artificial Intelligence Cookbook",
                        ShortDescription = "Bla Bla",
                        Author = "Jorge Palacios",
                        Image = "/img/Unity AIC Cover.jpg",
                        Price = 44.99M,
                        LongDescription = "Interactive and engaging games come with intelligent enemies, and this intellectual behavior is combined with a variety of techniques collectively referred to as Artificial Intelligence. Exploring Unity's API, or its built-in features, allows limitless possibilities when it comes to creating your game's worlds and characters. This cookbook covers both essential and niche techniques to help you take your AI programming to the next level." +
                        "To start with, you’ll quickly run through the essential building blocks of working with an agent, programming movement, and navigation in a game environment, followed by improving your agent's decision-making and coordination mechanisms – all through hands-on examples using easily customizable techniques. You’ll then discover how to emulate the vision and hearing capabilities of your agent for natural and humanlike AI behavior, and later improve the agents with the help of graphs. This book also covers the new navigational mesh with improved AI and pathfinding tools introduced in the Unity 2018 update. You’ll empower your AI with decision-making functions by programming simple board games, such as tic-tac-toe and checkers, and orchestrate agent coordination to get your AIs working together as one." +
                        "By the end of this book, you’ll have gained expertise in AI programming and developed creative and interactive games.",
                        isFavourite = true,
                        Available = true,
                        Category = booksCategory.AllCategories.First()
                    },
                    new Book
                    {
                        Name = "FL STUDIO 20 攻略BOOK (IMAGE LINE)",
                        ShortDescription = "Bla Bla",
                        Author = "Tankobon Softcover",
                        Image = "/img/FL Studio 20 Cover.jpg",
                        Price = 53.00M,
                        LongDescription = "",
                        isFavourite = true,
                        Available = true,
                        Category = booksCategory.AllCategories.First()
                    },
                    new Book
                    {
                        Name = "Excelsior!: The Amazing Life of Stan Lee",
                        ShortDescription = "Bla Bla",
                        Author = "Stan Lee",
                        Image = "/img/Excelsior Cover.jpg",
                        Price = 10.74M,
                        LongDescription = "The man behind Spider-Man, The X-Men, The Incredible Hulk, and a legion of other superheroes tells his own amazing story in a book packed with punch, humor, anecdotes, and a gallery of never-before-seen photographs." +
                        "Stan Lee is the most legendary name in the history of comicbooks. The leading creative force behind the rise of Marvel Comics, he brought to life some of the world's best-known heroes and most infamous villains. His stories, featuring super- heroes who struggled against personal hang-ups and bad guys who possessed previously unseen psychological complexity, added wit and subtlety to a field previously locked into flat portrayals of good vs. evil. Lee put the human in the super-human. In the process, he created a new mythology for the twentieth century." +
                        "In this treasure trove of marvelous memories, Stan tells the story of his life with the same inimitable wit, energy, and offbeat spirit that he brought to the world of comicbooks. He moves from his impoverished childhood in Manhattan to his early days writing comicbooks, followed by military training films during World War II, through the rise of the Marvel empire in the 1960s to his recent adventures in Hollywood." +
                        "The story of a man who earned respect by blazing new creative trails in a storytelling form once dismissed as just for kids, Excelsior! is an inspirational story about following one's vision, no matter the odds. Yet it's also the story of how some of the most exciting and memorable characters in the pop - culture universe came to thrill a generation.",
                        isFavourite = true,
                        Available = true,
                        Category = booksCategory.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Book> GetBooks { get; set; }

        public Book GetObjectBook(int bookID)
        {
            throw new NotImplementedException();
        }
    }
}
