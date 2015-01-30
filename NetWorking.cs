using UnityEngine;
using System.Collections;
using System.IO;
using System.Net.Sockets;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

public class NetWorking : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ValueBox.GameStartDate = GetFastestNISTDate();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    void InternetDate()
    {
        TcpListener listener = new TcpListener(1302);
        listener.Start();

        while(true)
        {
            Console.WriteLine("Waiting");
            TcpClient client = listener.AcceptTcpClient();

        }
    }



    public DateTime GetFastestNISTDate()
    {
        var result = DateTime.MinValue;

        // Initialize the list of NIST time servers
        // http://tf.nist.gov/tf-cgi/servers.cgi
        string[] servers = new string[] {
        //"nist1-ny.ustiming.org",      //lag
        "64.113.32.5",    //FAST! 1s
        
        //"nist1-nj.ustiming.org",      //lag
        "nist1-pa.ustiming.org",
        "time-a.nist.gov",
        "time-b.nist.gov",
        //"nist1.aol-va.symmetricom.com",      //lag
        //"nist1.columbiacountyga.gov", //00000000000
        //"nist1-chi.ustiming.org",
        //"nist.expertsmi.com",         //00000000000
        "nist.netservicesgroup.com"
};

        // Try 5 servers in random order to spread the load
        System.Random rnd = new System.Random();
        //foreach (string server in servers.OrderBy(s => rnd.NextDouble()).Take(5))
        foreach (string server in servers)
        {
            try
            {
                Debug.Log(server);
                // Connect to the server (at port 13) and get the response
                string serverResponse = string.Empty;
                using (var reader = new StreamReader(new TcpClient(server, 13).GetStream()))
                {
                    serverResponse = reader.ReadToEnd();
                }
                Debug.Log(serverResponse);


                // If a response was received
                if (!string.IsNullOrEmpty(serverResponse))
                {
                    // Split the response string ("55596 11-02-14 13:54:11 00 0 0 478.1 UTC(NIST) *")
                    string[] tokens = serverResponse.Split(' ');

                    // Check the number of tokens
                    if (tokens.Length >= 6)
                    {
                        // Check the health status
                        string health = tokens[5];
                        if (health == "0")
                        {
                            // Get date and time parts from the server response
                            string[] dateParts = tokens[1].Split('-');
                            string[] timeParts = tokens[2].Split(':');

                            // Create a DateTime instance
                            DateTime utcDateTime = new DateTime(
                                Convert.ToInt32(dateParts[0]) + 2000,
                                Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2]),
                                Convert.ToInt32(timeParts[0]), Convert.ToInt32(timeParts[1]),
                                Convert.ToInt32(timeParts[2]));

                            // Convert received (UTC) DateTime value to the local timezone
                            result = utcDateTime;
                            return result;
                            // Response successfully received; exit the loop
                        }
                    }
                }
            }
            catch
            {
                // Ignore exception and try the next server
            }
        }
        return result;
    }
}
