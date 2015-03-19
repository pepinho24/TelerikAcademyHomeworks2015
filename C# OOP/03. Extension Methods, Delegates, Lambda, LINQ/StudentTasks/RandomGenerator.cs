﻿namespace StudentTasks
{
    using System;

    public static class RandomGenerator
    {
        public static Random RandomNumber = new Random();

        public static string GenerateRandomFirstName()
        {
            return FirstNames[RandomNumber.Next(0, FirstNames.Length)];
        }

        public static string GenerateRandomLastName()
        {
            return LastNames[RandomNumber.Next(0, LastNames.Length)];
        }

        /// <summary>
        /// The method gets digitsCount as parameter and returns a random number from 10^digitsCount to 10^(digitsCount + 1)-1
        /// Example: digits count = 4 => returned number will be from 1000 to 9999
        /// </summary>
        /// <param name="digitsCount">Number of digits.</param>
        /// <returns>A number with given number of digits.</returns>
        public static int GenerateRandomNumber(int digitsCount = 7)
        {
            // TODO exception if digitsCount>9
            int FNMin = 1;
            int FNMax = 9;
            for (int i = 0; i < digitsCount; i++)
            {
                FNMin *= 10;
                FNMax = (FNMax * 10) + 9;
            }

            return RandomNumber.Next(FNMin, FNMax + 1);
        }

        public static string GenerateRandomEmailDomain()
        {
            return EmailDomains[RandomNumber.Next(0, EmailDomains.Length)];
        }

        public static int GenerateRandomMark(int minMark = 2, int maxMark = 6)
        {
            return RandomNumber.Next(minMark, maxMark + 1);
        }

        public static string GenerateRandomTelephoneNumber()
        {
            return (TelephoneNumberCodes[RandomNumber.Next(0, TelephoneNumberCodes.Length)] + GenerateRandomNumber(RandomNumber.Next(3, 7)).ToString());
        }

        public static string[] TelephoneNumberCodes = new string[] {
                "+359", "+458", "+48", "+82", "+47", "02", "08", "015", "074" };

        public static string[] EmailDomains = new string[] {  
                "abv.bg", "facebook.com", "gmail.com",  "abv.bg","googlemail.com",
                "google.com","abv.bg", "hotmail.com", "hotmail.co.uk", "abv.bg", "mail.com", "abv.bg","msn.com",
                "yahoo.com", "yahoo.co.uk"};

        public static string[] FirstNames = new string[] { 
                "Allison","Arthur","Ana","Alex","Arlene","Alberto","Aki","Ayumi","Akane",
                "Barry","Bertha","Bill","Bonnie","Bret","Beryl",
                "Chantal","Cristobal","Claudette","Charley","Cindy","Chris","Chiaki",
                "Dean","Dolly","Danny","Danielle","Dennis","Debby",
                "Erin","Edouard","Erika","Earl","Emily","Ernesto","Emi","Etsuko",
                "Felix","Fay","Fabian","Frances","Franklin","Florence",
                "Gabielle","Gustav","Grace","Gaston","Gert","Gordon",
                "Humberto","Hanna","Henri","Hermine","Harvey","Helene","Hitomi",
                "Iris","Isidore","Isabel","Ivan","Irene","Isaac","Itoe",
                "Jerry","Josephine","Juan","Jeanne","Jose","Joyce","Junko",
                "Karen","Kyle","Kate","Karl","Katrina","Kirk","Kumiko","Kaori","Kazuko",
                "Lorenzo","Lili","Larry","Lisa","Lee","Leslie",
                "Michelle","Marco","Mindy","Maria","Michael","Miharu","Michiyo","Miyuki","Miwa","Miyako","Mieko",
                "Noel","Nana","Nicholas","Nicole","Nate","Nadine","Nanaho","Naoko",
                "Olga","Omar","Odette","Otto","Ophelia","Oscar",
                "Pablo","Paloma","Peter","Paula","Philippe","Patty",
                "Rebekah","Rene","Rose","Richard","Rita","Rafael","Reina","Rie",
                "Sebastien","Sayuri","Sally","Sam","Shary","Stan","Sandy","Sachiko",
                "Tanya","Teddy","Teresa","Tomas","Tammy","Tony","Toshie",
                "Van","Vicky","Victor","Virginie","Vince","Valerie",
                "Wendy","Wilfred","Wanda","Walter","Wilma","William",
                "Yumi","Youko"};

        public static string[] LastNames = new string[] {
                "Abbott",  "Acevedo",  "Acosta",  "Adams",  "Adkins",  "Aguilar",  "Aguirre",  "Albert",  "Alexander",  "Alford",  "Allen",  "Allison",  "Alston",  "Alvarado",  "Alvarez",  "Anderson",  "Andrews","Anthony","Armstrong","Arnold","Ashley","Atkins","Atkinson","Austin","Avery","Avila","Ayala","Ayers",
                "Bailey","Baird","Baker","Baldwin","Ball","Ballard","Banks","Barber","Barker","Barlow","Barnes","Barnett","Barr","Barrera","Barrett","Barron","Barry","Bartlett","Barton","Bass","Bates","Battle","Bauer","Baxter","Beach","Bean","Beard","Beasley","Beck","Becker","Bell","Bender","Benjamin","Bennett","Benson","Bentley","Benton","Berg","Berger","Bernard","Berry","Best","Bird","Bishop","Black","Blackburn","Blackwell","Blair","Blake","Blanchard","Blankenship","Blevins","Bolton","Bond","Bonner","Booker","Boone","Booth","Bowen","Bowers","Bowman","Boyd","Boyer","Boyle","Bradford","Bradley","Bradshaw","Brady","Branch","Bray","Brennan","Brewer","Bridges","Briggs","Bright","Britt","Brock","Brooks","Brown","Browning","Bruce","Bryan","Bryant","Buchanan","Buck","Buckley","Buckner","Bullock","Burch","Burgess","Burke","Burks","Burnett","Burns","Burris","Burt","Burton","Bush","Butler","Byers","Byrd",
                "Cabrera","Cain","Calderon","Caldwell","Calhoun","Callahan","Camacho","Cameron","Campbell","Campos","Cannon","Cantrell","Cantu","Cardenas","Carey","Carlson","Carney","Carpenter","Carr","Carrillo","Carroll","Carson","Carter","Carver","Case","Casey","Cash","Castaneda","Castillo","Castro","Cervantes","Chambers","Chan","Chandler","Chaney","Chang","Chapman","Charles","Chase","Chavez","Chen","Cherry","Christensen","Christian","Church","Clark","Clarke","Clay","Clayton","Clements","Clemons","Cleveland","Cline","Cobb","Cochran","Coffey","Cohen","Cole","Coleman","Collier","Collins","Colon","Combs","Compton","Conley","Conner","Conrad","Contreras","Conway","Cook","Cooke","Cooley","Cooper","Copeland","Cortez","Cote","Cotton","Cox","Craft","Craig","Crane","Crawford","Crosby","Cross","Cruz","Cummings","Cunningham","Curry","Curtis",
                "Dale","Dalton","Daniel","Daniels","Daugherty","Davenport","David","Davidson","Davis","Dawson","Day","Dean","Decker","Dejesus","Delacruz","Delaney","Deleon","Delgado","Dennis","Diaz","Dickerson","Dickson","Dillard","Dillon","Dixon","Dodson","Dominguez","Donaldson","Donovan","Dorsey","Dotson","Douglas","Downs","Doyle","Drake","Dudley","Duffy","Duke","Duncan","Dunlap","Dunn","Duran","Durham","Dyer",
                "Eaton","Edwards","Elliott","Ellis","Ellison","Emerson","England","English","Erickson","Espinoza","Estes","Estrada","Evans","Everett","Ewing",
                "Farley","Farmer","Farrell","Faulkner","Ferguson","Fernandez","Ferrell","Fields","Figueroa","Finch","Finley","Fischer","Fisher","Fitzgerald","Fitzpatrick","Fleming","Fletcher","Flores","Flowers","Floyd","Flynn","Foley","Forbes","Ford","Foreman","Foster","Fowler","Fox","Francis","Franco","Frank","Franklin","Franks","Frazier","Frederick","Freeman","French","Frost","Fry","Frye","Fuentes","Fuller","Fulton",
                "Gaines","Gallagher","Gallegos","Galloway","Gamble","Garcia","Gardner","Garner","Garrett","Garrison","Garza","Gates","Gay","Gentry","George","Gibbs","Gibson","Gilbert","Giles","Gill","Gillespie","Gilliam","Gilmore","Glass","Glenn","Glover","Goff","Golden","Gomez","Gonzales","Gonzalez","Good","Goodman","Goodwin","Gordon","Gould","Graham","Grant","Graves","Gray","Green","Greene","Greer","Gregory","Griffin","Griffith","Grimes","Gross","Guerra","Guerrero","Guthrie","Gutierrez","Guy","Guzman",
                "Hahn","Hale","Haley","Hall","Hamilton","Hammond","Hampton","Hancock","Haney","Hansen","Hanson","Hardin","Harding","Hardy","Harmon","Harper","Harrell","Harrington","Harris","Harrison","Hart","Hartman","Harvey","Hatfield","Hawkins","Hayden","Hayes","Haynes","Hays","Head","Heath","Hebert","Henderson","Hendricks","Hendrix","Henry","Hensley","Henson","Herman","Hernandez","Herrera","Herring","Hess","Hester","Hewitt","Hickman","Hicks","Higgins","Hill","Hines","Hinton","Hobbs","Hodge","Hodges","Hoffman","Hogan","Holcomb","Holden","Holder","Holland","Holloway","Holman","Holmes","Holt","Hood","Hooper","Hoover","Hopkins","Hopper","Horn","Horne","Horton","House","Houston","Howard","Howe","Howell","Hubbard","Huber","Hudson","Huff","Huffman","Hughes","Hull","Humphrey","Hunt","Hunter","Hurley","Hurst","Hutchinson","Hyde",
                "Ingram","Irwin",
                "Jackson","Jacobs","Jacobson","James","Jarvis","Jefferson","Jenkins","Jennings","Jensen","Jimenez","Johns","Johnson","Johnston","Jones","Jordan","Joseph","Joyce","Joyner","Juarez","Justice",
                "Kane","Kaufman","Keith","Keller","Kelley","Kelly","Kemp","Kennedy","Kent","Kerr","Key","Kidd","Kim","King","Kinney","Kirby","Kirk","Kirkland","Klein","Kline","Knapp","Knight","Knowles","Knox","Koch","Kramer",
                "Lamb","Lambert","Lancaster","Landry","Lane","Lang","Langley","Lara","Larsen","Larson","Lawrence","Lawson","Le","Leach","Leblanc","Lee","Leon","Leonard","Lester","Levine","Levy","Lewis","Lindsay","Lindsey","Little","Livingston","Lloyd","Logan","Long","Lopez","Lott","Love","Lowe","Lowery","Lucas","Luna","Lynch","Lynn","Lyons",
                "Macdonald","Macias","Mack","Madden","Maddox","Maldonado","Malone","Mann","Manning","Marks","Marquez","Marsh","Marshall","Martin","Martinez","Mason","Massey","Mathews","Mathis","Matthews","Maxwell","May","Mayer","Maynard","Mayo","Mays","Mcbride","Mccall","Mccarthy","Mccarty","Mcclain","Mcclure","Mcconnell","Mccormick","Mccoy","Mccray","Mccullough","Mcdaniel","Mcdonald","Mcdowell","Mcfadden","Mcfarland","Mcgee","Mcgowan","Mcguire","Mcintosh","Mcintyre","Mckay","Mckee","Mckenzie","Mckinney","Mcknight","Mclaughlin","Mclean","Mcleod","Mcmahon","Mcmillan","Mcneil","Mcpherson","Meadows","Medina","Mejia","Melendez","Melton","Mendez","Mendoza","Mercado","Mercer","Merrill","Merritt","Meyer","Meyers","Michael","Middleton","Miles","Miller","Mills","Miranda","Mitchell","Molina","Monroe","Montgomery","Montoya","Moody","Moon","Mooney","Moore","Morales","Moran","Moreno","Morgan","Morin","Morris","Morrison","Morrow","Morse","Morton","Moses","Mosley","Moss","Mueller","Mullen","Mullins","Munoz","Murphy","Murray","Myers",
                "Nash","Navarro","Neal","Nelson","Newman","Newton","Nguyen","Nichols","Nicholson","Nielsen","Nieves","Nixon","Noble","Noel","Nolan","Norman","Norris","Norton","Nunez",
                "Obrien","Ochoa","Oconnor","Odom","Odonnell","Oliver","Olsen","Olson","Oneal","Oneil","Oneill","Orr","Ortega","Ortiz","Osborn","Osborne","Owen","Owens",
                "Pace","Pacheco","Padilla","Page","Palmer","Park","Parker","Parks","Parrish","Parsons","Pate","Patel","Patrick","Patterson","Patton","Paul","Payne","Pearson","Peck","Pena","Pennington","Perez","Perkins","Perry","Peters","Petersen","Peterson","Petty","Phelps","Phillips","Pickett","Pierce","Pittman","Pitts","Pollard","Poole","Pope","Porter","Potter","Potts","Powell","Powers","Pratt","Preston","Price","Prince","Pruitt","Puckett","Pugh",
                "Quinn",
                "Ramirez","Ramos","Ramsey","Randall","Randolph","Rasmussen","Ratliff","Ray","Raymond","Reed","Reese","Reeves","Reid","Reilly","Reyes","Reynolds","Rhodes","Rice","Rich","Richard","Richards","Richardson","Richmond","Riddle","Riggs","Riley","Rios","Rivas","Rivera","Rivers","Roach","Robbins","Roberson","Roberts","Robertson","Robinson","Robles","Rocha","Rodgers","Rodriguez","Rodriquez","Rogers","Rojas","Rollins","Roman","Romero","Rosa","Rosales","Rosario","Rose","Ross","Roth","Rowe","Rowland","Roy","Ruiz","Rush","Russell","Russo","Rutledge","Ryan",
                "Salas","Salazar","Salinas","Sampson","Sanchez","Sanders","Sandoval","Sanford","Santana","Santiago","Santos","Sargent","Saunders","Savage","Sawyer","Schmidt","Schneider","Schroeder","Schultz","Schwartz","Scott","Sears","Sellers","Serrano","Sexton","Shaffer","Shannon","Sharp","Sharpe","Shaw","Shelton","Shepard","Shepherd","Sheppard","Sherman","Shields","Short","Silva","Simmons","Simon","Simpson","Sims","Singleton","Skinner","Slater","Sloan","Small","Smith","Snider","Snow","Snyder","Solis","Solomon","Sosa","Soto","Sparks","Spears","Spence","Spencer","Stafford","Stanley","Stanton","Stark","Steele","Stein","Stephens","Stephenson","Stevens","Stevenson","Stewart","Stokes","Stone","Stout","Strickland","Strong","Stuart","Suarez","Sullivan","Summers","Sutton","Swanson","Sweeney","Sweet","Sykes",
                "Talley","Tanner","Tate","Taylor","Terrell","Terry","Thomas","Thompson","Thornton","Tillman","Todd","Torres","Townsend","Tran","Travis","Trevino","Trujillo","Tucker","Turner","Tyler","Tyson",
                "Underwood",
                "Valdez","Valencia","Valentine","Valenzuela","Vance","Vang","Vargas","Vasquez","Vaughan","Vaughn","Vazquez","Vega","Velasquez","Velazquez","Velez","Villarreal","Vincent","Vinson",
                "Wade","Wagner","Walker","Wall","Wallace","Waller","Walls","Walsh","Walter","Walters","Walton","Ward","Ware","Warner","Warren","Washington","Waters","Watkins","Watson","Watts","Weaver","Webb","Weber","Webster","Weeks","Weiss","Welch","Wells","West","Wheeler","Whitaker","White","Whitehead","Whitfield","Whitley","Whitney","Wiggins","Wilcox","Wilder","Wiley","Wilkerson","Wilkins","Wilkinson","William","Williams","Williamson","Willis","Wilson","Winters","Wise","Witt","Wolf","Wolfe","Wong","Wood","Woodard","Woods","Woodward","Wooten","Workman","Wright","Wyatt","Wynn",
                "Yang","Yates","York","Young",
                "Zamora","Zimmerman"};
    }
}
