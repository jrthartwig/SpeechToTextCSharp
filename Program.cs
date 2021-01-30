using System.Runtime.InteropServices;
using System;
using System.Threading.Tasks;

namespace SpeechToTextCsharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await SpeechAI.RecognizeSpeechAsync();
        }
    }
}