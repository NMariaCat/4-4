using _4_3.Models;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4_3.ViewModels;

public class MainViewModel : ViewModelBase
{
    public List<NewsEntity> newsEntities { get; set; }
    public List<BlogEntity> blogEntities { get; set; }
    public MainViewModel()
    {
        blogEntities = new List<BlogEntity>()
        {
            new BlogEntity() { Text = "Программа должна компилироваться и правильно выполнять все требования", Article = "Article 1", ImagePath = "square.png", Tags = new List<string>{ "Tags: ","Tag 1 ", "Tag 2 ", "Tag 3" } },
            new BlogEntity() { Text = "Корректное и отражающее смысловую нагрузку именование переменных на английском языке", Article = "Article 2", ImagePath = "round.png", Tags = new List<string> { "Tags: ","Tag 4 ", "Tag 5 ", "Tag 6" } },
            new BlogEntity() { Text = "Корректно проставлены модификаторы уровня доступа для всех членов классов", Article = "Article 3", ImagePath = "triangle.png", Tags= new List<string>{ "Tags: ", "Tag 7 ", "Tag 8 ", "Tag 9 " } }


        };

        newsEntities = new List<NewsEntity>()
        {
            new NewsEntity() { Text = "Переиспользование кода должно преобладать над его дублированием", PublishDate = DateTime.Now },
            new NewsEntity() { Text = "Члены класса должны быть разделены друг от друга пустыми строками", PublishDate = DateTime.Today.AddDays(-1) },
            new NewsEntity() { Text = "Код всего задания следует поместить в один проект (.csproj) ", PublishDate = DateTime.Today.AddDays(-3) }
        };


    }
}



    
