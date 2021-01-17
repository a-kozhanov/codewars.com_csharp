/*
https://www.codewars.com/kata/5b6375f707a2664ada00002a/csharp

7 kyu
Who's Online?

You have a group chat application, but who is online!?

You want to show your users which of their friends are online and available to chat!

Given an input of an array of objects containing usernames, status and time since last activity (in mins), create a function to work out who is online, offline and away.

If someone is online but their lastActivity was more than 10 minutes ago they are to be considered away.

The input data has the following structure:

// Example input:
new User[] 
{
  new User("David", UserStatus.Online, 10),
  new User("Lucy", UserStatus.Offline, 22),
  new User("Bob", UserStatus.Online, 104)
};

// Reference:
public enum UserStatus
{
  Online,
  Offline,
  Away
}

public class User
{
  public string Username;
  public UserStatus Status;
  public int LastActivity;
  public User(string username, UserStatus status, int lastActivity)
  {
    Username = username;
    Status = status;
    LastActivity = lastActivity;
  }
}
The corresponding output should look as follows:

Dictionary<UserStatus, IEnumerable<string>>
{
  {UserStatus.Online, new[] {"David"}},
  {UserStatus.Offline, new[] {"Lucy"}},
  {UserStatus.Away, new[] {"Bob"}}
};
If for example, no users are online the output should look as follows:

new Dictionary<UserStatus, IEnumerable<string>>
{
  {UserStatus.Offline, new[] {"Lucy"}},
  {UserStatus.Away, new[] {"Bob"}}
};
username will always be a string, status will always be either 'online' or 'offline' (UserStatus enum in C#) and lastActivity will always be number >= 0.

Finally, if you have no friends in your chat application, the input will be an empty array []. In this case you should return an empty object {} (empty Dictionary in C#).
*/


using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class WhosOnline
    {
        // public static Dictionary<UserStatus, IEnumerable<string>> WhosOnline(User[] friends)
        // {
        // return friends.GroupBy(f => f.Status == UserStatus.Online && f.LastActivity > 10 ? UserStatus.Away : f.Status,
        //   u => u.Username).ToDictionary(s => s.Key, s => s.AsEnumerable());

        // return friends.Select(x => new
        //     {Status = (x.LastActivity > 10 && x.Status == UserStatus.Online) ? UserStatus.Away : x.Status, User = x})
        //   .GroupBy(x => x.Status)
        //   .ToDictionary(x => x.Key, x => x.Select(y => y.User.Username));
        //
        // return friends.Select(x =>
        //     x.Status == UserStatus.Online && x.LastActivity > 10
        //       ? new User(x.Username, UserStatus.Away, x.LastActivity)
        //       : x)
        //   .GroupBy(x => x.Status, x => x.Username)
        //   .ToDictionary(x => x.Key, x => x.AsEnumerable());
        // }
    }
}