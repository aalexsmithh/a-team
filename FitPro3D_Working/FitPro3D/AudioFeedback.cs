using System;
using System.IO;
using System.Net;
using System.Text;

class AudioFeedback {

    public void postData(String ttsString)
    {
        var NdevConnection = WebRequest.Create("https://tts.nuancemobility.net:443/NMDPTTSCmdServlet/tts?appId=NMDPTRIAL_alexsmith1_me_com20151003091117&appKey=135048da39da7a888015d9d1d429b6eb3cd2f074e2e07facb0a766d308400b1b9054f6ca2e7052ae852b7f5955364591083505ea158497c62cfd99343da44fcd&ttsLang=en_US");
        NdevConnection.Method = "POST";
        NdevConnection.ContentType = "text/plain; charset=utf-8";
        ((HttpWebRequest)NdevConnection).Accept = "audio/x-wav";
        var data = Encoding.UTF8.GetBytes(ttsString);
        NdevConnection.ContentLength = data.Length;
        NdevConnection.GetRequestStream().Write(data, 0, data.Length);
        NdevConnection.GetRequestStream().Close();

        var response = (HttpWebResponse)NdevConnection.GetResponse();

        BinaryReader reader =  new BinaryReader(response.GetResponseStream());        
        FileStream temp = File.Open("./audio.wav", FileMode.Create);
        BinaryWriter writer = new BinaryWriter(temp);

        Byte[] Buffer = new Byte[1024];
        while (true)
        {
            Int32 count = reader.Read(Buffer, 0, Buffer.Length);
            writer.Write(Buffer, 0, count);
            if(count == 0)
            {
                break;
            }
        }
        writer.Flush();
        temp.Close();
    }

    //public static void Main()
    //{
    //    postData("hello");
    //}
}

