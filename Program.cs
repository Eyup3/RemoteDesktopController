﻿public class Program
{
    public static void Main(string[] args)
    {
        new WebServer().Start("http://192.168.2.169", 4000);
        new TcpLiveServer().Start("192.168.2.169", 4001);
    }
}