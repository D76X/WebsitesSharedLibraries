﻿namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface IMenuItem
{
    public string Href { get; }
    public string Text { get; }
}