InstagramManager

This is a hobby project that is a work in progress.
It is also my first larger scale project so it probably is a mess.
I have tried making it modular but it could be a lot better.

What is this project for?
- Posting activities to a Instagram account. (For example quizzes and riddles)
- Reading comments on said activities and giving points based on answers.
- Maybe more but that's all for now.

All interaction with Instagram is done with InstagramApiSharp. https://github.com/ramtinak/InstagramApiSharp
Thanks to that this is possible for me.
Image editing is made with SkiaSharp. I chose SkiaSharp instead of System.Drawing because the latter didn't seem to be cross-platform. This ended not mattering to me because I ended up making a desktop application instead of a automatic web application for now because Instagram login challenges are easier to send manually.

What the project lacks.
- Unit tests. I should have done this from the beginning but they felt a little overwhelming. I will add them to the next project.
- Logging. This has to be added but not now. I will have to take a look at .net logging.
- Leaderboards and actions surrounding them. I'm dealing with this right now.
- Keeping track of posts. This is basically a db table with post identifiers and such.
- Reading comments and acting accordingly.

What you can do for now. (Might work or might not)
- Login to your account and submit verification codes if challenged.
- Post a quiz question to Instagram from OpenTDB.
