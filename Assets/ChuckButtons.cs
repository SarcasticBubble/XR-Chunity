using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuckButtons : MonoBehaviour
{
    public int handClosed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HandClosed()
    {
        handClosed = 1;
        
        
    }
    
    public void HandOpen()
    {
        handClosed = 0;
    }

    public void ButtonOne()
    {
        GetComponent<ChuckSubInstance>().RunCode(string.Format(@"
        TriOsc tri => dac;
        {0} => int handClosed;
        if (handClosed == 0) {{
            1 => tri.gain;
        }} else {{
            .3 => tri.gain;
        }}
        Std.mtof(64) => tri.freq;
        300::ms => now;

", handClosed));
    }
    
    public void ButtonTwo()
    {
        GetComponent<ChuckSubInstance>().RunCode(string.Format(@"
        TriOsc tri => dac;
        {0} => int handClosed;
        if (handClosed == 0) {{
            0.9 => tri.gain;
        }} else {{
            0.2 => tri.gain;
        }}
        Std.mtof(66) => tri.freq;
        300::ms => now;

", handClosed));
    }
    
    public void ButtonThree()
    {
        GetComponent<ChuckSubInstance>().RunCode(string.Format(@"
        TriOsc tri => dac;
        {0} => int handClosed;
        if (handClosed == 0) {{
            0.9 => tri.gain;
        }} else {{
            0.2 => tri.gain;
        }}
        Std.mtof(68) => tri.freq;
        300::ms => now;

", handClosed));
    }
    
}
