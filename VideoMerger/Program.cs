using System;
using System.IO;
using FFmpeg;
using FFmpeg.Net;

class Program
{
    static void Main(string[] args)
    {
        // Get the input and output directories.
        var inputDirectory = args[0];
        var outputDirectory = args[1];

        // Check if the input directory exists.
        if (!Directory.Exists(inputDirectory))
        {
            Console.WriteLine("The input directory does not exist.");
            return;
        }

        // Check if the output directory exists.
        if (!Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }

        // Get the list of DAV files in the input directory.
        var davFiles = Directory.GetFiles(inputDirectory, "*.dav");

        // Iterate over the DAV files and convert them into MP4 files.
        foreach (var davFile in davFiles)
        {
            // Get the name of the MP4 file.
            var mp4FileName = Path.GetFileNameWithoutExtension(davFile) + ".mp4";

            // Check if the MP4 file already exists.
            if (File.Exists(Path.Combine(outputDirectory, mp4FileName)))
            {
                // The MP4 file already exists.
                // Get the next available file name.
                var index = 1;
                var newMp4FileName = mp4FileName;
                while (File.Exists(Path.Combine(outputDirectory, newMp4FileName)))
                {
                    newMp4FileName = mp4FileName + " (" + index + ")";
                    index++;
                }
                mp4FileName = newMp4FileName;
            }

            // Create the MP4 file.
            using (var mp4File = File.Create(Path.Combine(outputDirectory, mp4FileName)))
            {
                // Create the FFmpeg instance.
                var ffmpeg = new FFmpegClient(new FFmpegClientOptions())

                // Add the input file to the FFmpeg instance.
                ffmpeg.Input(inputFileName);

                // Set the output file for the FFmpeg instance.
                ffmpeg.Output(outputFileName);

                // Start the FFmpeg instance.
                ffmpeg.Start();

                // Wait for the FFmpeg instance to finish.
                ffmpeg.WaitForCompletion();

                // Display a message indicating that the conversion was successful.
                Console.WriteLine("The conversion was successful.");
            }
        }

        // Merge the MP4 files into one file.
        var ffmpeg = FFmpeg.Conversions.New();
        foreach (var mp4File in Directory.GetFiles(outputDirectory, "*.mp4"))
        {
            ffmpeg.AddInput(mp4File);
        }
        ffmpeg.SetOutput(Path.Combine(outputDirectory, "output.mp4"));
        ffmpeg.Start();
        ffmpeg.WaitForCompletion();

        Console.WriteLine("The files have been converted and merged successfully.");
    }
}