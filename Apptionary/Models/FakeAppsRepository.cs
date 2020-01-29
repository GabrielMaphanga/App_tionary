
using System.Collections.Generic;
using System.Linq;


namespace Apptionary.Models
{
    public class FakeAppRepository : IAppsRepository
    {
        
        public IQueryable<App> AppList => new List<App>
        { new App { Name = "facebook", Description = "Facebook is an American online social media and social networking service company based in Menlo Park, California. Its website was launched on February 4, 2004, by Mark Zuckerberg, along with fellow Harvard College students and roommates Eduardo Saverin, Andrew McCollum, Dustin Moskovitz and Chris Hughes", Category ="Web" },
                  new App { Name = "uber", Description = "Uber is a ridesharing app for fast, reliable rides in minutes—day or night. There’s no need to park or wait for a taxi or bus.With Uber, you just tap to request a ride, and it’s easy to pay with credit or cash in select tities", Category = "Android"  },
                    new App { Name = "vlc", Description = "VLC media player is a free and open source cross-platform multimedia player that plays most multimedia files as well as discs, devices, and network streaming protocols.",Category = "Windows"},
                    new App { Name = "subway surfers", Description = "Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog" ,Category = "Android" },
                    new App { Name = "bike racing 3d", Description = "Bike Racing 3D is the No.1 xtreme BMX game with insane and stunt action! Bury the competition as you drive through a variety of treacherous tracks while enjoying the realistic bike physics and fast-paced gameplay",Category = "Android" },
                    new App { Name = "new24", Description = "Get breaking news, first, across South Africa and the world from News24, and catch up on the latest updates from Sport24, Fin24 and Channel24. Browse features from Wheels24, Women24, Food24, Parent24, Health24 and Traveller24 and keep up to date with the weather in your location from Weather 24", Category = "Android"  },
                    new App { Name = "bible", Description = "On more than 300 million devices around the world, people are reading, listening to, watching, and sharing the Bible using the #1 rated Bible App—completely free. 1,400+ Bible versions, 1,000+ languages. Listen to audio Bibles. Thousands of Reading Plans & Devotionals, in 40+ languages. Download the best rated Bible App",Category = "Linux" },
          new App { Name = "modern sniper", Description = "Aim and Shoot! Modern Sniper is #1 first person shooter game that will blown you away!",Category = "Android" },
          new App { Name = "whatsApp messenger", Description = "WhatsApp Messenger is a FREE messaging app available for Android and other smartphones. WhatsApp uses your phone's Internet connection (4G/3G/2G/EDGE or Wi-Fi, as available) to let you message and call friends and family. Switch from SMS to WhatsApp to send and receive messages, calls, photos, videos, documents, and Voice Messages", Category = "Android"  },
          new App { Name = "twitter", Description = "WhatsApp Messenger is a FREE messaging app available for Android and other smartphones. WhatsApp uses your phone's Internet connection (4G/3G/2G/EDGE or Wi-Fi, as available) to let you message and call friends and family. Switch from SMS to WhatsApp to send and receive messages, calls, photos, videos, documents, and Voice Messages" ,Category="Web"},
          new App { Name = "instagram", Description = "Instagram is a simple way to capture and share the world’s moments. Follow your friends and family to see what they’re up to, and discover accounts from all over the world that are sharing things you love. Join the community of over 800 million people and express yourself by sharing all the moments of your day––the highlights and everything in between, too",Category ="IOS"   },
          new App { Name = "candy crush saga", Description = "Plan your moves by matching 3 or more candies in a row, using boosters wisely in order to overcome those extra sticky levels! Smash the chocolate and collect ingredients across thousands of levels guaranteed to have you craving more!",Category ="Android" },
          new App { Name = "wordweb", Description = "The free offline English dictionary and thesaurus with synonyms, related words and great search - and no adverts. Audio pronunciations are available with the separate Audio Edition app.",Category = "Windows"},
          new App { Name = "snapchat", Description = "Life's more fun when you live in the moment :) Happy Snapping!",Category="IOS" },
          new App { Name = "kik", Description = "Kik is way more than just messaging. It’s the easiest way to connect with your friends, stay in the loop, and explore – all through chat. No phone numbers, just pick a username",Category = "IOS" },
          new App { Name = "spotify", Description = "Spotify is now free on mobile and tablet. Listen to the right music, wherever you are.With Spotify, you have access to a world of music. You can listen to artists and albums, or create your own playlist of your favorite songs. Want to discover new music? Choose a ready-made playlist that suits your mood or get personalized recommendations",Category = "Windows"
            }, new App {Name = "ubuntu", Description = "(/ʊˈbʊntuː/;[6] stylized as ubuntu) is a free and open sourceoperating system and Linux distribution based on Debian. Ubuntu is offered in three official editions: Ubuntu Desktop for personal computers, Ubuntu Server for servers and the cloud, and Ubuntu Core for Internet of things devices and robots.New releases of Ubuntu occur every six months, while long-term support (LTS) releases occur every two years", Category = "Operating Systems"},
              new App {Name = "windows xp", Description = "Windows XP is a personal computer operating system that was produced by Microsoft as part of the Windows NT family of operating systems. It was released to manufacturing on August 24, 2001, and broadly released for retail sale on October 25, 2001.",Category = "Operating Systems" },new App
              {
                  Name = "android", Description = "Android is a mobile operating system developed by Google, based on a modified version of the Linux kernel and other open source software and designed primarily for touchscreen mobile devices such as smartphones and tablets. In addition, Google has further developed Android TV for televisions, Android Auto for cars, and Wear OS for wrist watches, each with a specialized user interface. Variants of Android are also used on game consoles, digital cameras, PCs and other electronics.", Category = "Operating Systems"
              }, new App { Name = "iOS", Description ="iOS (formerly iPhone OS) is a mobile operating system created and developed by Apple Inc. exclusively for its hardware. It is the operating system that presently powers many of the company's mobile devices, including the iPhone, iPad, and iPod Touch. It is the second most popular mobile operating system globally after Android.", Category = "Operating Systems" }, new App{Name = "windows vista", Description = "Windows Vista is an operating system that was produced by Microsoft for use on personal computers, including home and business desktops, laptops, tablet PCs and media center PCs. Development was completed on 8 November 2006, and over the following three months, it was released in stages to computer hardware and software manufacturers, business customers and retail channels. On 30 January 2007, it was released worldwide and was made available for purchase and download from the Windows Marketplace. The release of Windows Vista came more than five years after the introduction of its predecessor, Windows XP, the longest time span between successive releases of Microsoft Windows desktop operating systems.",Category = "Operating Systems"}, new App{Name = "windows 7", Description = "Windows 7 is a personal computer operating system that was produced by Microsoft as part of the Windows NT family of operating systems. It was released to manufacturing on July 22, 2009 and became generally available on October 22, 2009, less than three years after the release of its predecessor, Windows Vista. Windows 7's server counterpart, Windows Server 2008 R2, was released at the same time.",Category = "Operating Systems"}, new App{Name = "windows 8",Description = "is a personal computer operating system that was produced by Microsoft as part of the Windows NT family of operating systems. The operating system was released to manufacturing on August 1, 2012, with general availability on October 26, 2012.[5] Windows 8 introduced major changes to the operating system's platform and user interface to improve its user experience on tablets, where Windows was now competing with mobile operating systems, including Android and iOS.",Category = "Operating Systems"}, new App{ Name = "windows 8.1",Description = "Windows 8.1 is a personal computer operating system that was produced by Microsoft and released as part of the Windows NT family of operating systems. It was released to manufacturing on August 27, 2013, and reached general availability on October 17, 2013, about a year after the retail release of its predecessor. Windows 8.1 was made available as a free upgrade for retail copies of Windows 8 and Windows RT users via the Windows Store.",Category = "Operating Systems" },new App{Name= "windows 10",Description="Windows 10 is a series of personal computer operating systems produced by Microsoft as part of the Windows NT family of operating systems. It was released on July 29, 2015.[8] Windows 10 receives new releases on an ongoing basis, which are available at no additional cost to users. Devices in enterprise environments can receive these updates at a slower pace, or use long-term support milestones that only receive critical updates, such as security patches, over their ten-year lifespan of extended support.",Category = "Operating Systems"},new App{ Name = "macOS", Description ="macOS (/ˌmækʔoʊˈɛs/;[7] previously Mac OS X and later OS X) is a series of graphical operating systems developed and marketed by Apple Inc. since 2001. It is the primary operating system for Apple's Mac family of computers. Within the market of desktop, laptop and home computers, and by web usage, it is the second most widely used desktop OS, after Microsoft Windows.",Category ="Operating Systems"}

               



        }.AsQueryable<App>();

        IEnumerable<App> IAppsRepository.AppList => AppList;

        private ApplicationDbContext context;

        public FakeAppRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        

        public App GetApp(long key) => context.Apps.First(a => a.AppID == key);



        public void AddApp(App app)
        {
            this.context.Apps.Add(app);
            this.context.SaveChanges();
        }

        public void UpdateApp(App app)
        {
            App a = context.Apps.Find(app.AppID);

            a.Name = app.Name;
            //a.Category = app.Category
            a.Description = app.Description;

            context.SaveChanges();

        }

        public void SaveApp(App app)
        {
            if (app.AppID == 0)
            {
                context.Apps.Add(app);
            }
            else
            {
                App dbEntry = context.Apps
                .FirstOrDefault(a => a.AppID == app.AppID);
                if (dbEntry != null)
                {
                    dbEntry.Name = app.Name;
                    dbEntry.Description = app.Description;
                    dbEntry.Category = app.Category;
                }
            }
            context.SaveChanges();
        }
    }
}
    

