using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using MiniSocialMedia;

namespace MiniSocialMedia
{
    class Program
    {
        static Repository<User> _users = new();
        static User? _currentUser;
        static readonly string _dataFile = "social-data.json";
        static readonly string _logFile = "error.log";

        static void Main()
        {
            Console.Title = "MiniSocial - Console Edition";
            Console.WriteLine("=== MiniSocial ===");

            LoadData();

            while (true)
            {
                try
                {
                    if (_currentUser == null)
                        ShowLoginMenu();
                    else
                        ShowMainMenu();
                }
                catch (SocialException ex)
                {
                    ConsoleColorWrite(ConsoleColor.Red, $"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error!!");
                    LogError(ex);
                }

                Console.WriteLine("\nPress any key...");
                Console.ReadKey(true);
            }
        }

        static void ShowLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Register\n2. Login\n0. Exit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1": Register(); break;
                case "2": Login(); break;
                case "0": SaveData(); Environment.Exit(0); break;
            }
        }

        static void Register()
        {
            Console.Write("Username: ");
            var u = Console.ReadLine();

            Console.Write("Email: ");
            var e = Console.ReadLine();

            if (_users.Find(x => x.Username.Equals(u, StringComparison.OrdinalIgnoreCase)) != null)
                throw new SocialException("User already exists");

            var user = new User(u!, e!);
            _users.Add(user);
            Console.WriteLine("Registered successfully!");
        }

        static void Login()
        {
            Console.Write("Username: ");
            var u = Console.ReadLine();

            var user = _users.Find(x => x.Username.Equals(u, StringComparison.OrdinalIgnoreCase));
            if (user == null)
                throw new SocialException("User not found");

            _currentUser = user;
            _currentUser.OnNewPost += p =>
            {
                ConsoleColorWrite(ConsoleColor.Cyan,
                    $"New post by {p.Author}: {(p.Content.Length > 40 ? p.Content[..40] + "..." : p.Content)}");
            };

            Console.WriteLine($"Logged in as {_currentUser.Username}");
        }

        static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine($"Logged in: {_currentUser}");
            Console.WriteLine("1.Post\n2.View My Posts\n3.Timeline\n4.Follow\n5.List Users\n6.Logout\n0.Exit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1": PostMessage(); break;
                case "2": ShowPosts(_currentUser!.GetPosts()); break;
                case "3": ShowTimeline(); break;
                case "4": FollowUser(); break;
                case "5": ListUsers(); break;
                case "6": _currentUser = null; break;
                case "0": SaveData(); Environment.Exit(0); break;
            }
        }

        static void PostMessage()
        {
            Console.Write("Post (max 280 chars): ");
            var content = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(content)) return;
            _currentUser!.AddPost(content);
            Console.WriteLine("Post added!");
        }

        static void ShowTimeline()
        {
            var timeline = new List<Post>();
            timeline.AddRange(_currentUser!.GetPosts());

            foreach (var name in _currentUser.GetFollowingNames())
            {
                var user = _users.Find(u => u.Username.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                    timeline.AddRange(user.GetPosts());
            }

            var sorted = timeline.OrderByDescending(p => p.CreatedAt);
            ShowPosts(sorted);
        }

        static void ShowPosts(IEnumerable<Post> posts)
        {
            var list = posts.Take(20).ToList();
            if (!list.Any())
            {
                Console.WriteLine("No posts yet.");
                return;
            }

            foreach (var p in list)
            {
                Console.WriteLine(p);
                Console.WriteLine($"({p.CreatedAt.FormatTimeAgo()})");
                Console.WriteLine("-------------------");
            }
        }

        static void FollowUser()
        {
            Console.Write("Follow username: ");
            var u = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(u)) return;

            var user = _users.Find(x => x.Username.Equals(u, StringComparison.OrdinalIgnoreCase));
            if (user == null)
                throw new SocialException("User not found");

            _currentUser!.Follow(u);
            Console.WriteLine($"Now following @{u}");
        }

        static void ListUsers()
        {
            Console.WriteLine("Registered users:");
            foreach (var u in _users.GetAll().OrderBy(x => x.Username))
                Console.WriteLine($"{u,-15} {u.Email}");
        }

        // ========== FILE HANDLING ==========
        static void SaveData()
        {
            try
            {
                var data = _users.GetAll().Select(u => new
                {
                    u.Username,
                    u.Email,
                    Following = u.GetFollowing(),
                    Posts = u.GetPosts().Select(p => new { p.Content, p.CreatedAt })
                });

                File.WriteAllText(_dataFile,
                    JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));

                Console.WriteLine("Data saved.");
            }
            catch (Exception ex)
            {
                LogError(ex);
                Console.WriteLine("Failed to save data.");
            }
        }

        static void LoadData()
        {
            if (!File.Exists(_dataFile)) return;

            try
            {
                var json = File.ReadAllText(_dataFile);
                Console.WriteLine("Data loaded (simulation).");
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        static void LogError(Exception ex)
        {
            try
            {
                File.AppendAllText(_logFile,
                    $"\n[{DateTime.Now}]\n{ex.Message}\n{ex.StackTrace}\n");
            }
            catch { }
        }

        static void ConsoleColorWrite(ConsoleColor color, string text)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = old;
        }
    }
}
