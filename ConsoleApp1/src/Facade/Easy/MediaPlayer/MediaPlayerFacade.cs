using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Facade.Easy.MediaPlayer
{
    internal interface IPlayer
    {
        void Play(string filename);
    }

    internal interface IMediaPlayer
    {
        void PlayMedia(MediaTypes mediaTypes, string filename);
    }

    internal enum MediaTypes
    {
        Audio,
        Video,
        Subtitle,
    }

    internal class AudioPlayer : IPlayer
    {
        public void Play(string filename)
        {
            Console.WriteLine($"Playing audio... {filename}");
        }
    }

    internal class VideoPlayer : IPlayer
    {
        public void Play(string filename)
        {
            Console.WriteLine($"Playing video... {filename}");
        }
    }

    internal class SubtitlePlayer : IPlayer
    {
        public void Play(string filename)
        {
            Console.WriteLine($"Playing subtitle... {filename}");
        }
    }

    internal class MediaPlayerFacade : IMediaPlayer
    {
        private IPlayer _videoPlayer;
        private IPlayer _audioPlayer;
        private IPlayer _subtitlePlayer;

        public void PlayVideo(string filename)
        {
            _videoPlayer = new VideoPlayer();
            _videoPlayer.Play(filename);
        }

        public void PlayAudio(string filename)
        {
            _audioPlayer = new AudioPlayer();
            _audioPlayer.Play(filename);
        }

        public void PlaySubtitle(string filename)
        {
            _subtitlePlayer = new SubtitlePlayer();
            _subtitlePlayer.Play(filename);
        }

        public void PlayMedia(MediaTypes mediaTypes, string filename)
        {
            if (mediaTypes == MediaTypes.Audio)
            {
                PlayAudio(filename);
            }
            else if (mediaTypes == MediaTypes.Video)
            {
                PlayVideo(filename);
            }
            else if (mediaTypes == MediaTypes.Subtitle)
            {
                PlaySubtitle(filename);
            }
            else
            {
                throw new Exception("Unsupported media type");
            }
        }
    }
}
