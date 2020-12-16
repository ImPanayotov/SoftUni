﻿namespace _01.Logger.Models.Interfaces
{
   public interface IPathManager
    {
        string CurrentDirectoryPath { get; }

        string CurrentFilePath { get; }


        string GetCurrentPath();

        void EnsureDirectoryAndFileExists();
    }
}
