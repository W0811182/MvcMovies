2025.02.05
1607

I am restarting my MvcMovie today as I got to a roadblock on the azure deployment!
I didn't follow the instructions while doing it the first time so this time I am gonna do it cleanly :)

1608
Part 1 - Get Started

I created my "MvcMovies" ASP.NET Core MVC .net 8 web app and ran the first test. Weirdly it did not prompt about a certificate.

Part 2 - Add a Controller
1611 

Before I start this step I am going to quickly make my github repo for this project so I can commit and push part by part

1615
Cool! Now I have part 1 uploaded to a github repository and I can start on the next step

Part 2 is fully a testing and learning step so I am going to skip it. I am only going to commit when I complete a step and have created some code/content. 

1620
Part 3 - Add a view

I think the only thing I have to do for this step is change the "MvcMovies" in the shared layout to instead say "Movie App"

1628
I pushed what I did of the last part and now I am going to do part 4

Part 4 - Add a model

1629
I actually have to do this part! this model is for the movies table. The views and controller will come later in the same part.


1640
created my model and built the project to load the required packages

========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
========== Build completed at 4:40 PM and took 03.918 seconds ==========

1641
Its now time to create my controller and everything else I haven't yet with scaffolding

I chose 'MVC Controller with views, using entity framework'

to create a scaffolded item you need to have a model ready (like i just made! :) )

the scaffolding process creates the DbContext Class, controller and view. 
It also modified this .csproj of this project, the Program file and the appsettings

Now I am going to create my initial migration to create the table

1650
Add-Migration
Update-Database

I am getting some errors about the null concerns on some of my fields in the movie model. 
I am also getting an error about the connection to the SQL server. 
I will have to manually configure this, I remember going through it the first time I did this tutorial.

1655
I had to change a part within my connection string from mssql to "ProjectModels".
This is evident in the Object explorer as I found the name there, however, 
I don't entirely understand why its called that or where the name came from as opposed to the default in my appsetting.json

1658 
After booting up and testing I am able to navigate to the ~/movies URL and the view and CRUD are waiting.
I am now done with this step! commit time

1708
pushing commit

Part 5 - Working with a database

1709 
Its now time to create my seedData! the requirement for lab 4 is unique movies of our own choosing. So I will be adding that now

1727

seeding data is complete. Now I have to make some alterations for the initialization to actually take place

1729 
I made the changes and Now I am going to retest and see if my seeddata is taking

1746
I forgot I had to add the Ids manually to my seed data! I took a second getting through that error :)
now im on to the next part which means commit time!

Part 6 - Controller Methods and views

1749
First I am going to add some data annotation to my movie model, specifically the release data and price columns for now

1752
I think this was all I needed for this part so time for the next and another commit

