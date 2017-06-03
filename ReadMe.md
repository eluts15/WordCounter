# Word Counter Application

Simply type in a phrase along with your favorite word from the phrase and watch the magic.

## Specification

| Behavior | Input | Output |
| :-------------     | :------------- | :------------- |
| Application takes accepts user's phrase | "my, my, my, my, welcome, welcome, welcome, to the land of Expectations!" | my, my, my, my, welcome, welcome, welcome, to the land of Expectations! |
| User specifies the word that they want to find frequency of if they wanted to find the frequency of the word "my" | my, my, my, my, welcome, welcome, welcome, to the land of Expectations! | 4 |
| If the user decides not to enter anything, frequency is set to zero. | "" | 0 |

## Installation/Prerequisites

Git Clone or Download at: https://github.com/eluts15/verbose-meme-team-word-counter.git

In order to get server up and running, run the following command:

  dnx run (simply because kestrel is to hard to remember hehe.)

Runs on the .Net Framework

Requires Nancy Web Framework located at: http://nancyfx.org/. You can also do this via Windows PowerShell with the Command:

Install-Package Nancy

PowerShell may prompt you to download Nuget. Download this if necessary, as it is required to by Nancy.

All being said, the project also includes the project.lock.json so you can just use that I suppose.

Run dnu restore if necessary to update dependencies.


## Usage

1. Behavior Driven Development with the  Nancy Web Framework.

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## Credits

Motivating text from the Phantom Tollbooth by Norton Juster

## Known Bugs

1. None!

## License

The MIT License

Copyright <2017> <Ethan Luts>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
