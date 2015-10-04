using System;
using System.IO;
using System.Net;
using System.Text;

class AudioFeedback {

    public static void postData(String ttsString)
    {
        var NdevConnection = WebRequest.Create("https://tts.nuancemobility.net:443/NMDPTTSCmdServlet/tts?appId=NMDPTRIAL_alexsmith1_me_com20151003091117&appKey=135048da39da7a888015d9d1d429b6eb3cd2f074e2e07facb0a766d308400b1b9054f6ca2e7052ae852b7f5955364591083505ea158497c62cfd99343da44fcd&ttsLang=en_US");
        NdevConnection.Method = "POST";
        NdevConnection.ContentType = "text/plain";
        ((HttpWebRequest)NdevConnection).Accept = "audio/x-wav";
        var data = Encoding.ASCII.GetBytes(ttsString);
        NdevConnection.ContentLength = data.Length;
        NdevConnection.GetRequestStream().Write(data, 0, data.Length);
        NdevConnection.GetRequestStream().Close();

        var response = (HttpWebResponse)NdevConnection.GetResponse();

        Stream reader = response.GetResponseStream();
        Stream writer = new StreamWriter("./audio.wav");

        byte[] data = new byte[1024];

        Int32 offset = 0;
        while (reader.CanRead)
        {
            Int32 count = reader.Read(data, offset, data.Length);
            offset += count;
            writer.Write(data, 0, count);
        }
    }

    public static void Main(String input)
    {
        postData(input);
    }
}

