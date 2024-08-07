﻿using System;
using System.Net;
using System.Net.Sockets;

namespace newUdpClient
{
    class newUdp
    {
        // <Snippet1>
        public static void GetAvailable(UdpClient u)
        {
            // Get the number of bytes available for reading.
            Console.WriteLine("Available value is {0}",
                u.Available);
        }
        // </Snippet1>

        // <Snippet2>
        public static void GetSetDontFragment(UdpClient u)
        {
            // Set the don't fragment flag for packets emanating from
            // this client.
            u.DontFragment = true;
            Console.WriteLine("DontFragment value is {0}",
                u.DontFragment);
        }
        // </Snippet2>

        // <Snippet3>
        public static void GetSetEnableBroadcast(UdpClient u)
        {
            // Set the Broadcast flag for this client.
            u.EnableBroadcast = true;
            Console.WriteLine("EnableBroadcast value is {0}",
                u.EnableBroadcast);
        }
        // </Snippet3>

        // <Snippet4>
        public static void GetSetExclusiveAddressUse(UdpClient u)
        {
            // Don't allow another client to bind to this port.
            u.ExclusiveAddressUse = true;
            Console.WriteLine("ExclusiveAddressUse value is {0}",
                u.ExclusiveAddressUse);
        }
        // </Snippet4>

        // <Snippet5>
        public static void GetSetTtl(UdpClient u)
        {
            // Set the Time To Live (TTL) for this client.
            u.Ttl = 42;
            Console.WriteLine("Ttl value is {0}",
                u.Ttl);
        }
        // </Snippet5>

        // <Snippet6>
        // Subscribe to a multicast group.
        public static void DoJoinMulticastGroup(UdpClient u, string mcast)
        {
            IPAddress[] multicastAddress = Dns.GetHostAddresses(mcast);

            u.JoinMulticastGroup(multicastAddress[0]);
            Console.WriteLine("Joined multicast Address {0}",
                multicastAddress[0]);
        }
        // </Snippet6>

        // <Snippet7>
        public static void GetSetMulticastLoopback(UdpClient u)
        {
            // Deliver multicast packets back to the sending client.
            u.MulticastLoopback = true;
            Console.WriteLine("MulticastLoopback value is {0}",
                u.MulticastLoopback);
        }
        // </Snippet7>

        [STAThread]
	static void Main(string[] args)
	{
            UdpClient u = new UdpClient();

            GetAvailable(u);
            GetSetDontFragment(u);
            GetSetEnableBroadcast(u);
            GetSetExclusiveAddressUse(u);
            GetSetTtl(u);

            DoJoinMulticastGroup(u, "224.0.0.1");
        }
    }
}
